using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ppqq
{
    public partial class GetFileList : Form
    {
        public GetFileList()
        {
            InitializeComponent();
        }

        private void GetFileList_Load(object sender, EventArgs e)
        {
            getChildList("D:/wk/h5/dlm/dlm-pro/src");
        }
        private void getChildList(string path)
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (DirectoryInfo fc in folder.GetDirectories())
            {
                if (fc.Name == "game" || fc.Name == "build" || fc.Name == "release" || fc.Name==".idea" || fc.Name == ".svn" || fc.Name == "resource") continue;
                getChildList(fc.FullName);
            }
            foreach (FileInfo file in folder.GetFiles())
            {
                //if (file.Name.IndexOf(".xml") != -1|| file.Name.IndexOf(".json") != -1)
                //{
                    string ct = File.ReadAllText(file.FullName);
                if (ct.IndexOf("isApp()") != -1)
                {
                    textBox1.Text += file.FullName.Replace("\\", "/") + "\r\n";
                }
                //}
            }
        }
        private void getDG()
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("ske", "{ \"name\":\"nameKey_ske\",\"type\":\"json\",\"url\":\"assets/dg/dKey/nameKey_ske.json\"},");
            dt.Add("tex", "{ \"name\":\"nameKey_tex\",\"type\":\"json\",\"url\":\"assets/dg/dKey/nameKey_tex.json\"},");
            dt.Add("png", "{ \"name\":\"nameKey_png\",\"type\":\"image\",\"url\":\"assets/dg/dKey/nameKey_tex.png\"},");
            DirectoryInfo folder = new DirectoryInfo("D:/wk/h5/dlm/dlm-pro/resource/assets/dg");
            string name = "";
            foreach (DirectoryInfo folderChild in folder.GetDirectories())
            {
                foreach (FileInfo file in folderChild.GetFiles())
                {
                    string str = "";
                    string fn = file.Name.Substring(0, file.Name.IndexOf("_"));
                    if (file.Name.IndexOf("ske") != -1)
                    {
                        str = dt["ske"];
                        fn += "_ske";
                    }
                    else if (file.Name.IndexOf("png") != -1)
                    {
                        str = dt["png"];
                        fn += "_png";
                    }
                    else if (file.Name.IndexOf("tex") != -1)
                    {
                        str = dt["tex"];
                        fn += "_tex";
                    }
                    str = str.Replace("dKey", folderChild.Name);
                    str = str.Replace("nameKey", file.Name.Substring(0, file.Name.IndexOf("_")));
                    name += fn + ",";
                    textBox1.Text += "" + str + "\r\n";
                }
                //textBox1.Text += "\r\n";
            }
            textBox1.Text += name;
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (tb_path.Text.Trim().Length < 3)
            {
                MessageBox.Show("请先设置路径");
                return;
            }
            tb_path.Text = tb_path.Text.Replace("\\","/");
            Dictionary<string, string> dir = FileHelper.getFileList(tb_path.Text, new Dictionary<string, string>());
        }
    }
}
