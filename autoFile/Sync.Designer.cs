namespace ppqq
{
    partial class Sync
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sync = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "源路径:";
            // 
            // tb_source
            // 
            this.tb_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_source.Location = new System.Drawing.Point(83, 15);
            this.tb_source.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(453, 21);
            this.tb_source.TabIndex = 2;
            this.tb_source.Click += new System.EventHandler(this.tb_source_Click);
            this.tb_source.TextChanged += new System.EventHandler(this.tb_source_TextChanged);
            // 
            // tb_target
            // 
            this.tb_target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_target.Location = new System.Drawing.Point(83, 45);
            this.tb_target.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_target.Name = "tb_target";
            this.tb_target.Size = new System.Drawing.Size(453, 21);
            this.tb_target.TabIndex = 4;
            this.tb_target.Click += new System.EventHandler(this.tb_target_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标路径:";
            // 
            // btn_sync
            // 
            this.btn_sync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sync.Location = new System.Drawing.Point(540, 15);
            this.btn_sync.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(56, 78);
            this.btn_sync.TabIndex = 5;
            this.btn_sync.Text = "同  步";
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.btn_sync_Click);
            // 
            // tb_log
            // 
            this.tb_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_log.Location = new System.Drawing.Point(16, 98);
            this.tb_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(576, 254);
            this.tb_log.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "过滤:";
            // 
            // tb_filter
            // 
            this.tb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filter.Location = new System.Drawing.Point(83, 73);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(453, 21);
            this.tb_filter.TabIndex = 4;
            // 
            // Sync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_sync);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_target);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync";
            this.Load += new System.EventHandler(this.Sync_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sync;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_filter;
    }
}