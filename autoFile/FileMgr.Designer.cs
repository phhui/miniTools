namespace ppqq
{
    partial class FileMgr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMgr));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_contains = new System.Windows.Forms.CheckBox();
            this.btn_refreshFileList = new System.Windows.Forms.Button();
            this.list_fileList = new System.Windows.Forms.ListBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.txt_containsText = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_openDirectory = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_order = new System.Windows.Forms.TextBox();
            this.btn_toPy = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.txt_useChar = new System.Windows.Forms.TextBox();
            this.txt_fileChar = new System.Windows.Forms.TextBox();
            this.txt_orderStartNum = new System.Windows.Forms.TextBox();
            this.btn_allReName = new System.Windows.Forms.Button();
            this.txt_char = new System.Windows.Forms.TextBox();
            this.btn_addSuffix = new System.Windows.Forms.Button();
            this.btn_addPrefix = new System.Windows.Forms.Button();
            this.btn_reName = new System.Windows.Forms.Button();
            this.btn_mobileFile = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.btn_replaceOrder = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ct = new System.Windows.Forms.TextBox();
            this.cb_encode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_char = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_l = new System.Windows.Forms.TextBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_encryption = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cb_contains);
            this.splitContainer1.Panel1.Controls.Add(this.btn_refreshFileList);
            this.splitContainer1.Panel1.Controls.Add(this.list_fileList);
            this.splitContainer1.Panel1.Controls.Add(this.filePath);
            this.splitContainer1.Panel1.Controls.Add(this.txt_containsText);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_filter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabcontrol);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 44;
            // 
            // cb_contains
            // 
            this.cb_contains.AutoSize = true;
            this.cb_contains.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_contains.Location = new System.Drawing.Point(1, 26);
            this.cb_contains.Name = "cb_contains";
            this.cb_contains.Size = new System.Drawing.Size(84, 16);
            this.cb_contains.TabIndex = 39;
            this.cb_contains.Text = "包含子目录";
            this.cb_contains.UseVisualStyleBackColor = true;
            this.cb_contains.CheckedChanged += new System.EventHandler(this.cb_contains_CheckedChanged);
            // 
            // btn_refreshFileList
            // 
            this.btn_refreshFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshFileList.Location = new System.Drawing.Point(217, 24);
            this.btn_refreshFileList.Name = "btn_refreshFileList";
            this.btn_refreshFileList.Size = new System.Drawing.Size(41, 23);
            this.btn_refreshFileList.TabIndex = 37;
            this.btn_refreshFileList.Text = "刷新";
            this.btn_refreshFileList.UseVisualStyleBackColor = true;
            this.btn_refreshFileList.Click += new System.EventHandler(this.btn_refreshFileList_Click);
            // 
            // list_fileList
            // 
            this.list_fileList.AllowDrop = true;
            this.list_fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_fileList.FormattingEnabled = true;
            this.list_fileList.ItemHeight = 12;
            this.list_fileList.Location = new System.Drawing.Point(3, 46);
            this.list_fileList.Name = "list_fileList";
            this.list_fileList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_fileList.Size = new System.Drawing.Size(255, 484);
            this.list_fileList.TabIndex = 35;
            this.list_fileList.SelectedIndexChanged += new System.EventHandler(this.list_fileList_SelectedIndexChanged_1);
            this.list_fileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_fileList_DragDrop);
            this.list_fileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_fileList_DragEnter);
            this.list_fileList.DoubleClick += new System.EventHandler(this.fileList_DoubleClick);
            this.list_fileList.MouseLeave += new System.EventHandler(this.list_fileList_MouseLeave);
            this.list_fileList.MouseHover += new System.EventHandler(this.list_fileList_MouseHover);
            this.list_fileList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.list_fileList_MouseMove);
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(3, 3);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(255, 21);
            this.filePath.TabIndex = 33;
            this.filePath.Text = "点击选择目录";
            this.filePath.Click += new System.EventHandler(this.filePath_Click);
            // 
            // txt_containsText
            // 
            this.txt_containsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_containsText.Location = new System.Drawing.Point(55, 535);
            this.txt_containsText.Name = "txt_containsText";
            this.txt_containsText.Size = new System.Drawing.Size(155, 21);
            this.txt_containsText.TabIndex = 47;
            this.txt_containsText.Text = "过滤的字符串,逗号隔开";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 538);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "包含";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            this.btn_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_filter.Location = new System.Drawing.Point(217, 534);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(42, 23);
            this.btn_filter.TabIndex = 48;
            this.btn_filter.Text = "过滤";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage4);
            this.tabcontrol.Controls.Add(this.tabPage5);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Location = new System.Drawing.Point(-1, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(520, 558);
            this.tabcontrol.TabIndex = 67;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_edit);
            this.tabPage1.Controls.Add(this.btn_openDirectory);
            this.tabPage1.Controls.Add(this.btn_open);
            this.tabPage1.Controls.Add(this.txt_order);
            this.tabPage1.Controls.Add(this.btn_toPy);
            this.tabPage1.Controls.Add(this.btn_replace);
            this.tabPage1.Controls.Add(this.txt_useChar);
            this.tabPage1.Controls.Add(this.txt_fileChar);
            this.tabPage1.Controls.Add(this.txt_orderStartNum);
            this.tabPage1.Controls.Add(this.btn_allReName);
            this.tabPage1.Controls.Add(this.txt_char);
            this.tabPage1.Controls.Add(this.btn_addSuffix);
            this.tabPage1.Controls.Add(this.btn_addPrefix);
            this.tabPage1.Controls.Add(this.btn_reName);
            this.tabPage1.Controls.Add(this.btn_mobileFile);
            this.tabPage1.Controls.Add(this.deleteFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件编辑";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(366, 90);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(41, 23);
            this.btn_edit.TabIndex = 82;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_openDirectory
            // 
            this.btn_openDirectory.Location = new System.Drawing.Point(284, 91);
            this.btn_openDirectory.Name = "btn_openDirectory";
            this.btn_openDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_openDirectory.TabIndex = 81;
            this.btn_openDirectory.Text = "打开目录";
            this.btn_openDirectory.UseVisualStyleBackColor = true;
            this.btn_openDirectory.Click += new System.EventHandler(this.btn_openDirectory_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(202, 91);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 80;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_order
            // 
            this.txt_order.Location = new System.Drawing.Point(9, 7);
            this.txt_order.Name = "txt_order";
            this.txt_order.Size = new System.Drawing.Size(106, 21);
            this.txt_order.TabIndex = 79;
            this.txt_order.Text = "序列名";
            // 
            // btn_toPy
            // 
            this.btn_toPy.Location = new System.Drawing.Point(121, 91);
            this.btn_toPy.Name = "btn_toPy";
            this.btn_toPy.Size = new System.Drawing.Size(74, 23);
            this.btn_toPy.TabIndex = 78;
            this.btn_toPy.Text = "中文转拼音";
            this.btn_toPy.UseVisualStyleBackColor = true;
            this.btn_toPy.Click += new System.EventHandler(this.btn_toPy_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(237, 61);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(74, 23);
            this.btn_replace.TabIndex = 77;
            this.btn_replace.Text = "替 换";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // txt_useChar
            // 
            this.txt_useChar.Location = new System.Drawing.Point(121, 63);
            this.txt_useChar.Name = "txt_useChar";
            this.txt_useChar.Size = new System.Drawing.Size(109, 21);
            this.txt_useChar.TabIndex = 76;
            this.txt_useChar.Text = "替换后的字符";
            // 
            // txt_fileChar
            // 
            this.txt_fileChar.Location = new System.Drawing.Point(8, 63);
            this.txt_fileChar.Name = "txt_fileChar";
            this.txt_fileChar.Size = new System.Drawing.Size(106, 21);
            this.txt_fileChar.TabIndex = 75;
            this.txt_fileChar.Text = "文件名中的字符";
            // 
            // txt_orderStartNum
            // 
            this.txt_orderStartNum.Location = new System.Drawing.Point(121, 8);
            this.txt_orderStartNum.Name = "txt_orderStartNum";
            this.txt_orderStartNum.Size = new System.Drawing.Size(109, 21);
            this.txt_orderStartNum.TabIndex = 74;
            this.txt_orderStartNum.Text = "起始数字(默认为0)";
            // 
            // btn_allReName
            // 
            this.btn_allReName.Location = new System.Drawing.Point(297, 5);
            this.btn_allReName.Name = "btn_allReName";
            this.btn_allReName.Size = new System.Drawing.Size(74, 23);
            this.btn_allReName.TabIndex = 73;
            this.btn_allReName.Text = "序列重命名";
            this.btn_allReName.UseVisualStyleBackColor = true;
            this.btn_allReName.Click += new System.EventHandler(this.btn_allReName_Click);
            // 
            // txt_char
            // 
            this.txt_char.Location = new System.Drawing.Point(8, 35);
            this.txt_char.Name = "txt_char";
            this.txt_char.Size = new System.Drawing.Size(106, 21);
            this.txt_char.TabIndex = 72;
            this.txt_char.Text = "字符串";
            // 
            // btn_addSuffix
            // 
            this.btn_addSuffix.Location = new System.Drawing.Point(180, 35);
            this.btn_addSuffix.Name = "btn_addSuffix";
            this.btn_addSuffix.Size = new System.Drawing.Size(50, 23);
            this.btn_addSuffix.TabIndex = 71;
            this.btn_addSuffix.Text = "加后缀";
            this.btn_addSuffix.UseVisualStyleBackColor = true;
            this.btn_addSuffix.Click += new System.EventHandler(this.btn_addSuffix_Click);
            // 
            // btn_addPrefix
            // 
            this.btn_addPrefix.Location = new System.Drawing.Point(121, 35);
            this.btn_addPrefix.Name = "btn_addPrefix";
            this.btn_addPrefix.Size = new System.Drawing.Size(53, 23);
            this.btn_addPrefix.TabIndex = 70;
            this.btn_addPrefix.Text = "加前缀";
            this.btn_addPrefix.UseVisualStyleBackColor = true;
            this.btn_addPrefix.Click += new System.EventHandler(this.btn_addPrefix_Click);
            // 
            // btn_reName
            // 
            this.btn_reName.Location = new System.Drawing.Point(235, 6);
            this.btn_reName.Name = "btn_reName";
            this.btn_reName.Size = new System.Drawing.Size(56, 23);
            this.btn_reName.TabIndex = 69;
            this.btn_reName.Text = "重命名";
            this.btn_reName.UseVisualStyleBackColor = true;
            this.btn_reName.Click += new System.EventHandler(this.btn_reName_Click);
            // 
            // btn_mobileFile
            // 
            this.btn_mobileFile.Location = new System.Drawing.Point(7, 90);
            this.btn_mobileFile.Name = "btn_mobileFile";
            this.btn_mobileFile.Size = new System.Drawing.Size(53, 23);
            this.btn_mobileFile.TabIndex = 68;
            this.btn_mobileFile.Text = "移动";
            this.btn_mobileFile.UseVisualStyleBackColor = true;
            this.btn_mobileFile.Click += new System.EventHandler(this.btn_mobileFile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(63, 91);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(53, 23);
            this.deleteFile.TabIndex = 67;
            this.deleteFile.Text = "删除";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_key);
            this.tabPage2.Controls.Add(this.btn_replaceOrder);
            this.tabPage2.Controls.Add(this.tb_num);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_rep);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_ct);
            this.tabPage2.Controls.Add(this.cb_encode);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cb_char);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tb_replace);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_type);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb_result);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 532);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "内容编辑";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(130, 25);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(89, 21);
            this.tb_key.TabIndex = 39;
            // 
            // btn_replaceOrder
            // 
            this.btn_replaceOrder.Location = new System.Drawing.Point(359, 47);
            this.btn_replaceOrder.Name = "btn_replaceOrder";
            this.btn_replaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_replaceOrder.TabIndex = 38;
            this.btn_replaceOrder.Text = "序列替换";
            this.btn_replaceOrder.UseVisualStyleBackColor = true;
            this.btn_replaceOrder.Click += new System.EventHandler(this.btn_replaceOrder_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(300, 48);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(53, 21);
            this.tb_num.TabIndex = 37;
            this.tb_num.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "起始值";
            // 
            // tb_rep
            // 
            this.tb_rep.Location = new System.Drawing.Point(148, 48);
            this.tb_rep.Name = "tb_rep";
            this.tb_rep.Size = new System.Drawing.Size(100, 21);
            this.tb_rep.TabIndex = 35;
            this.tb_rep.Text = "str$n$str";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "替换成";
            // 
            // tb_ct
            // 
            this.tb_ct.Location = new System.Drawing.Point(2, 48);
            this.tb_ct.Name = "tb_ct";
            this.tb_ct.Size = new System.Drawing.Size(100, 21);
            this.tb_ct.TabIndex = 33;
            // 
            // cb_encode
            // 
            this.cb_encode.FormattingEnabled = true;
            this.cb_encode.Items.AddRange(new object[] {
            "gb2312",
            "UTF-8"});
            this.cb_encode.Location = new System.Drawing.Point(422, 2);
            this.cb_encode.Name = "cb_encode";
            this.cb_encode.Size = new System.Drawing.Size(80, 20);
            this.cb_encode.TabIndex = 32;
            this.cb_encode.Text = "gb2312";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "编码：";
            // 
            // cb_char
            // 
            this.cb_char.AutoSize = true;
            this.cb_char.Location = new System.Drawing.Point(2, 28);
            this.cb_char.Name = "cb_char";
            this.cb_char.Size = new System.Drawing.Size(84, 16);
            this.cb_char.TabIndex = 30;
            this.cb_char.Text = "区分大小写";
            this.cb_char.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "替  换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_replace
            // 
            this.tb_replace.Location = new System.Drawing.Point(306, 26);
            this.tb_replace.Name = "tb_replace";
            this.tb_replace.Size = new System.Drawing.Size(87, 21);
            this.tb_replace.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "内容：";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(59, 3);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(325, 21);
            this.tb_type.TabIndex = 26;
            this.tb_type.Text = ".txt|.xml|.as|.cs|.js|.html";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "文件类型:";
            // 
            // tb_result
            // 
            this.tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_result.Location = new System.Drawing.Point(3, 72);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_result.Size = new System.Drawing.Size(503, 463);
            this.tb_result.TabIndex = 23;
            this.tb_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_result_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(225, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "查  找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(512, 532);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "目录编辑";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(512, 532);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "其它功能";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "输出拼音";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_tracepy_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 66;
            this.button3.Text = "获取列表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_getList_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_encryption);
            this.tabPage3.Controls.Add(this.btn_Decrypt);
            this.tabPage3.Controls.Add(this.tb_l);
            this.tabPage3.Controls.Add(this.btn_sub);
            this.tabPage3.Controls.Add(this.tb_content);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(512, 532);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "文本编辑";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_l
            // 
            this.tb_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_l.Location = new System.Drawing.Point(123, 509);
            this.tb_l.Name = "tb_l";
            this.tb_l.Size = new System.Drawing.Size(34, 21);
            this.tb_l.TabIndex = 26;
            this.tb_l.Text = "2";
            // 
            // btn_sub
            // 
            this.btn_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sub.Location = new System.Drawing.Point(3, 508);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(113, 23);
            this.btn_sub.TabIndex = 25;
            this.btn_sub.Text = "截取每行前N个字符";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // tb_content
            // 
            this.tb_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_content.Location = new System.Drawing.Point(5, 35);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_content.Size = new System.Drawing.Size(503, 473);
            this.tb_content.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "文件：";
            // 
            // btn_encryption
            // 
            this.btn_encryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_encryption.Location = new System.Drawing.Point(354, 509);
            this.btn_encryption.Name = "btn_encryption";
            this.btn_encryption.Size = new System.Drawing.Size(75, 23);
            this.btn_encryption.TabIndex = 28;
            this.btn_encryption.Text = "加  密";
            this.btn_encryption.UseVisualStyleBackColor = true;
            this.btn_encryption.Click += new System.EventHandler(this.btn_encryption_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Decrypt.Location = new System.Drawing.Point(434, 509);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 27;
            this.btn_Decrypt.Text = "解  密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理辅助工具 by phhui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cb_contains;
        private System.Windows.Forms.Button btn_refreshFileList;
        private System.Windows.Forms.ListBox list_fileList;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox txt_containsText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_order;
        private System.Windows.Forms.Button btn_toPy;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.TextBox txt_useChar;
        private System.Windows.Forms.TextBox txt_fileChar;
        private System.Windows.Forms.TextBox txt_orderStartNum;
        private System.Windows.Forms.Button btn_allReName;
        private System.Windows.Forms.TextBox txt_char;
        private System.Windows.Forms.Button btn_addSuffix;
        private System.Windows.Forms.Button btn_addPrefix;
        private System.Windows.Forms.Button btn_reName;
        private System.Windows.Forms.Button btn_mobileFile;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button btn_replaceOrder;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ct;
        private System.Windows.Forms.ComboBox cb_encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_char;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_replace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_openDirectory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_l;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_encryption;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

