using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading;
/*
* QQ：412035160
* Author phhui 
* */
namespace ppqq
{
    public partial class FileMgr : Form
    {
        private FileListDetails fld;
        private int moveNum = 0;
        private int deleteNum = 0;
        private int curOverItem = 0;
        private TxtWin tw;
        private QView qv;
        private Thread t;
        private delegate void delegateFunc();
        public FileMgr()
        {
            InitializeComponent();
            tw = new TxtWin();
        }
        //
        private void deleteFile_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("您还未选择任何文件！");
            }
            else
            {
                if (MessageBox.Show("您确定要删除选中的文件？","提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    removeFile();
                }
            }
        }
        //删除文件
        private void removeFile()
        {
            foreach (string path in list_fileList.Items)
            {
                int res = FileHelper.deleteFile(path);
                if (res == FileHelper.CMD_FAILE_NO_FOUND) continue;
                if(res==FileHelper.CMD_FAILE_IN_USE){
                    MessageBox.Show("文件【"+path+"】正在使用中，无法进行删除！");
                    continue;
                }
                deleteNum++;
            }
            list_fileList.Items.Clear();//清空选择列表
            MessageBox.Show("文件删除成功，总共"+deleteNum.ToString()+"个文件被删除！");
            deleteNum = 0;
        }
        //移动文件
        private void btn_mobileFile_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择文件！");
                return;
            }
            DialogResult res = MessageBox.Show("您确定要移动选择列表中的所有文件？","提示",MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes) return;
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowNewFolderButton = true;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                if (list_fileList.Items.Count < 1)
                {
                    MessageBox.Show("您还未选择任何文件！");
                }
                else
                {
                    moveFile(fb.SelectedPath);
                }
            }
        }
        //将选择的文件移动到指定目录
        private void moveFile(string mobilePath)
        {
            foreach (string path in list_fileList.Items)
            {
                FileDetails fds = new FileDetails(path);
                int res = FileHelper.moveFile(path, mobilePath+"\\"+fds.name+fds.type);
                switch (res)
                {
                    case FileHelper.CMD_FAILE_NO_FOUND: MessageBox.Show("文件" + fds.name + fds.type + "不存在！");break;
                    case FileHelper.CMD_FAILE_IN_USE: MessageBox.Show("文件" + fds.name + fds.type + "正在使用中，无法移动！");break;
                    case FileHelper.CMD_FILE_ALREADY_EXISTS: MessageBox.Show("文件" + fds.name + fds.type + "已存在，无法移动！"); break;
                    case FileHelper.CMD_OK:moveNum++;break;
                }
            }
            readFileList();
            MessageBox.Show("文件移动完成！总共"+moveNum.ToString()+"个文件被移动！");
        }
        //选择文件
        private void fileList_DoubleClick(object sender, EventArgs e)
        {
            if (list_fileList.SelectedItem == null) return;
            list_fileList.Items.Remove(list_fileList.SelectedItem);
        }
        //刷新文件列表
        private void btn_refreshFileList_Click(object sender, EventArgs e)
        {
            readFileList();
        }
        private void readFileList()
        {
            t = new Thread(sinvoke);//创建子线程
            t.Start();//启动子线程
            list_fileList.Items.Clear();
            list_fileList.Items.Add("正在读取文件列表，请稍候。。。");
        }
        private void sinvoke()
        {
            getFileList();
        }
        private void getFileList()
        {
            fld = FileHelper.getFileList(filePath.Text, cb_contains.Checked);
            this.Invoke(new delegateFunc(showlist));
        }
        private void showlist()
        {
            list_fileList.Items.Clear();
            foreach (FileInfo fi in fld.fileList)
            {
                list_fileList.Items.Add(fi.FullName);
            }
            list_fileList.Sorted = true;
            File.WriteAllText("url.txt", filePath.Text);
        }
        //过滤文件
        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (txt_containsText.Text.Length < 1 || txt_containsText.Text == "过滤的字符串")
            {
                MessageBox.Show("请填写过滤字符！");
                return;
            }
            list_fileList.Items.Clear();
            string[] str = txt_containsText.Text.Replace("，",",").Split(',');
            foreach (FileInfo fi in fld.fileList)
            {
                Boolean res = false;
                foreach (string s in str)
                {
                    if (fi.Name.Contains(s))
                    {
                        res = true;
                    }
                }
                if (checkBox1.Checked && res)//包含指定字符的文件
                {
                    list_fileList.Items.Add(fi.FullName);
                }
                else if (!checkBox1.Checked && !res)//不包含指定字符的文件
                {
                    list_fileList.Items.Add(fi.FullName);
                }
            }
        }
        //全选
        private void btn_changeAll_Click(object sender, EventArgs e)
        {
            foreach (string i in list_fileList.Items)
            {
                list_fileList.Items.Add(i);
            }
            list_fileList.Items.Clear();
        }

        private void txt_containsText_Click(object sender, EventArgs e)
        {
            if (txt_containsText.Text == "过滤的字符串")
            {
                txt_containsText.Text = "";
            }
        }

        private void btn_reName_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择文件！");
                return;
            }
            if (list_fileList.Items.Count > 1)
            {
                MessageBox.Show("重命名只能对单个文件重命名！如需对多个文件重命名请使用序列重命名！");
                return;
            }
            if (txt_order.Text.Length < 1)
            {
                MessageBox.Show("请输入新的文件名！");
                return;
            }
            FileDetails fd = new FileDetails(list_fileList.Items[0].ToString());
            reName(fd.fullName, txt_order.Text, true);
            list_fileList.Items.Clear();
            list_fileList.Items.Add(fd.path + txt_order.Text + fd.type);
            MessageBox.Show("重命名完成！");
        }
        private void reName(string file,string newName,Boolean check)
        {
            FileDetails fd = new FileDetails(file);
            int res = FileHelper.moveFile(fd.fullName, newName);
            if (res == FileHelper.CMD_FAILE_NO_FOUND) MessageBox.Show("文件不存在，重命名失败！");
            else if(res==FileHelper.CMD_FAILE_IN_USE) MessageBox.Show("文件被占用，重命名失败！");
            else if(res==FileHelper.CMD_FILE_ALREADY_EXISTS) MessageBox.Show("已存在对应文件名的文件，无法重命名！");
        }
        private void btn_allReName_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            if (txt_order.Text.Length < 1)
            {
                MessageBox.Show("请输入序列名字！");
                return;
            }
            if (txt_orderStartNum.Text == "起始数字(默认为0)")
            {
                txt_orderStartNum.Text = "0";
            }
            int a = 0;
            if (!int.TryParse(txt_orderStartNum.Text,out a))
            {
                MessageBox.Show("起始序号只能为数字！");
                return;
            }
            int i=Convert.ToInt32(txt_orderStartNum.Text);
            string[] newFile=new string[list_fileList.Items.Count];
            int j = 0;
            foreach (string s in list_fileList.Items)
            {
                FileDetails fd = new FileDetails(s);
                if (File.Exists(fd.path + txt_order.Text + i.ToString() + fd.type))
                {
                    File.Move(s, fd.path + txt_order.Text + i.ToString()+"(1)" + fd.type);
                    newFile[j] = fd.path + txt_order.Text + i.ToString() + "(1)" + fd.type;
                }
                else
                {
                    File.Move(s, fd.path + txt_order.Text + i.ToString() + fd.type);
                    newFile[j] = fd.path + txt_order.Text + i.ToString() + fd.type;
                }
                i++;
                j++;
            }
            list_fileList.Items.Clear();
            foreach(string nf in newFile){
                list_fileList.Items.Add(nf);
            }
            MessageBox.Show("序列重命名完成！");
        }

        private void btn_addPrefix_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            int j = 0;
            string[] newFile = new string[list_fileList.Items.Count];
            foreach (string s in list_fileList.Items)
            {
                FileDetails fd = new FileDetails(s);
                reName(fd.fullName, fd.path+txt_char.Text + fd.name+fd.type, false);
                newFile[j] = fd.path + txt_char.Text + fd.name+fd.type;
                j++;
            }
            list_fileList.Items.Clear();
            foreach (string nf in newFile)
            {
                list_fileList.Items.Add(nf);
            }
            MessageBox.Show("添加前缀完成！");
        }

        private void btn_addSuffix_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            int j = 0;
            string[] newFile = new string[list_fileList.Items.Count];
            foreach (string s in list_fileList.Items)
            {
                FileDetails fd = new FileDetails(s);
                reName(fd.fullName, fd.path+fd.name + txt_char.Text + fd.type, false);
                newFile[j] = fd.path + fd.name + txt_char.Text + fd.type;
                j++;
            }
            list_fileList.Items.Clear();
            foreach (string nf in newFile)
            {
                list_fileList.Items.Add(nf);
            }
            MessageBox.Show("添加后缀完成！");
        }

        private void btn_tracepy_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            FontDict font = new FontDict();
            String data = "";
            foreach (string s in list_fileList.Items)
            {
                FileDetails fd = new FileDetails(s);
                data += ">-"+font.getPingyin(fd.name) + "->" + fd.name + "\r\n";
            }
            if (tw.IsDisposed) tw = new TxtWin();
            tw.showMsg(data);
            tw.Show();
        }
        private void btn_toPy_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            FontDict font = new FontDict();
            string[] newFile = new string[list_fileList.Items.Count];
            int j = 0;
            foreach (string s in list_fileList.Items)
            {
                FileDetails fd = new FileDetails(s);
                File.Move(fd.fullName, fd.path + font.getPingyin(fd.name)+fd.type);
                newFile[j] = fd.path + font.getPingyin(fd.name)+fd.type;
                j++;
            }
            list_fileList.Items.Clear();
            foreach (string nf in newFile)
            {
                list_fileList.Items.Add(nf);
            }
            MessageBox.Show("转换完成完成！");
        }
        private void btn_getList_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            String data = "";
            foreach (string s in list_fileList.Items)
            {
                data += s + "\r\n";
            }
            if (tw.IsDisposed) tw = new TxtWin();
            tw.showMsg(data);
            tw.Show();
        }
        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (list_fileList.Items.Count < 1)
            {
                MessageBox.Show("请先选择要操作的文件！");
                return;
            }
            if (txt_fileChar.Text.Length < 1)
            {
                MessageBox.Show("请填写要替换的内容！");
                return;
            }
            int j = 0;
            string[] newFile = new string[list_fileList.Items.Count];
            FileDetails fd;
            foreach (string s in list_fileList.Items)
            {
                fd = new FileDetails(s);
                string useChar = txt_useChar.Text.Length < 1 ? "" : txt_useChar.Text;
                reName(s, fd.path+fd.name.Replace(txt_fileChar.Text, useChar)+fd.type, false);
                newFile[j] = fd.path + fd.name.Replace(txt_fileChar.Text, useChar) + fd.type;
                j++;
            }
            list_fileList.Items.Clear();
            foreach (string nf in newFile)
            {
                list_fileList.Items.Add(nf);
            }
        }

        private void filePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                list_fileList.Items.Clear();
                filePath.Text = fb.SelectedPath;
                readFileList();
            }
        }

        private void list_fileList_DoubleClick(object sender, EventArgs e)
        {
            if (list_fileList.SelectedItem == null) return;
            list_fileList.Items.Add(list_fileList.SelectedItem);
            list_fileList.Items.Remove(list_fileList.SelectedItem);
        }

        private void list_fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_fileList.SelectedItem == null) return;
            //txt_select.Text = list_fileList.SelectedItem.ToString();
        }

        private void cb_contains_CheckedChanged(object sender, EventArgs e)
        {
            list_fileList.Items.Clear();
            readFileList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cb_contains, "选中后将会显示所选的目录及基子目录下的所有文件");
            toolTip1.SetToolTip(txt_containsText, "文件名中包含或不包含的文字");
            toolTip1.SetToolTip(btn_replace, "将选择列表中的所有文件的名字中包含的字符替换成自己需要的，\r\n如：aa天啊bb.rar，要替换的字符为 “天啊”，\r\n替换后的字符为“cc”，则执行替换后文件名为 aaccbb.rar");
            toolTip1.SetToolTip(btn_addSuffix, "将选择列表中的所有文件的名字的末尾加上一串文字，\r\n如：文件ww.rar,字符串填aaa，则选择的文件加完后都变成 wwaaa.rar");
            toolTip1.SetToolTip(btn_addPrefix, "将选择列表中的所有文件的名字前面加上一串文字，\r\n如：文件ww.rar,字符串填aaa，则选择的文件加完后都变成 aaaww.rar");
            toolTip1.SetToolTip(btn_allReName, "对选择列表中的所有文件按设置规则进行便命名，\r\n如：选择100张jpg图片，序列名为a，起始数字为0，\r\n则重命名后的文件名为（a0.jpg, a1.jpg, a2.jpg, a3.jpg ......）");
            toolTip1.SetToolTip(deleteFile, "删除选择列表中的所有文件");
            toolTip1.SetToolTip(btn_mobileFile, "将选择的文件移动到指定目录，点击选择目标目录并移动");
            toolTip1.SetToolTip(btn_reName, "重命名选择列表的文件，只能重命名一个文件，\r\n如果需要修改多个文件请使用批量重命名");
            toolTip1.SetToolTip(btn_refreshFileList, "刷新文件列表中的文件");
            toolTip1.SetToolTip(btn_filter, "过滤文件列表中的文件");
            if (File.Exists("url.txt"))
            {
                filePath.Text = File.ReadAllText("url.txt");
                readFileList();
            }
        }

        private void filePath_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = fb.SelectedPath;
                readFileList();
            }
        }

        private void cb_contains_CheckedChanged_1(object sender, EventArgs e)
        {
            readFileList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            tb_result.Text = "包含" + tb_key.Text + "的文件有：\r\n";
            string key = tb_key.Text;
            foreach (string s in list_fileList.Items)
            {
                if (checkFile(s))
                {
                    string c = File.ReadAllText(s, Encoding.GetEncoding(cb_encode.Text));
                    if (!cb_char.Checked)
                    {
                        key = key.ToLower();
                        c = c.ToLower();
                    }
                    if (c.IndexOf(key) != -1)
                    {
                        tb_result.Text += s+" 所在行："+getStrLine(c, key) + "\r\n";
                    }
                }
            }
        }
        private string getStrLine(string str, string key)
        {
            string res = "";
            int l = 1;
            if (str.IndexOf("\n") == -1) res = l.ToString();
            else {
                while (str.IndexOf("\n") != -1)
                {
                    string tmp = str.Substring(0, str.IndexOf("\n"));
                    str = str.Substring(str.IndexOf("\n") + 1);
                    if (tmp.IndexOf(key) != -1) res += l.ToString() + "  ";
                    l++;
                }
            }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            replace(tb_key.Text, tb_replace.Text);
        }

        private void btn_replaceOrder_Click(object sender, EventArgs e)
        {
            if (tb_ct.Text.Trim().Length < 1)
            {
                MessageBox.Show("替换源内容不能为空");
                return;
            }
            if (tb_rep.Text.Trim().Length < 1)
            {
                MessageBox.Show("替换内容不能为空！");
                return;
            }
            if (tb_rep.Text.IndexOf("$n$") == -1)
            {
                replace(tb_ct.Text, tb_rep.Text);
            }
            else
            {
                string str1 = tb_ct.Text;
                tb_result.Text = "下列文件已被替换：\r\n";
                foreach (string s in list_fileList.Items)
                {
                    if (checkFile(s))
                    {
                        string c = File.ReadAllText(s, Encoding.GetEncoding(cb_encode.Text));
                        if (!cb_char.Checked)
                        {
                            str1 = str1.ToLower();
                            c = c.ToLower();
                        }
                        if (c.IndexOf(str1) != -1)
                        {
                            string res = "";
                            int count = 0;
                            int n = Convert.ToInt32(tb_num.Text);
                            while (c.IndexOf(str1) != -1)
                            {
                                string nstr = tb_rep.Text.Replace("$n$", n.ToString());
                                c = c.Substring(0, c.IndexOf(str1)) + nstr + c.Substring(c.IndexOf(str1) + str1.Length);
                                res += c.Substring(0, c.IndexOf(nstr)+nstr.Length);
                                c = c.Substring(c.IndexOf(nstr) + nstr.Length);
                                n++;
                                count++;
                                //c.Replace(str1, tb_rep.Text.Replace("$n$",n.ToString()));
                            }
                            res += c;
                            File.WriteAllText(s, res, Encoding.GetEncoding(cb_encode.Text));
                            tb_result.Text += s +"  共替换"+count+ "个\r\n";
                        }
                    }
                }
            }
        }
        private Boolean checkFile(string f)
        {
            if (tb_type.Text.Length < 1) return true;
            string[] type = tb_type.Text.Split('|');
            foreach (string i in type)
            {
                if (f.IndexOf(i) != -1) return true;
            }
            return false;
        }
        private void replace(string str1, string str2)
        {
            tb_result.Text = "下列文件已被替换：\r\n";
            foreach (string s in list_fileList.Items)
            {
                if (checkFile(s))
                {
                    string c = File.ReadAllText(s, Encoding.GetEncoding(cb_encode.Text));
                    if (!cb_char.Checked)
                    {
                        str1 = str1.ToLower();
                        c = c.ToLower();
                    }
                    if (c.IndexOf(str1) != -1)
                    {
                        c = c.Replace(str1, str2);
                        File.WriteAllText(s, c, Encoding.GetEncoding(cb_encode.Text));
                        tb_result.Text += s + "\r\n";
                    }
                }
            }
        }

        private void tb_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void list_fileList_MouseHover(object sender, EventArgs e)
        {

        }

        private void list_fileList_MouseMove(object sender, MouseEventArgs e)
        {
            if (curOverItem == e.Y) return;
            else if (Math.Abs(curOverItem - e.Y) > 10) toolTip1.Hide(list_fileList);
            ListBox _ListBox = (ListBox)sender;
            for (int i = 0; i != list_fileList.Items.Count; i++)
            {
                Rectangle _Rect = list_fileList.GetItemRectangle(i);
                if (_Rect.Contains(e.X, e.Y))
                {
                    string path = list_fileList.Items[i].ToString();
                    if (path.Length < 50) return;
                    curOverItem = e.Y;
                    toolTip1.SetToolTip(list_fileList, path);
                }
            }
        }

        private void list_fileList_MouseLeave(object sender, EventArgs e)
        {
            if (qv != null && !qv.IsDisposed) qv.Hide();
        }

        private void list_fileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (list_fileList.SelectedItem==null) return;
            string url = list_fileList.SelectedItem.ToString();
            if (qv == null || qv.IsDisposed) qv = new QView();
            qv.showMsg(url);
            qv.Show();
            qv.Location = new Point(MousePosition.X + 10, MousePosition.Y);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(list_fileList.SelectedItem.ToString());
        }

        private void btn_openDirectory_Click(object sender, EventArgs e)
        {
            string path = list_fileList.SelectedItem.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            System.Diagnostics.Process.Start("explorer.exe", @path);
        }

        private void list_fileList_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileDetails fd = new FileDetails(path);
            filePath.Text = fd.path;
            readFileList();
        }

        private void list_fileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link; //重要代码：表明是链接类型的数据，比如文件路径
            else e.Effect = DragDropEffects.None;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (list_fileList.SelectedItem == null)
            { 
                MessageBox.Show("请选择要编辑的文件");
                return;
            }
            string url = list_fileList.SelectedItem.ToString();
            string data = File.ReadAllText(url);
            if (tw.IsDisposed) tw = new TxtWin();
            tw.showMsg(data);
            tw.Show();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (tb_content.Text.Trim().Length < 1) return;
            if (tb_l.Text.Trim().Length < 1) return;
            string[] arr = tb_content.Text.Split('\n');
            string res = "";
            foreach(string s in arr)
            {
                if (s.Length > tb_l.Text.Length) res += s.Substring(Convert.ToInt32(tb_l.Text));
                else res += s;
                res += "\n";
            }
            tb_content.Text = res;
        }

        private void btn_encryption_Click(object sender, EventArgs e)
        {
            tb_content.Text = DesTools.Encrypt(tb_content.Text, "#L@D&S$G");
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            tb_content.Text = DesTools.Decrypt(tb_content.Text, "#L@D&S$G");
        }
    }
}
