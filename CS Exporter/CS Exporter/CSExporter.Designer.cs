namespace CS_Exporter {
    partial class CSExporter {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnRun = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.btnGpath = new System.Windows.Forms.Button();
            this.GBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAdataPath = new System.Windows.Forms.Button();
            this.btnTFile = new System.Windows.Forms.Button();
            this.linkReset = new System.Windows.Forms.LinkLabel();
            this.lblCSFileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenEx = new System.Windows.Forms.Button();
            this.btninis = new System.Windows.Forms.Button();
            this.tbTCPath = new System.Windows.Forms.TextBox();
            this.tbInis = new System.Windows.Forms.TextBox();
            this.tbAddDatapath = new System.Windows.Forms.TextBox();
            this.tbGpath = new System.Windows.Forms.TextBox();
            this.tbTFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkOpenCSV = new System.Windows.Forms.LinkLabel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.linkCreateCSV = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRun.Location = new System.Drawing.Point(596, 43);
            this.btnRun.Name = "btnRun";
            this.tableLayoutPanel1.SetRowSpan(this.btnRun, 2);
            this.btnRun.Size = new System.Drawing.Size(138, 44);
            this.btnRun.TabIndex = 25;
            this.btnRun.Text = "テスト作成を実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbox
            // 
            this.cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbox.FormattingEnabled = true;
            this.cbox.ItemHeight = 16;
            this.cbox.Items.AddRange(new object[] {
            "Additional_S",
            "_TorikomiKoji_S",
            "TorikomiTest_S"});
            this.cbox.Location = new System.Drawing.Point(596, 98);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(138, 24);
            this.cbox.TabIndex = 23;
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // btnGpath
            // 
            this.btnGpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGpath.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGpath.Location = new System.Drawing.Point(553, 214);
            this.btnGpath.Name = "btnGpath";
            this.btnGpath.Size = new System.Drawing.Size(37, 22);
            this.btnGpath.TabIndex = 22;
            this.btnGpath.Text = "....";
            this.btnGpath.UseVisualStyleBackColor = true;
            this.btnGpath.Click += new System.EventHandler(this.btnGPath_Click);
            // 
            // btnAdataPath
            // 
            this.btnAdataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdataPath.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdataPath.Location = new System.Drawing.Point(553, 159);
            this.btnAdataPath.Name = "btnAdataPath";
            this.btnAdataPath.Size = new System.Drawing.Size(37, 22);
            this.btnAdataPath.TabIndex = 30;
            this.btnAdataPath.Text = "....";
            this.btnAdataPath.UseVisualStyleBackColor = true;
            this.btnAdataPath.Click += new System.EventHandler(this.btnAdataPath_Click);
            // 
            // btnTFile
            // 
            this.btnTFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTFile.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTFile.Location = new System.Drawing.Point(553, 268);
            this.btnTFile.Name = "btnTFile";
            this.btnTFile.Size = new System.Drawing.Size(37, 24);
            this.btnTFile.TabIndex = 38;
            this.btnTFile.Text = "....";
            this.btnTFile.UseVisualStyleBackColor = true;
            this.btnTFile.Click += new System.EventHandler(this.btnTFile_Click);
            // 
            // linkReset
            // 
            this.linkReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkReset.AutoSize = true;
            this.linkReset.Location = new System.Drawing.Point(23, 4);
            this.linkReset.Name = "linkReset";
            this.linkReset.Size = new System.Drawing.Size(404, 12);
            this.linkReset.TabIndex = 39;
            this.linkReset.TabStop = true;
            this.linkReset.Text = "Reset Setting";
            this.linkReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReset_LinkClicked);
            // 
            // lblCSFileName
            // 
            this.lblCSFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCSFileName.AutoSize = true;
            this.lblCSFileName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCSFileName.Location = new System.Drawing.Point(23, 245);
            this.lblCSFileName.Name = "lblCSFileName";
            this.lblCSFileName.Size = new System.Drawing.Size(404, 15);
            this.lblCSFileName.TabIndex = 41;
            this.lblCSFileName.Text = "Terget File name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tbTCPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbInis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbAddDatapath, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbGpath, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbTFile, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCSFileName, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.linkReset, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProgress, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnRun, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbox, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenEx, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btninis, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdataPath, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGpath, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnTFile, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.linkOpenCSV, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkCreateCSV, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 326);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // btnOpenEx
            // 
            this.btnOpenEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEx.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpenEx.Location = new System.Drawing.Point(553, 46);
            this.btnOpenEx.Name = "btnOpenEx";
            this.btnOpenEx.Size = new System.Drawing.Size(37, 22);
            this.btnOpenEx.TabIndex = 43;
            this.btnOpenEx.Text = "....";
            this.btnOpenEx.UseVisualStyleBackColor = true;
            this.btnOpenEx.Click += new System.EventHandler(this.btnOpenEx_Click);
            // 
            // btninis
            // 
            this.btninis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btninis.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btninis.Location = new System.Drawing.Point(553, 101);
            this.btninis.Name = "btninis";
            this.btninis.Size = new System.Drawing.Size(37, 22);
            this.btninis.TabIndex = 43;
            this.btninis.Text = "....";
            this.btninis.UseVisualStyleBackColor = true;
            this.btninis.Click += new System.EventHandler(this.btninis_Click);
            // 
            // tbTCPath
            // 
            this.tbTCPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbTCPath, 2);
            this.tbTCPath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTCPath.Location = new System.Drawing.Point(23, 46);
            this.tbTCPath.Name = "tbTCPath";
            this.tbTCPath.Size = new System.Drawing.Size(524, 22);
            this.tbTCPath.TabIndex = 35;
            // 
            // tbInis
            // 
            this.tbInis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbInis, 2);
            this.tbInis.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInis.Location = new System.Drawing.Point(23, 101);
            this.tbInis.Name = "tbInis";
            this.tbInis.Size = new System.Drawing.Size(524, 22);
            this.tbInis.TabIndex = 37;
            // 
            // tbAddDatapath
            // 
            this.tbAddDatapath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbAddDatapath, 2);
            this.tbAddDatapath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddDatapath.Location = new System.Drawing.Point(23, 159);
            this.tbAddDatapath.Name = "tbAddDatapath";
            this.tbAddDatapath.Size = new System.Drawing.Size(524, 22);
            this.tbAddDatapath.TabIndex = 39;
            // 
            // tbGpath
            // 
            this.tbGpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbGpath, 2);
            this.tbGpath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGpath.Location = new System.Drawing.Point(23, 214);
            this.tbGpath.Name = "tbGpath";
            this.tbGpath.Size = new System.Drawing.Size(524, 22);
            this.tbGpath.TabIndex = 41;
            // 
            // tbTFile
            // 
            this.tbTFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbTFile, 2);
            this.tbTFile.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTFile.Location = new System.Drawing.Point(23, 269);
            this.tbTFile.Name = "tbTFile";
            this.tbTFile.Size = new System.Drawing.Size(524, 22);
            this.tbTFile.TabIndex = 42;
            this.tbTFile.TextChanged += new System.EventHandler(this.tbTFile_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "テスト対象リスト(複数).csv";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "ShoshikiName(11埼玉県)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Additional Data Path (11埼玉県\\11埼玉県_土木)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(23, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "G Path (11埼玉県\\埼玉県 （土木）\\G)";
            // 
            // linkOpenCSV
            // 
            this.linkOpenCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkOpenCSV.AutoSize = true;
            this.linkOpenCSV.Location = new System.Drawing.Point(596, 4);
            this.linkOpenCSV.Name = "linkOpenCSV";
            this.linkOpenCSV.Size = new System.Drawing.Size(154, 12);
            this.linkOpenCSV.TabIndex = 44;
            this.linkOpenCSV.TabStop = true;
            this.linkOpenCSV.Text = "Open テスト対象リスト(複数)";
            this.linkOpenCSV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenCSV_LinkClicked);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgress.Location = new System.Drawing.Point(23, 298);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(404, 20);
            this.lblProgress.TabIndex = 45;
            this.lblProgress.Text = "Progress";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // linkCreateCSV
            // 
            this.linkCreateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCreateCSV.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkCreateCSV, 2);
            this.linkCreateCSV.Location = new System.Drawing.Point(433, 4);
            this.linkCreateCSV.Name = "linkCreateCSV";
            this.linkCreateCSV.Size = new System.Drawing.Size(157, 12);
            this.linkCreateCSV.TabIndex = 46;
            this.linkCreateCSV.TabStop = true;
            this.linkCreateCSV.Text = "Create テスト対象リスト(複数)";
            this.linkCreateCSV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateCSV_LinkClicked);
            // 
            // CSExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 326);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(2000, 365);
            this.MinimumSize = new System.Drawing.Size(0, 365);
            this.Name = "CSExporter";
            this.Text = "CS Exporter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Button btnGpath;
        private System.Windows.Forms.FolderBrowserDialog GBrowserDialog;
        private System.Windows.Forms.Button btnAdataPath;
        private System.Windows.Forms.Button btnTFile;
        private System.Windows.Forms.LinkLabel linkReset;
        private System.Windows.Forms.Label lblCSFileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btninis;
        private System.Windows.Forms.TextBox tbAddDatapath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTCPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGpath;
        private System.Windows.Forms.Button btnOpenEx;
        private System.Windows.Forms.TextBox tbTFile;
        private System.Windows.Forms.LinkLabel linkOpenCSV;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.LinkLabel linkCreateCSV;
    }
}

