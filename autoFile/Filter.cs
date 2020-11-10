using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ppqq
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void filterCN_Click(object sender, EventArgs e)
        {
            txt.Text= Regex.Replace(txt.Text,@"[\u4e00-\u9fa5]", "");
        }

        private void filterTab_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text.Replace("   ","");
        }

        private void filterSpace_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text.Replace(" ", "");
        }

        private void getAtrr_Click(object sender, EventArgs e)
        {
            txt.Text= Regex.Replace(txt.Text, @"[\u4e00-\u9fa5]", "");
            //txt.Text = txt.Text.Replace("   ", "");
            //txt.Text = txt.Text.Replace(" ", "");
            txt.Text = txt.Text.Replace("[", "");
            txt.Text = txt.Text.Replace("]", "");
            txt.Text = txt.Text.Replace("egret.DisplayObject", "");
            txt.Text = txt.Text.Replace("egret.TextField", "");
            txt.Text = txt.Text.Replace("egret.HashObject", "");
            txt.Text = txt.Text.Replace("DisplayObjectContainer", "");
            txt.Text = txt.Text.Replace("X", "");
            txt.Text = txt.Text.Replace("Y", "");
            txt.Text = txt.Text.Replace("Inherited", "");
            txt.Text = txt.Text.Replace("\r\n", "){\r\nthis.txt.xx=value;\r\n}\r\n");
            //txt.Text = txt.Text.Replace("[", "");
            //txt.Text = txt.Text.Replace("[", "");
        }
    }
}
