namespace CS_Exporter.TestCaseSorter {
    partial class TestCaseSorter {
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
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput1
            // 
            this.tbInput1.Location = new System.Drawing.Point(12, 26);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(395, 19);
            this.tbInput1.TabIndex = 0;
            this.tbInput1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInput1_MouseClick);
            // 
            // tbInput2
            // 
            this.tbInput2.Location = new System.Drawing.Point(12, 55);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(395, 19);
            this.tbInput2.TabIndex = 2;
            this.tbInput2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbInput2_MouseClick);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(431, 26);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 52);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // backWorker
            // 
            this.backWorker.WorkerReportsProgress = true;
            this.backWorker.WorkerSupportsCancellation = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            this.backWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backWorker_ProgressChanged);
            this.backWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWorker_RunWorkerCompleted);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 78);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 12);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "label1";
            // 
            // TestCaseSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 99);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput1);
            this.Name = "TestCaseSorter";
            this.Text = "TestCaseSorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Button btnSort;
        private System.ComponentModel.BackgroundWorker backWorker;
        private System.Windows.Forms.Label lblProgress;
    }
}