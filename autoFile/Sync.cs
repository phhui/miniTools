using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ppqq
{
    /**同步文件，根据两个目录下所有文件的md5判断是否相同，如果不相同则同步过去**/
    public partial class Sync : Form
    {
        public Sync()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Sync_Load(object sender, EventArgs e)
        {
            if (File.Exists("source.txt")) tb_source.Text = File.ReadAllText("source.txt");
            if (File.Exists("target.txt")) tb_target.Text = File.ReadAllText("target.txt");
            if (File.Exists("filter.txt")) tb_filter.Text = File.ReadAllText("filter.txt");
        }

        private void btn_sync_Click(object sender, EventArgs e)
        {
            tb_source.Text = tb_source.Text.Replace("\\", "/");
            tb_target.Text = tb_target.Text.Replace("\\", "/");
            if (tb_source.Text.Substring(tb_source.Text.Length - 1) != "/") tb_source.Text += "/";
            if (tb_target.Text.Substring(tb_target.Text.Length - 1) != "/") tb_target.Text += "/";
            File.WriteAllText("source.txt", tb_source.Text);
            File.WriteAllText("target.txt", tb_target.Text);
            File.WriteAllText("filter.txt", tb_filter.Text);
            if (tb_source.Text.Trim().Length < 3)
            {
                MessageBox.Show("请选择源路径！");
                return;
            }
            if (tb_target.Text.Trim().Length < 3)
            {
                MessageBox.Show("请选择目标路径！");
                return;
            }
            try
            {
                tb_log.Text = "正在同步，请稍候。。。。。。";
                Thread th = new Thread(sync);
                th.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show("同步失败！失败信息：\r\n" + err.Message);
            }
        }
        private void sync()
        {
            string sourcePath = tb_source.Text;
            string targetPath = tb_target.Text;
            tb_filter.Text = tb_filter.Text.Replace('，', ',');
            string[] filter = tb_filter.Text.Split(',');
            syncResult sr = new syncResult();
            sr.filter = filter;
            FileHelper.syncDir(sourcePath, targetPath, sr);
            tb_log.Text = (sr.result ? "同步完成\r\n" : "同步失败：" + sr.errMsg);
            tb_log.Text += sr.syncList;
        }
        private void tb_source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                tb_source.Text=dlg.SelectedPath.ToString();
        }

        private void tb_target_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                tb_target.Text = dlg.SelectedPath.ToString();

        }

        private void tb_source_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
