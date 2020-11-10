using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ppqq
{
    public partial class autoSkinObj : Form
    {
        private FileListDetails fld;
        private Thread t;
        private delegate void delegateFunc();
        public autoSkinObj()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getFileList();
        }
        private void readFileList()
        {
            t = new Thread(sinvoke);//创建子线程
            t.Start();//启动子线程
            list.Items.Clear();
            list.Items.Add("正在读取文件列表，请稍候。。。");
        }
        private void sinvoke()
        {
            getFileList();
        }
        private void getFileList()
        {
            fld = FileHelper.getFileList("E:/h5/tjny/tjny/trunk/resource/skins", true);
            this.Invoke(new delegateFunc(showlist));
        }
        private void showlist()
        {
            list.Items.Clear();
            foreach (FileInfo fi in fld.fileList)
            {
                String name = fi.FullName.Substring(fi.FullName.LastIndexOf("skins") + 6);
                name = name.Replace("\\","/");
                list.Items.Add(name);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo fi = fld.fileList[list.SelectedIndex];
            if (!File.Exists(fi.FullName)) return;
            String ct = File.ReadAllText(fi.FullName);
            String res = "";
            String tmp = ct;
            while(tmp.IndexOf(" id=") != -1)
            {
                String start = tmp.Substring(0,tmp.IndexOf(" id="));
                start= start.Substring(start.LastIndexOf(":") + 1);
                String type = (start.IndexOf(" ")!=-1?start.Substring(0,start.IndexOf(" ")):start);
                tmp = tmp.Substring(tmp.IndexOf(" id=")+5);
                String id = tmp.Substring(0, tmp.IndexOf("\""));
                res += "    public " + id + ":eui." + type+";\r\n";
            }
            log.Text = res;
        }

        private void btnRefeach_Click(object sender, EventArgs e)
        {
            getFileList();
        }
    }
}
