namespace ppqq
{
    partial class GetFileList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(583, 318);
            this.textBox1.TabIndex = 0;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(52, 9);
            this.tb_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(262, 21);
            this.tb_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "路径：";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(536, 10);
            this.btn_get.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(59, 18);
            this.btn_get.TabIndex = 3;
            this.btn_get.Text = "获取列表";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(361, 9);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(171, 21);
            this.tb_filter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "过滤：";
            // 
            // GetFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetFileList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetFileList";
            this.Load += new System.EventHandler(this.GetFileList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Label label2;
    }
}