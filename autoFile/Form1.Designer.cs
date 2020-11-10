namespace ppqq
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFileMgr = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.btnCheckRes = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnUnpackSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileMgr
            // 
            this.btnFileMgr.Location = new System.Drawing.Point(12, 11);
            this.btnFileMgr.Name = "btnFileMgr";
            this.btnFileMgr.Size = new System.Drawing.Size(75, 23);
            this.btnFileMgr.TabIndex = 0;
            this.btnFileMgr.Text = "文件管理";
            this.btnFileMgr.UseVisualStyleBackColor = true;
            this.btnFileMgr.Click += new System.EventHandler(this.btnFileMgr_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(94, 11);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "一键同步";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnCreateModule
            // 
            this.btnCreateModule.Location = new System.Drawing.Point(176, 11);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(85, 23);
            this.btnCreateModule.TabIndex = 2;
            this.btnCreateModule.Text = "一键创建模块";
            this.btnCreateModule.UseVisualStyleBackColor = true;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // btnCheckRes
            // 
            this.btnCheckRes.Location = new System.Drawing.Point(267, 12);
            this.btnCheckRes.Name = "btnCheckRes";
            this.btnCheckRes.Size = new System.Drawing.Size(75, 23);
            this.btnCheckRes.TabIndex = 3;
            this.btnCheckRes.Text = "检测资源";
            this.btnCheckRes.UseVisualStyleBackColor = true;
            this.btnCheckRes.Click += new System.EventHandler(this.btnCheckRes_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(348, 12);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(75, 23);
            this.btnChar.TabIndex = 4;
            this.btnChar.Text = "文本处理";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnUnpackSheet
            // 
            this.btnUnpackSheet.Location = new System.Drawing.Point(429, 12);
            this.btnUnpackSheet.Name = "btnUnpackSheet";
            this.btnUnpackSheet.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackSheet.TabIndex = 5;
            this.btnUnpackSheet.Text = "纹理提取";
            this.btnUnpackSheet.UseVisualStyleBackColor = true;
            this.btnUnpackSheet.Click += new System.EventHandler(this.btnUnpackSheet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 442);
            this.Controls.Add(this.btnUnpackSheet);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnCheckRes);
            this.Controls.Add(this.btnCreateModule);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnFileMgr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "飞叔工具包";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileMgr;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnCreateModule;
        private System.Windows.Forms.Button btnCheckRes;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnUnpackSheet;
    }
}

