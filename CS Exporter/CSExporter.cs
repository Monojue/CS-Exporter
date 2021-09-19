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
        DefaultSetting setting = new DefaultSetting();

        public CSExporter() {
            InitializeComponent();
            cbox.SelectedIndex = -1;
            setting.LoadSetting();
            refreshLink();
        }

        public void refreshLink(){
            tbTCPath.Text = setting.TEST_LIST_FILE;
            tbInis.Text = Path.GetFileNameWithoutExtension(setting.SHOSHIKI_PATH);
            tbAddDatapath.Text = setting.ExtraceAddtionalData(setting.ADD_DATA_PATH);
            tbGpath.Text = setting.G_PATH;
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
                    tbGpath.Text = fbd.SelectedPath;
                    setting.SetSetting(setting.vTextKojiDataPath, fbd.SelectedPath);
                }
            }
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e) {
            switch(cbox.SelectedIndex){
            case (0)://Additional_S
                exportpath = setting.Additional_S;
                tbGpath.Enabled = false;
                btnGpath.Enabled = false;
                csKind = setting.vAddtionalSPath;
                break;

            case (1)://_TorikomiKoji_S
                exportpath = setting.TorikomiKoji_S;
                tbGpath.Enabled = true;
                btnGpath.Enabled = true;
                csKind = setting.vTorikomiKojiPath;
                break;

            case (2)://TorikomiTest_S
                exportpath = setting.TorikomiTest_S;
                tbGpath.Enabled = true;
                btnGpath.Enabled = true;
                csKind = setting.vTorikomiTestPath;
                break;

            }
        }

        private void btninis_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Setting File|*.inis;*.inik;*.inij" }) {
                ofd.InitialDirectory = setting.SHOSHIKI_PATH;
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
                    tbAddDatapath.Text = setting.ExtraceAddtionalData(fbd.SelectedPath);
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

        private void btnRun_Click(object sender, EventArgs e) {
            TestListBook book = new TestListBook(tbTCPath.Text, tbInis.Text, tbAddDatapath.Text, tbGpath.Text, tbTFile.Text, cbox.SelectedIndex);
            book.ExportDotCS();
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
    }
}
