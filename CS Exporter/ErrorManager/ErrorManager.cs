using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Exporter.ErrorManager {
    public partial class ErrorManager : Form {
        public ErrorManager() {
            InitializeComponent();
            lblCondition.Text = "";
        }

        List<string> files;

        private void btnStart_Click(object sender, EventArgs e) {
            if(!backgroundWorker.IsBusy){
                lblCondition.Text = "";
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            files = Directory.GetFiles(tbErrorPath.Text).ToList();
            ErrorListBook book = new ErrorListBook();
            book.GetErrorListFormExcel(files, tbErrorPath.Text, backgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            lblProgress.Text = e.ProgressPercentage.ToString() + "/" + files.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            backgroundWorker.CancelAsync();
            lblCondition.Text = "User Cancel!";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            lblCondition.Text = "Successfully Completed!";
        }
    }
}
