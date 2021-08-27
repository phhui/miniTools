using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace ppqq
{
    /**检测H5的资源配置中的文件是否存在**/
    public partial class CheckFile : Form
    {
        public CheckFile()
        {
            InitializeComponent();
        }

        private void CheckFile_Load(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            JArray obj= JArray.Parse(txt.Text);
            for(int i = 0; i < obj.Count; i++)
            {
                if (!File.Exists("D:/wk/h5/dlm/dlm-pro/skin0/" + obj[i]["url"]))
                {
                    txt_output.AppendText(obj[i]["url"]+"------不存在！\r\n");
                }
            }
        }
    }
}
