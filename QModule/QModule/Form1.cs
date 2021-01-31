using System;
using System.IO;
using System.Windows.Forms;

namespace QModule
{
    public partial class Form1 : Form
    {
        private string configPath = "conf/conf.txt";
        private string key1 = "INFO";
        private string key2 = "Info";
        private string key3 = "info";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Trim().Length < 1)
            {
                MessageBox.Show("请输入模块名称！");
                return;
            }
            String moduleName = tb_name.Text.Substring(0, 1).ToUpper() + tb_name.Text.Substring(1).ToLower();
            String[] fnList = new String[5] { "Cmd.ts", "Mgr.ts", "Controller.ts", "Ui.ts", "Proxy.ts" };
            String[] ctList = new String[5] { H5Module.cmd, H5Module.mgr, H5Module.controll, H5Module.ui, H5Module.proxy };
            for (int i = 0; i < 5; i++)
            {
                String fn = moduleName + fnList[i];
                if (!Directory.Exists(tb_name.Text))
                {
                    Directory.CreateDirectory(tb_name.Text.ToLower());
                }
                if (File.Exists(fn))
                {
                    logShow("目标路径已存在【" + fn + "】，生成失败！");
                }
                else
                {
                    string ctt = ctList[i];
                    string nct = converName(ctt);
                    try
                    {
                        File.WriteAllText(tb_name.Text.ToLower() + "/" + fn, nct);
                        logShow("【" + fn + "】生成成功！");
                    }
                    catch (Exception err)
                    {
                        logShow("【" + fn + "】生成失败！\r\n" + err.Message);
                    }

                }
            }
            logShow("- - - - - - - - - - - - - - - - - - - - -");
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
        private string[] nName()
        {
            string conf = File.ReadAllText(configPath);
            string[] list = conf.Split('\n');
            string[] nlist = new string[list.Length];
            string n0 = tb_name.Text.ToUpper();
            string n1 = tb_name.Text.ToUpper().Substring(0, 1) + tb_name.Text.ToLower().Substring(1).ToLower();
            string n2 = tb_name.Text.ToLower();
            for (int i = 0; i < list.Length; i++)
            {
                string[] s = list[i].Split(',');
                nlist[i] = s[0] + "," + s[1].Replace(key1, n0).Replace(key2, n1).Replace(key3, n2);
            }
            return nlist;
        }
        private void logShow(string msg)
        {
            log.Text += msg + "\r\n";
            log.Select(log.TextLength, 0);
            log.ScrollToCaret();
        }
        private string converName(string s)
        {
            //s = s.Replace(key1, tb_name.Text.ToUpper());
            s = s.Replace(key2, tb_name.Text.ToUpper().Substring(0, 1) + tb_name.Text.ToLower().Substring(1));
            //s = s.Replace(key3, tb_name.Text.ToLower());
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            H5Module.load(this);
            //createRspd();
        }
        private void createRspd()
        {
            if (!File.Exists("src/com/kynet/protocols/MsgId.ts")) return;
            String ct = File.ReadAllText("src/com/kynet/protocols/MsgId.ts");
            String reg = "/**程序生成，请勿修改*/\r\n" + @"class RegRspd{
    constructor(){";
            String tmp = ct.Substring(ct.IndexOf("Rspd"));
            String cls = tmp.Substring(tmp.IndexOf("Rspd"), tmp.IndexOf(" "));
            reg += "\r\n        SocketMgr.regRspd(0,protocols." + cls + ");\r\n";
            while (tmp.IndexOf("Rspd") != -1 && tmp.IndexOf("SMSG") != -1)
            {
                tmp = tmp.Substring(tmp.IndexOf("SMSG"));
                String id = tmp.Substring(tmp.IndexOf("[") + 1, tmp.IndexOf("]") - tmp.IndexOf("[") - 1);
                tmp = tmp.Substring(tmp.IndexOf("Rspd"));
                cls = tmp.Substring(0, tmp.IndexOf(" "));
                if (id != "2007" && id != "2008") reg += "        SocketMgr.regRspd(" + id + ",protocols." + cls + ");\r\n";
                tmp = tmp.Substring(100);
            }
            reg += @"  
    }
}";
            File.WriteAllText("src/com/kynet/RegRspd.ts", reg);
            log.Text = "Rspd已生成";
        }
    }
}
