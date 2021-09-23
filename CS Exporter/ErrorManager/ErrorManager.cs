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
        }

        List<string> files;

        private void btnStart_Click(object sender, EventArgs e) {
            if(!backgroundWorker.IsBusy){
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            files = Directory.GetFiles(tbErrorPath.Text).ToList();
            ErrorListBook book = new ErrorListBook();
            book.GetErrorListFormExcel(files, backgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            lblProgress.Text = e.ProgressPercentage.ToString() + "/" + files.Count.ToString();
        }
    }
}
