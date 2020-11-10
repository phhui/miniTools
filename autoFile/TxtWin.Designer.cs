namespace ppqq
{
    partial class TxtWin
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
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.tb_str0 = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.tb_str1 = new System.Windows.Forms.TextBox();
            this.btn_conversion = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_in = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            this.txt_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_msg.Location = new System.Drawing.Point(12, 12);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msg.Size = new System.Drawing.Size(560, 301);
            this.txt_msg.TabIndex = 0;
            this.txt_msg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_msg_KeyUp);
            // 
            // tb_str0
            // 
            this.tb_str0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_str0.Location = new System.Drawing.Point(12, 319);
            this.tb_str0.Name = "tb_str0";
            this.tb_str0.Size = new System.Drawing.Size(100, 21);
            this.tb_str0.TabIndex = 1;
            // 
            // btn_replace
            // 
            this.btn_replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_replace.Location = new System.Drawing.Point(119, 319);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(59, 23);
            this.btn_replace.TabIndex = 2;
            this.btn_replace.Text = "替换为";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // tb_str1
            // 
            this.tb_str1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_str1.Location = new System.Drawing.Point(183, 319);
            this.tb_str1.Name = "tb_str1";
            this.tb_str1.Size = new System.Drawing.Size(100, 21);
            this.tb_str1.TabIndex = 3;
            // 
            // btn_conversion
            // 
            this.btn_conversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_conversion.Location = new System.Drawing.Point(487, 339);
            this.btn_conversion.Name = "btn_conversion";
            this.btn_conversion.Size = new System.Drawing.Size(85, 23);
            this.btn_conversion.TabIndex = 4;
            this.btn_conversion.Text = "中文->拼音";
            this.btn_conversion.UseVisualStyleBackColor = true;
            this.btn_conversion.Click += new System.EventHandler(this.btn_conversion_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_filter.Location = new System.Drawing.Point(83, 343);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(155, 21);
            this.tb_filter.TabIndex = 50;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove.Location = new System.Drawing.Point(245, 342);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(38, 23);
            this.btn_remove.TabIndex = 51;
            this.btn_remove.Text = "移除";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "行：";
            // 
            // cb_in
            // 
            this.cb_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_in.AutoSize = true;
            this.cb_in.Location = new System.Drawing.Point(31, 345);
            this.cb_in.Name = "cb_in";
            this.cb_in.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_in.Size = new System.Drawing.Size(48, 16);
            this.cb_in.TabIndex = 53;
            this.cb_in.Text = "包含";
            this.cb_in.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(289, 342);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(40, 23);
            this.btn_reset.TabIndex = 54;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // TxtWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cb_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_conversion);
            this.Controls.Add(this.tb_str1);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.tb_str0);
            this.Controls.Add(this.txt_msg);
            this.Name = "TxtWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TxtWin";
            this.Load += new System.EventHandler(this.TxtWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox tb_str0;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.TextBox tb_str1;
        private System.Windows.Forms.Button btn_conversion;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_in;
        private System.Windows.Forms.Button btn_reset;
    }
}