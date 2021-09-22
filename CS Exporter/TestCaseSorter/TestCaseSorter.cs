using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Exporter.TestCaseSorter {
    public partial class TestCaseSorter : Form {
        public TestCaseSorter() {
            InitializeComponent();
            lblProgress.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e) {
            
            if(!backWorker.IsBusy){
                lblProgress.Text = "";
                backWorker.RunWorkerAsync();   
            }
            
        }

        private void tbInput1_MouseClick(object sender, MouseEventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    tbInput1.Text = ofd.FileName;
                }
            }
        }

        private void tbInput2_MouseClick(object sender, MouseEventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    tbInput2.Text = ofd.FileName;
                }
            }
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e) {
            
            compare compare = new compare();
            compare.Compare(tbInput1.Text, tbInput2.Text, backWorker);

        }

        private void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if(e.ProgressPercentage<100)
                lblProgress.Text = "Reading..." + e.ProgressPercentage + "%";
            else
                lblProgress.Text = "Sorting...";
        }

        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            lblProgress.Text = "Test Case Sorted Successfully!";
        }
    }
}
