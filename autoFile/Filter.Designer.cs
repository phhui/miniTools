namespace ppqq
{
    partial class Filter
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
            this.filterCN = new System.Windows.Forms.Button();
            this.filterSpace = new System.Windows.Forms.Button();
            this.filterTab = new System.Windows.Forms.Button();
            this.getAtrr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(9, 10);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(583, 322);
            this.txt.TabIndex = 0;
            // 
            // filterCN
            // 
            this.filterCN.Location = new System.Drawing.Point(521, 334);
            this.filterCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterCN.Name = "filterCN";
            this.filterCN.Size = new System.Drawing.Size(70, 25);
            this.filterCN.TabIndex = 1;
            this.filterCN.Text = "过滤中文";
            this.filterCN.UseVisualStyleBackColor = true;
            this.filterCN.Click += new System.EventHandler(this.filterCN_Click);
            // 
            // filterSpace
            // 
            this.filterSpace.Location = new System.Drawing.Point(461, 334);
            this.filterSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterSpace.Name = "filterSpace";
            this.filterSpace.Size = new System.Drawing.Size(56, 25);
            this.filterSpace.TabIndex = 2;
            this.filterSpace.Text = "去空格";
            this.filterSpace.UseVisualStyleBackColor = true;
            this.filterSpace.Click += new System.EventHandler(this.filterSpace_Click);
            // 
            // filterTab
            // 
            this.filterTab.Location = new System.Drawing.Point(400, 334);
            this.filterTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTab.Name = "filterTab";
            this.filterTab.Size = new System.Drawing.Size(56, 25);
            this.filterTab.TabIndex = 3;
            this.filterTab.Text = "去TAB";
            this.filterTab.UseVisualStyleBackColor = true;
            this.filterTab.Click += new System.EventHandler(this.filterTab_Click);
            // 
            // getAtrr
            // 
            this.getAtrr.Location = new System.Drawing.Point(339, 334);
            this.getAtrr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getAtrr.Name = "getAtrr";
            this.getAtrr.Size = new System.Drawing.Size(56, 25);
            this.getAtrr.TabIndex = 4;
            this.getAtrr.Text = "提属性";
            this.getAtrr.UseVisualStyleBackColor = true;
            this.getAtrr.Click += new System.EventHandler(this.getAtrr_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.getAtrr);
            this.Controls.Add(this.filterTab);
            this.Controls.Add(this.filterSpace);
            this.Controls.Add(this.filterCN);
            this.Controls.Add(this.txt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button filterCN;
        private System.Windows.Forms.Button filterSpace;
        private System.Windows.Forms.Button filterTab;
        private System.Windows.Forms.Button getAtrr;
    }
}