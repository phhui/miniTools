namespace ppqq
{
    partial class autoSkinObj
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListBox();
            this.log = new System.Windows.Forms.TextBox();
            this.btnRefeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 12;
            this.list.Location = new System.Drawing.Point(1, 28);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(255, 328);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(262, 4);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(319, 352);
            this.log.TabIndex = 1;
            // 
            // btnRefeach
            // 
            this.btnRefeach.Location = new System.Drawing.Point(192, 4);
            this.btnRefeach.Name = "btnRefeach";
            this.btnRefeach.Size = new System.Drawing.Size(64, 23);
            this.btnRefeach.TabIndex = 3;
            this.btnRefeach.Text = "刷新列表";
            this.btnRefeach.UseVisualStyleBackColor = true;
            this.btnRefeach.Click += new System.EventHandler(this.btnRefeach_Click);
            // 
            // autoSkinObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnRefeach);
            this.Controls.Add(this.log);
            this.Controls.Add(this.list);
            this.Name = "autoSkinObj";
            this.Text = "getSkinId";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button btnRefeach;
    }
}

