namespace ppqq
{
    partial class UnpackSheet
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
            this.btn_split = new System.Windows.Forms.Button();
            this.tb_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_split
            // 
            this.btn_split.Location = new System.Drawing.Point(535, 332);
            this.btn_split.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_split.Name = "btn_split";
            this.btn_split.Size = new System.Drawing.Size(56, 27);
            this.btn_split.TabIndex = 3;
            this.btn_split.Text = "切  图";
            this.btn_split.UseVisualStyleBackColor = true;
            this.btn_split.Click += new System.EventHandler(this.btn_split_Click);
            // 
            // tb_list
            // 
            this.tb_list.Location = new System.Drawing.Point(9, 10);
            this.tb_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_list.Multiline = true;
            this.tb_list.Name = "tb_list";
            this.tb_list.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_list.Size = new System.Drawing.Size(583, 318);
            this.tb_list.TabIndex = 2;
            // 
            // UnpackSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_split);
            this.Controls.Add(this.tb_list);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UnpackSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnpackSheet";
            this.Load += new System.EventHandler(this.UnpackSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_split;
        private System.Windows.Forms.TextBox tb_list;
    }
}