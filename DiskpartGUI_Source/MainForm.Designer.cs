namespace DiskpartGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbDisks = new ComboBox();
            rbGpt = new RadioButton();
            rbMbr = new RadioButton();
            chkRecovery = new CheckBox();
            numBootSize = new NumericUpDown();
            btnFormat = new Button();
            txtOutput = new RichTextBox();
            lblDisks = new Label();
            numWindowsSize = new NumericUpDown();
            cmbLang = new ComboBox();
            lblLang = new Label();
            lblRecoverySize = new Label();
            numRecoverySize = new NumericUpDown();
            pnlFooter = new Panel();
            lnkGithub = new LinkLabel();
            lnkAbout = new LinkLabel();
            lnkWebsite = new LinkLabel();
            lblBootSize = new Label();
            btnCreateVhd = new Button();
            btnRefresh = new Button();
            lblWindowsSize = new Label();
            lblDataSize = new Label();
            lblVhdSize = new Label();
            numVhdSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numBootSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWindowsSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoverySize).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVhdSize).BeginInit();
            SuspendLayout();
            // 
            // cmbDisks
            // 
            cmbDisks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisks.FormattingEnabled = true;
            cmbDisks.Location = new Point(12, 32);
            cmbDisks.Name = "cmbDisks";
            cmbDisks.Size = new Size(400, 23);
            cmbDisks.TabIndex = 0;
            cmbDisks.SelectedIndexChanged += cmbDisks_SelectedIndexChanged;
            // 
            // rbGpt
            // 
            rbGpt.AutoSize = true;
            rbGpt.Checked = true;
            rbGpt.Location = new Point(12, 61);
            rbGpt.Name = "rbGpt";
            rbGpt.Size = new Size(67, 19);
            rbGpt.TabIndex = 1;
            rbGpt.TabStop = true;
            rbGpt.Text = "GPT/EFI";
            rbGpt.UseVisualStyleBackColor = true;
            // 
            // rbMbr
            // 
            rbMbr.AutoSize = true;
            rbMbr.Location = new Point(79, 61);
            rbMbr.Name = "rbMbr";
            rbMbr.Size = new Size(80, 19);
            rbMbr.TabIndex = 2;
            rbMbr.Text = "MBR/BIOS";
            rbMbr.UseVisualStyleBackColor = true;
            // 
            // chkRecovery
            // 
            chkRecovery.AutoSize = true;
            chkRecovery.Location = new Point(12, 86);
            chkRecovery.Name = "chkRecovery";
            chkRecovery.Size = new Size(111, 19);
            chkRecovery.TabIndex = 3;
            chkRecovery.Text = "Create Recovery";
            chkRecovery.UseVisualStyleBackColor = true;
            chkRecovery.CheckedChanged += chkRecovery_CheckedChanged;
            // 
            // numBootSize
            // 
            numBootSize.Location = new Point(247, 84);
            numBootSize.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numBootSize.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            numBootSize.Name = "numBootSize";
            numBootSize.Size = new Size(70, 23);
            numBootSize.TabIndex = 20;
            numBootSize.Value = new decimal(new int[] { 200, 0, 0, 0 });
            numBootSize.ValueChanged += TriggerSizeUpdate;
            // 
            // btnFormat
            // 
            btnFormat.BackColor = Color.DarkRed;
            btnFormat.FlatStyle = FlatStyle.Flat;
            btnFormat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFormat.ForeColor = Color.White;
            btnFormat.Location = new Point(450, 28);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(166, 32);
            btnFormat.TabIndex = 4;
            btnFormat.Text = "FORMAT";
            btnFormat.UseVisualStyleBackColor = false;
            btnFormat.Click += btnFormat_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Black;
            txtOutput.ForeColor = Color.Lime;
            txtOutput.Location = new Point(12, 148);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(720, 272);
            txtOutput.TabIndex = 5;
            txtOutput.Text = "";
            // 
            // lblDisks
            // 
            lblDisks.AutoSize = true;
            lblDisks.Location = new Point(12, 14);
            lblDisks.Name = "lblDisks";
            lblDisks.Size = new Size(66, 15);
            lblDisks.TabIndex = 6;
            lblDisks.Text = "Select Disk:";
            // 
            // numWindowsSize
            // 
            numWindowsSize.Location = new Point(322, 84);
            numWindowsSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numWindowsSize.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numWindowsSize.Name = "numWindowsSize";
            numWindowsSize.Size = new Size(80, 23);
            numWindowsSize.TabIndex = 19;
            numWindowsSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numWindowsSize.ValueChanged += TriggerSizeUpdate;
            // 
            // cmbLang
            // 
            cmbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLang.FormattingEnabled = true;
            cmbLang.Location = new Point(630, 4);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(100, 23);
            cmbLang.TabIndex = 12;
            cmbLang.SelectedIndexChanged += cmbLang_SelectedIndexChanged;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Location = new Point(565, 8);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(61, 15);
            lblLang.TabIndex = 16;
            lblLang.Text = "Dil / Lang:";
            // 
            // lblRecoverySize
            // 
            lblRecoverySize.AutoSize = true;
            lblRecoverySize.Location = new Point(29, 102);
            lblRecoverySize.Name = "lblRecoverySize";
            lblRecoverySize.Size = new Size(0, 15);
            lblRecoverySize.TabIndex = 13;
            // 
            // numRecoverySize
            // 
            numRecoverySize.Enabled = false;
            numRecoverySize.Location = new Point(12, 111);
            numRecoverySize.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            numRecoverySize.Minimum = new decimal(new int[] { 450, 0, 0, 0 });
            numRecoverySize.Name = "numRecoverySize";
            numRecoverySize.Size = new Size(80, 23);
            numRecoverySize.TabIndex = 18;
            numRecoverySize.Value = new decimal(new int[] { 600, 0, 0, 0 });
            numRecoverySize.ValueChanged += TriggerSizeUpdate;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(240, 240, 240);
            pnlFooter.Controls.Add(lnkGithub);
            pnlFooter.Controls.Add(lnkAbout);
            pnlFooter.Controls.Add(lnkWebsite);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 431);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(750, 30);
            pnlFooter.TabIndex = 9;
            // 
            // lnkGithub
            // 
            lnkGithub.AutoSize = true;
            lnkGithub.Location = new Point(680, 7);
            lnkGithub.Name = "lnkGithub";
            lnkGithub.Size = new Size(43, 15);
            lnkGithub.TabIndex = 2;
            lnkGithub.TabStop = true;
            lnkGithub.Text = "Github";
            lnkGithub.LinkClicked += lnkGithub_LinkClicked;
            // 
            // lnkAbout
            // 
            lnkAbout.AutoSize = true;
            lnkAbout.Location = new Point(339, 7);
            lnkAbout.Name = "lnkAbout";
            lnkAbout.Size = new Size(57, 15);
            lnkAbout.TabIndex = 1;
            lnkAbout.TabStop = true;
            lnkAbout.Text = "Hakkında";
            lnkAbout.LinkClicked += lnkAbout_LinkClicked;
            // 
            // lnkWebsite
            // 
            lnkWebsite.AutoSize = true;
            lnkWebsite.Location = new Point(12, 7);
            lnkWebsite.Name = "lnkWebsite";
            lnkWebsite.Size = new Size(53, 15);
            lnkWebsite.TabIndex = 0;
            lnkWebsite.TabStop = true;
            lnkWebsite.Text = "Web Site";
            lnkWebsite.LinkClicked += lnkWebsite_LinkClicked;
            // 
            // lblBootSize
            // 
            lblBootSize.AutoSize = true;
            lblBootSize.Location = new Point(247, 66);
            lblBootSize.Name = "lblBootSize";
            lblBootSize.Size = new Size(67, 15);
            lblBootSize.TabIndex = 7;
            lblBootSize.Text = "Boot (MB) :";
            // 
            // btnCreateVhd
            // 
            btnCreateVhd.BackColor = Color.DarkGreen;
            btnCreateVhd.FlatStyle = FlatStyle.Flat;
            btnCreateVhd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateVhd.ForeColor = Color.White;
            btnCreateVhd.Location = new Point(567, 101);
            btnCreateVhd.Name = "btnCreateVhd";
            btnCreateVhd.Size = new Size(163, 32);
            btnCreateVhd.TabIndex = 8;
            btnCreateVhd.Text = "CREATE VHD";
            btnCreateVhd.UseVisualStyleBackColor = true;
            btnCreateVhd.Click += btnCreateVhd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(415, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 25);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "🔄";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblWindowsSize
            // 
            lblWindowsSize.AutoSize = true;
            lblWindowsSize.Location = new Point(321, 66);
            lblWindowsSize.Name = "lblWindowsSize";
            lblWindowsSize.Size = new Size(88, 15);
            lblWindowsSize.TabIndex = 11;
            lblWindowsSize.Text = "Windows (GB) :";
            // 
            // lblDataSize
            // 
            lblDataSize.AutoSize = true;
            lblDataSize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDataSize.ForeColor = Color.LimeGreen;
            lblDataSize.Location = new Point(241, 115);
            lblDataSize.Name = "lblDataSize";
            lblDataSize.Size = new Size(84, 19);
            lblDataSize.TabIndex = 14;
            lblDataSize.Text = "DATA: 0 GB";
            lblDataSize.Click += lblDataSize_Click;
            // 
            // lblVhdSize
            // 
            lblVhdSize.AutoSize = true;
            lblVhdSize.Location = new Point(567, 80);
            lblVhdSize.Name = "lblVhdSize";
            lblVhdSize.Size = new Size(86, 15);
            lblVhdSize.TabIndex = 15;
            lblVhdSize.Text = "VHD Size (GB) :";
            // 
            // numVhdSize
            // 
            numVhdSize.Location = new Point(681, 76);
            numVhdSize.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            numVhdSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numVhdSize.Name = "numVhdSize";
            numVhdSize.Size = new Size(46, 23);
            numVhdSize.TabIndex = 17;
            numVhdSize.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 461);
            Controls.Add(lblLang);
            Controls.Add(lblVhdSize);
            Controls.Add(numVhdSize);
            Controls.Add(lblDataSize);
            Controls.Add(numRecoverySize);
            Controls.Add(lblRecoverySize);
            Controls.Add(cmbLang);
            Controls.Add(numWindowsSize);
            Controls.Add(lblWindowsSize);
            Controls.Add(btnRefresh);
            Controls.Add(pnlFooter);
            Controls.Add(btnCreateVhd);
            Controls.Add(lblBootSize);
            Controls.Add(lblDisks);
            Controls.Add(txtOutput);
            Controls.Add(btnFormat);
            Controls.Add(numBootSize);
            Controls.Add(chkRecovery);
            Controls.Add(rbMbr);
            Controls.Add(rbGpt);
            Controls.Add(cmbDisks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diskpart GUI | made by Abdullah ERTÜRK";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numBootSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWindowsSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoverySize).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVhdSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbDisks;
        private System.Windows.Forms.RadioButton rbGpt;
        private System.Windows.Forms.RadioButton rbMbr;
        private System.Windows.Forms.CheckBox chkRecovery;
        private System.Windows.Forms.NumericUpDown numBootSize;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblDisks;
        private System.Windows.Forms.Label lblBootSize;
        private System.Windows.Forms.Button btnCreateVhd;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.LinkLabel lnkWebsite;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblWindowsSize;
        private System.Windows.Forms.NumericUpDown numWindowsSize;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblRecoverySize;
        private System.Windows.Forms.NumericUpDown numRecoverySize;
        private System.Windows.Forms.Label lblDataSize;
        private System.Windows.Forms.Label lblVhdSize;
        private System.Windows.Forms.NumericUpDown numVhdSize;
    }
}
