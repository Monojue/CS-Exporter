using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CS_Exporter {
    public partial class CSExporter : Form {

        string exportpath = "";
        string csKind = "";
        string fullGpath = "";
        DefaultSetting setting = new DefaultSetting();

        public CSExporter() {
            InitializeComponent();
            lblProgress.Text = "";
            setting.LoadSetting();
            cbox.SelectedIndex = 0;
            refreshLink();
        }

        public void refreshLink(){
            tbTCPath.Text = setting.TEST_LIST_FILE;
            tbInis.Text = Path.GetFileNameWithoutExtension(setting.SHOSHIKI_PATH);
            tbAddDatapath.Text = setting.ShortAddtionalData(setting.ADD_DATA_PATH);
            tbGpath.Text = setting.ShortGpath(setting.G_PATH);
            fullGpath = setting.G_PATH;
            tbTFile.Text = setting.Additional_S;
        }

        private void btnOpenEx_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.csv|Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    tbTCPath.Text = ofd.FileName;
                    setting.SetSetting(setting.vTesListFile, ofd.FileName);
                }
            }
        }

        private void btnGPath_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.SelectedPath = setting.G_PATH;
                if (fbd.ShowDialog() == DialogResult.OK) {
                    tbGpath.Text = setting.ShortGpath(fbd.SelectedPath);
                    fullGpath = fbd.SelectedPath;
                    setting.SetSetting(setting.vTextKojiDataPath, fbd.SelectedPath);
                }
            }
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e) {
            switch(cbox.SelectedIndex){
            case (0)://Additional_S
                exportpath = Path.GetDirectoryName(setting.Additional_S);
                tbGpath.Enabled = false;
                btnGpath.Enabled = false;
                csKind = setting.vAddtionalSPath;
                break;

            case (1)://_TorikomiKoji_S
                exportpath = Path.GetDirectoryName(setting.TorikomiKoji_S);
                tbGpath.Enabled = true;
                btnGpath.Enabled = true;
                csKind = setting.vTorikomiKojiPath;
                break;

            case (2)://TorikomiTest_S
                exportpath = Path.GetDirectoryName(setting.TorikomiTest_S);
                tbGpath.Enabled = true;
                btnGpath.Enabled = true;
                csKind = setting.vTorikomiTestPath;
                break;

            }
        }

        private void btninis_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Setting File|*.inis;*.inik;*.inij" }) {
                ofd.InitialDirectory = Path.GetDirectoryName(setting.SHOSHIKI_PATH);
                if (ofd.ShowDialog() == DialogResult.OK) {
                    tbInis.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                    setting.SetSetting(setting.vShoshiPath, ofd.FileName);
                }
            }
        }

        private void btnAdataPath_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.SelectedPath = setting.ADD_DATA_PATH;
                if (fbd.ShowDialog() == DialogResult.OK) {
                    tbAddDatapath.Text = setting.ShortAddtionalData(fbd.SelectedPath);
                    setting.SetSetting(setting.vAdditinalDataPath, fbd.SelectedPath);
                }
            }
        }

        private void btnTFile_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.InitialDirectory = exportpath;
                if (ofd.ShowDialog() == DialogResult.OK) {
                    tbTFile.Text = ofd.FileName;
                    setting.SetSetting(csKind, ofd.FileName);
                }
            }
        }

        TestListBook book;
        private void btnRun_Click(object sender, EventArgs e) {
            if(!backgroundWorker.IsBusy){
                book = new TestListBook(tbTCPath.Text, tbInis.Text, tbAddDatapath.Text, fullGpath, tbTFile.Text, cbox.SelectedIndex);
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void linkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            setting.ResetSetting();
            refreshLink();
        }

        private void linkOpenCSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(tbTCPath.Text);
        }

        private void tbTFile_TextChanged(object sender, EventArgs e) {
            lblCSFileName.Text = Path.GetFileName(tbTFile.Text);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            
            book.ExportDotCS(backgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            if(e.ProgressPercentage==0) lblProgress.Text = "Reading File...";
            if (e.ProgressPercentage >= 20) lblProgress.Text = "Executing Data...";
            if (e.ProgressPercentage >= 90) lblProgress.Text = "Writing File...";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            lblProgress.Text = "File Export Successfully!...";
        }
    }
}
