namespace ppqq
{
    partial class H5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H5));
            this.btn_saveConfig = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.tmp = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_saveConfig
            // 
            this.btn_saveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_saveConfig.Location = new System.Drawing.Point(128, 415);
            this.btn_saveConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_saveConfig.Name = "btn_saveConfig";
            this.btn_saveConfig.Size = new System.Drawing.Size(56, 18);
            this.btn_saveConfig.TabIndex = 20;
            this.btn_saveConfig.Text = "Save";
            this.btn_saveConfig.UseVisualStyleBackColor = true;
            this.btn_saveConfig.Visible = false;
            this.btn_saveConfig.Click += new System.EventHandler(this.Btn_saveConfig_Click);
            // 
            // btn_config
            // 
            this.btn_config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_config.Location = new System.Drawing.Point(71, 415);
            this.btn_config.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(52, 18);
            this.btn_config.TabIndex = 19;
            this.btn_config.Text = "Config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.Btn_config_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.Location = new System.Drawing.Point(10, 415);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 18);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(521, 415);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(56, 18);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "模块名称:";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Location = new System.Drawing.Point(378, 414);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(86, 21);
            this.tb_name.TabIndex = 14;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.Location = new System.Drawing.Point(465, 415);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(56, 18);
            this.btn_create.TabIndex = 13;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // tmp
            // 
            this.tmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmp.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tmp.Location = new System.Drawing.Point(9, 7);
            this.tmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tmp.Multiline = true;
            this.tmp.Name = "tmp";
            this.tmp.ReadOnly = true;
            this.tmp.Size = new System.Drawing.Size(570, 100);
            this.tmp.TabIndex = 18;
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(9, 111);
            this.log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(570, 299);
            this.log.TabIndex = 12;
            // 
            // H5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 442);
            this.Controls.Add(this.btn_saveConfig);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tmp);
            this.Controls.Add(this.log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "H5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H5";
            this.Load += new System.EventHandler(this.H5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveConfig;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox tmp;
        private System.Windows.Forms.TextBox log;
    }
}