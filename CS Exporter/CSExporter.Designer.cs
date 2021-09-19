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
            this.btnOpenEx = new System.Windows.Forms.Button();
            this.tbGpath = new System.Windows.Forms.TextBox();
            this.tbTCPath = new System.Windows.Forms.TextBox();
            this.GBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbInis = new System.Windows.Forms.TextBox();
            this.btninis = new System.Windows.Forms.Button();
            this.btnAdataPath = new System.Windows.Forms.Button();
            this.tbAddDatapath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTFile = new System.Windows.Forms.Button();
            this.linkReset = new System.Windows.Forms.LinkLabel();
            this.linkOpenCSV = new System.Windows.Forms.LinkLabel();
            this.lblCSFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRun.Location = new System.Drawing.Point(462, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(138, 53);
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
            this.cbox.Location = new System.Drawing.Point(462, 108);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(138, 24);
            this.cbox.TabIndex = 23;
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // btnGpath
            // 
            this.btnGpath.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGpath.Location = new System.Drawing.Point(371, 219);
            this.btnGpath.Name = "btnGpath";
            this.btnGpath.Size = new System.Drawing.Size(40, 25);
            this.btnGpath.TabIndex = 22;
            this.btnGpath.Text = "....";
            this.btnGpath.UseVisualStyleBackColor = true;
            this.btnGpath.Click += new System.EventHandler(this.btnGPath_Click);
            // 
            // btnOpenEx
            // 
            this.btnOpenEx.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpenEx.Location = new System.Drawing.Point(371, 36);
            this.btnOpenEx.Name = "btnOpenEx";
            this.btnOpenEx.Size = new System.Drawing.Size(40, 25);
            this.btnOpenEx.TabIndex = 21;
            this.btnOpenEx.Text = "....";
            this.btnOpenEx.UseVisualStyleBackColor = true;
            this.btnOpenEx.Click += new System.EventHandler(this.btnOpenEx_Click);
            // 
            // tbGpath
            // 
            this.tbGpath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGpath.Location = new System.Drawing.Point(12, 220);
            this.tbGpath.Name = "tbGpath";
            this.tbGpath.Size = new System.Drawing.Size(344, 22);
            this.tbGpath.TabIndex = 19;
            // 
            // tbTCPath
            // 
            this.tbTCPath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTCPath.Location = new System.Drawing.Point(12, 39);
            this.tbTCPath.Name = "tbTCPath";
            this.tbTCPath.Size = new System.Drawing.Size(344, 22);
            this.tbTCPath.TabIndex = 18;
            // 
            // tbInis
            // 
            this.tbInis.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInis.Location = new System.Drawing.Point(12, 93);
            this.tbInis.Name = "tbInis";
            this.tbInis.Size = new System.Drawing.Size(344, 22);
            this.tbInis.TabIndex = 27;
            // 
            // btninis
            // 
            this.btninis.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btninis.Location = new System.Drawing.Point(371, 92);
            this.btninis.Name = "btninis";
            this.btninis.Size = new System.Drawing.Size(40, 25);
            this.btninis.TabIndex = 28;
            this.btninis.Text = "....";
            this.btninis.UseVisualStyleBackColor = true;
            this.btninis.Click += new System.EventHandler(this.btninis_Click);
            // 
            // btnAdataPath
            // 
            this.btnAdataPath.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdataPath.Location = new System.Drawing.Point(371, 158);
            this.btnAdataPath.Name = "btnAdataPath";
            this.btnAdataPath.Size = new System.Drawing.Size(40, 25);
            this.btnAdataPath.TabIndex = 30;
            this.btnAdataPath.Text = "....";
            this.btnAdataPath.UseVisualStyleBackColor = true;
            this.btnAdataPath.Click += new System.EventHandler(this.btnAdataPath_Click);
            // 
            // tbAddDatapath
            // 
            this.tbAddDatapath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddDatapath.Location = new System.Drawing.Point(12, 159);
            this.tbAddDatapath.Name = "tbAddDatapath";
            this.tbAddDatapath.Size = new System.Drawing.Size(344, 22);
            this.tbAddDatapath.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "テスト対象リスト.csv";
            // 
            // tbTFile
            // 
            this.tbTFile.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTFile.Location = new System.Drawing.Point(12, 277);
            this.tbTFile.Name = "tbTFile";
            this.tbTFile.Size = new System.Drawing.Size(544, 22);
            this.tbTFile.TabIndex = 20;
            this.tbTFile.TextChanged += new System.EventHandler(this.tbTFile_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "ShoshikiName(11埼玉県)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Additional Data Path (11埼玉県\\11埼玉県_土木)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "G Path";
            // 
            // btnTFile
            // 
            this.btnTFile.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTFile.Location = new System.Drawing.Point(570, 274);
            this.btnTFile.Name = "btnTFile";
            this.btnTFile.Size = new System.Drawing.Size(40, 25);
            this.btnTFile.TabIndex = 38;
            this.btnTFile.Text = "....";
            this.btnTFile.UseVisualStyleBackColor = true;
            this.btnTFile.Click += new System.EventHandler(this.btnTFile_Click);
            // 
            // linkReset
            // 
            this.linkReset.AutoSize = true;
            this.linkReset.Location = new System.Drawing.Point(525, 9);
            this.linkReset.Name = "linkReset";
            this.linkReset.Size = new System.Drawing.Size(75, 12);
            this.linkReset.TabIndex = 39;
            this.linkReset.TabStop = true;
            this.linkReset.Text = "Reset Setting";
            this.linkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReset_LinkClicked);
            // 
            // linkOpenCSV
            // 
            this.linkOpenCSV.AutoSize = true;
            this.linkOpenCSV.Location = new System.Drawing.Point(390, 9);
            this.linkOpenCSV.Name = "linkOpenCSV";
            this.linkOpenCSV.Size = new System.Drawing.Size(129, 12);
            this.linkOpenCSV.TabIndex = 40;
            this.linkOpenCSV.TabStop = true;
            this.linkOpenCSV.Text = "Open テスト対象リスト.csv";
            this.linkOpenCSV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenCSV_LinkClicked);
            // 
            // lblCSFileName
            // 
            this.lblCSFileName.AutoSize = true;
            this.lblCSFileName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCSFileName.Location = new System.Drawing.Point(12, 259);
            this.lblCSFileName.Name = "lblCSFileName";
            this.lblCSFileName.Size = new System.Drawing.Size(0, 15);
            this.lblCSFileName.TabIndex = 41;
            // 
            // CSExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 317);
            this.Controls.Add(this.lblCSFileName);
            this.Controls.Add(this.linkOpenCSV);
            this.Controls.Add(this.linkReset);
            this.Controls.Add(this.btnTFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddDatapath);
            this.Controls.Add(this.btnAdataPath);
            this.Controls.Add(this.btninis);
            this.Controls.Add(this.tbInis);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.btnGpath);
            this.Controls.Add(this.btnOpenEx);
            this.Controls.Add(this.tbTFile);
            this.Controls.Add(this.tbGpath);
            this.Controls.Add(this.tbTCPath);
            this.Name = "CSExporter";
            this.Text = "CS Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Button btnGpath;
        private System.Windows.Forms.Button btnOpenEx;
        private System.Windows.Forms.TextBox tbGpath;
        private System.Windows.Forms.TextBox tbTCPath;
        private System.Windows.Forms.FolderBrowserDialog GBrowserDialog;
        private System.Windows.Forms.TextBox tbInis;
        private System.Windows.Forms.Button btninis;
        private System.Windows.Forms.Button btnAdataPath;
        private System.Windows.Forms.TextBox tbAddDatapath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTFile;
        private System.Windows.Forms.LinkLabel linkReset;
        private System.Windows.Forms.LinkLabel linkOpenCSV;
        private System.Windows.Forms.Label lblCSFileName;
    }
}

