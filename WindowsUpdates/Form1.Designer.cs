namespace WindowsUpdates
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_set_AUOptions = new System.Windows.Forms.Button();
            this.rdobtn_7 = new System.Windows.Forms.RadioButton();
            this.rdobtn_5 = new System.Windows.Forms.RadioButton();
            this.rdobtn_4 = new System.Windows.Forms.RadioButton();
            this.rdobtn_3 = new System.Windows.Forms.RadioButton();
            this.rdobtn_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_enable_disable = new System.Windows.Forms.Button();
            this.rdobtn_disable = new System.Windows.Forms.RadioButton();
            this.rdobtn_enable = new System.Windows.Forms.RadioButton();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.rdobtn_reset = new System.Windows.Forms.RadioButton();
            this.rdobtn_removed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(327, 476);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 39);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(202, 36);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(111, 59);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close Regedit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(36, 36);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(123, 59);
            this.btn_backup.TabIndex = 8;
            this.btn_backup.Text = "Backup Registry";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_reset);
            this.groupBox1.Controls.Add(this.btn_set_AUOptions);
            this.groupBox1.Controls.Add(this.rdobtn_7);
            this.groupBox1.Controls.Add(this.rdobtn_5);
            this.groupBox1.Controls.Add(this.rdobtn_4);
            this.groupBox1.Controls.Add(this.rdobtn_3);
            this.groupBox1.Controls.Add(this.rdobtn_2);
            this.groupBox1.Location = new System.Drawing.Point(35, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limit Auto Updates";
            // 
            // btn_set_AUOptions
            // 
            this.btn_set_AUOptions.Location = new System.Drawing.Point(301, 168);
            this.btn_set_AUOptions.Name = "btn_set_AUOptions";
            this.btn_set_AUOptions.Size = new System.Drawing.Size(64, 24);
            this.btn_set_AUOptions.TabIndex = 10;
            this.btn_set_AUOptions.Text = "Set";
            this.btn_set_AUOptions.UseVisualStyleBackColor = true;
            this.btn_set_AUOptions.Click += new System.EventHandler(this.btn_set_AUOptions_Click);
            // 
            // rdobtn_7
            // 
            this.rdobtn_7.AutoSize = true;
            this.rdobtn_7.Location = new System.Drawing.Point(14, 141);
            this.rdobtn_7.Name = "rdobtn_7";
            this.rdobtn_7.Size = new System.Drawing.Size(338, 21);
            this.rdobtn_7.TabIndex = 4;
            this.rdobtn_7.Text = "Auto Download, Notify to install, Notify to Restart.";
            this.rdobtn_7.UseVisualStyleBackColor = true;
            // 
            // rdobtn_5
            // 
            this.rdobtn_5.AutoSize = true;
            this.rdobtn_5.Location = new System.Drawing.Point(14, 114);
            this.rdobtn_5.Name = "rdobtn_5";
            this.rdobtn_5.Size = new System.Drawing.Size(259, 21);
            this.rdobtn_5.TabIndex = 3;
            this.rdobtn_5.Text = "Allow local admin to choose settings.";
            this.rdobtn_5.UseVisualStyleBackColor = true;
            // 
            // rdobtn_4
            // 
            this.rdobtn_4.AutoSize = true;
            this.rdobtn_4.Location = new System.Drawing.Point(14, 87);
            this.rdobtn_4.Name = "rdobtn_4";
            this.rdobtn_4.Size = new System.Drawing.Size(279, 21);
            this.rdobtn_4.TabIndex = 2;
            this.rdobtn_4.Text = "Auto download and schedule the install.";
            this.rdobtn_4.UseVisualStyleBackColor = true;
            // 
            // rdobtn_3
            // 
            this.rdobtn_3.AutoSize = true;
            this.rdobtn_3.Location = new System.Drawing.Point(14, 60);
            this.rdobtn_3.Name = "rdobtn_3";
            this.rdobtn_3.Size = new System.Drawing.Size(253, 21);
            this.rdobtn_3.TabIndex = 1;
            this.rdobtn_3.Text = "Auto download and notify for install.";
            this.rdobtn_3.UseVisualStyleBackColor = true;
            // 
            // rdobtn_2
            // 
            this.rdobtn_2.AutoSize = true;
            this.rdobtn_2.Checked = true;
            this.rdobtn_2.Location = new System.Drawing.Point(14, 33);
            this.rdobtn_2.Name = "rdobtn_2";
            this.rdobtn_2.Size = new System.Drawing.Size(254, 21);
            this.rdobtn_2.TabIndex = 0;
            this.rdobtn_2.TabStop = true;
            this.rdobtn_2.Text = "Notify for download and auto install.";
            this.rdobtn_2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_backup);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Location = new System.Drawing.Point(35, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Registry";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdobtn_removed);
            this.groupBox3.Controls.Add(this.btn_enable_disable);
            this.groupBox3.Controls.Add(this.rdobtn_disable);
            this.groupBox3.Controls.Add(this.rdobtn_enable);
            this.groupBox3.Location = new System.Drawing.Point(35, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 106);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enable Disable Updates";
            // 
            // btn_enable_disable
            // 
            this.btn_enable_disable.Location = new System.Drawing.Point(301, 76);
            this.btn_enable_disable.Name = "btn_enable_disable";
            this.btn_enable_disable.Size = new System.Drawing.Size(64, 24);
            this.btn_enable_disable.TabIndex = 11;
            this.btn_enable_disable.Text = "Set";
            this.btn_enable_disable.UseVisualStyleBackColor = true;
            this.btn_enable_disable.Click += new System.EventHandler(this.btn_enable_disable_Click);
            // 
            // rdobtn_disable
            // 
            this.rdobtn_disable.AutoSize = true;
            this.rdobtn_disable.Checked = true;
            this.rdobtn_disable.Location = new System.Drawing.Point(116, 47);
            this.rdobtn_disable.Name = "rdobtn_disable";
            this.rdobtn_disable.Size = new System.Drawing.Size(76, 21);
            this.rdobtn_disable.TabIndex = 1;
            this.rdobtn_disable.TabStop = true;
            this.rdobtn_disable.Text = "Disable";
            this.rdobtn_disable.UseVisualStyleBackColor = true;
            // 
            // rdobtn_enable
            // 
            this.rdobtn_enable.AutoSize = true;
            this.rdobtn_enable.Location = new System.Drawing.Point(27, 47);
            this.rdobtn_enable.Name = "rdobtn_enable";
            this.rdobtn_enable.Size = new System.Drawing.Size(73, 21);
            this.rdobtn_enable.TabIndex = 0;
            this.rdobtn_enable.Text = "Enable";
            this.rdobtn_enable.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(35, 476);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(81, 39);
            this.btn_help.TabIndex = 12;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(148, 487);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(28, 17);
            this.lbl_version.TabIndex = 13;
            this.lbl_version.Text = ".....";
            // 
            // rdobtn_reset
            // 
            this.rdobtn_reset.AutoSize = true;
            this.rdobtn_reset.Location = new System.Drawing.Point(14, 168);
            this.rdobtn_reset.Name = "rdobtn_reset";
            this.rdobtn_reset.Size = new System.Drawing.Size(138, 21);
            this.rdobtn_reset.TabIndex = 11;
            this.rdobtn_reset.Text = "Remove to Reset";
            this.rdobtn_reset.UseVisualStyleBackColor = true;
            // 
            // rdobtn_removed
            // 
            this.rdobtn_removed.AutoSize = true;
            this.rdobtn_removed.Checked = true;
            this.rdobtn_removed.Location = new System.Drawing.Point(210, 47);
            this.rdobtn_removed.Name = "rdobtn_removed";
            this.rdobtn_removed.Size = new System.Drawing.Size(138, 21);
            this.rdobtn_removed.TabIndex = 12;
            this.rdobtn_removed.TabStop = true;
            this.rdobtn_removed.Text = "Remove to Reset";
            this.rdobtn_removed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 527);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(449, 574);
            this.Name = "Form1";
            this.Text = "Windows Updates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtn_7;
        private System.Windows.Forms.RadioButton rdobtn_5;
        private System.Windows.Forms.RadioButton rdobtn_4;
        private System.Windows.Forms.RadioButton rdobtn_3;
        private System.Windows.Forms.RadioButton rdobtn_2;
        private System.Windows.Forms.Button btn_set_AUOptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdobtn_disable;
        private System.Windows.Forms.RadioButton rdobtn_enable;
        private System.Windows.Forms.Button btn_enable_disable;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.RadioButton rdobtn_reset;
        private System.Windows.Forms.RadioButton rdobtn_removed;
    }
}

