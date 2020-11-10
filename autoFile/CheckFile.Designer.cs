namespace ppqq
{
    partial class CheckFile
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
            this.txt = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(9, 10);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(583, 154);
            this.txt.TabIndex = 0;
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.Location = new System.Drawing.Point(535, 326);
            this.btn_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(56, 26);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "检 测";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(9, 168);
            this.txt_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(583, 154);
            this.txt_output.TabIndex = 0;
            // 
            // CheckFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFile";
            this.Load += new System.EventHandler(this.CheckFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_output;
    }
}