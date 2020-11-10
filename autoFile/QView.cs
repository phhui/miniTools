using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;

namespace ppqq
{
    public partial class QView : Form
    {
        public QView()
        {
            InitializeComponent();
        }

        private void QView_Load(object sender, EventArgs e)
        {

        }
        public void showMsg(String data)
        {
            if (FileHelper.checkType(data) == FileHelper.CMD_TYPE_TXT)
            {
                tb.Text = data + "：\r\n" + File.ReadAllText(data, Encoding.GetEncoding("gb2312"));
                tb.Visible = true;
                pb.Visible = false;
            }
            else if (FileHelper.checkType(data) == FileHelper.CMD_TYPE_IMG)
            {
                pb.Image = Image.FromFile(data);
                pb.Visible = true;
                tb.Visible = false;
            }
            else this.Hide();
        }
    }
}
