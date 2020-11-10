using System;
using System.Windows.Forms;

namespace ppqq
{
    public partial class TxtWin : Form
    {
        private FontDict fd = new FontDict();
        private string text = "";
        public TxtWin()
        {
            InitializeComponent();
        }

        private void TxtWin_Load(object sender, EventArgs e)
        {

        }
        public void showMsg(String data)
        {
            text = data;
            txt_msg.Text = data;
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (tb_str0.Text.Length < 1)
            {
                MessageBox.Show("替换内容不能为空！！！");
                return;
            }
            txt_msg.Text = txt_msg.Text.Replace(tb_str0.Text, tb_str1.Text);
        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {
            txt_msg.Text = fd.getPingyin(txt_msg.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string tmp = txt_msg.Text;
            string res = "";
            while (tmp.IndexOf("\n") != -1)
            {
                string str = tmp.Substring(0, tmp.IndexOf("\n") + 2);
                if (cb_in.Checked)
                {
                    if (str.IndexOf(tb_filter.Text) != -1) res += str;
                }else{
                    if (str.IndexOf(tb_filter.Text) == -1) res += str;
                }
                tmp = tmp.Substring(tmp.IndexOf("\n") + 2);
            }
            txt_msg.Text = res;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_msg.Text = text;
        }

        private void txt_msg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
