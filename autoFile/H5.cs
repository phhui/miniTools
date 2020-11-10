using System;
using System.IO;
using System.Windows.Forms;

namespace ppqq
{
    public partial class H5 : Form
    {
        private string configPath = "conf/conf.txt";
        private string key1 = "INFO";
        private string key2 = "Info";
        private string key3 = "info";
        public H5()
        {
            InitializeComponent();
        }

        private void H5_Load(object sender, EventArgs e)
        {
            tmp.Text = "配置conf目录下的conf.txt\r\n";
            tmp.Text += "格式：'模板路径,目标路径'   一行一个文件\r\n";
            tmp.Text += "程序会根据配置读取模板路径文件内容，将关键字符替换成模块名并创建对应文件到目标路径";
        }
        private void Btn_create_Click(object sender, EventArgs e)
        {
            btn_saveConfig.Visible = false;
            if (tb_name.Text.Trim().Length < 1)
            {
                MessageBox.Show("请输入模块名称！");
                return;
            }
            string[] fl = nName();
            foreach (string s in fl)
            {
                string[] fn = s.Split(',');
                string path = fn[1].Substring(0, fn[1].LastIndexOf("/"))+"/"+tb_name.Text;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path+"/" + fn[1].Substring(fn[1].LastIndexOf("/")+1);
                if (File.Exists(fn[1]))
                {
                    logShow("目标路径已存在【" + converName(fn[0]).Substring(4) + "】，生成失败！");
                }
                else
                {
                    if (!File.Exists(fn[0]))
                    {
                        logShow("模板【" + fn[0] + "】不存在，生成失败！");
                        return;
                    }
                    string ctt = File.ReadAllText(fn[0]);
                    string nct = converName(ctt);
                    try
                    {
                        File.WriteAllText(path.Replace("\r", ""), nct);
                        logShow("【" + converName(fn[0]).Substring(4) + "】生成成功！");
                    }
                    catch (Exception err)
                    {
                        logShow("【" + converName(fn[0]).Substring(4) + "】生成失败！\r\n" + err.Message);
                    }

                }
            }
            logShow("- - - - - - - - - - - - - - - - - - - - - - -");
        }
        private string converName(string s)
        {
            //s = s.Replace(key1, tb_name.Text.ToUpper());
            s = s.Replace(key2, tb_name.Text.ToUpper().Substring(0, 1) + tb_name.Text.ToLower().Substring(1));
            //s = s.Replace(key3, tb_name.Text.ToLower());
            return s;
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
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            btn_saveConfig.Visible = false;
            if (tb_name.Text.Trim().Length < 1)
            {
                MessageBox.Show("请输入模块名称！");
                return;
            }
            if (MessageBox.Show("确认删除模块【" + tb_name.Text + "】相关代码？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string[] fl = nName();
                string path = "";
                foreach (string s in fl)
                {
                    string[] fn = s.Split(',');
                    path = fn[1].Substring(0, fn[1].LastIndexOf("/")) + "/" + tb_name.Text;
                    fn[1] = fn[1].Substring(0, fn[1].LastIndexOf("/")) + "/" + tb_name.Text+ "/" + fn[1].Substring(fn[1].LastIndexOf("/") + 1);
                    if (File.Exists(fn[1]))
                    {
                        File.Delete((fn[1]));
                        logShow("【" + fn[1] + "】，删除成功！");
                    }
                    else
                    {
                        logShow("模板【" + fn[1] + "】不存在，删除失败！");
                    }
                }
                Directory.Delete(path);
            }
            logShow("- - - - - - - - - - - - - - - - - - - - - - -");
        }
        private void logShow(string msg)
        {
            log.Text += msg + "\r\n";
            log.Select(log.TextLength, 0);
            log.ScrollToCaret();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            log.Text = "";
            btn_saveConfig.Visible = false;
        }

        private void Btn_config_Click(object sender, EventArgs e)
        {
            log.Text = File.ReadAllText(configPath);
            btn_saveConfig.Visible = true;
        }

        private void Btn_saveConfig_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configPath, log.Text);
            btn_saveConfig.Visible = false;
            MessageBox.Show("修改成功。");
        }

    }
}
