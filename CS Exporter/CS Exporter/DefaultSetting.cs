using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Exporter {
    class DefaultSetting {

        private static string DEFAULT_ROOT = @"C:\Develop_Env\Sirius\sirius\Gaia\Client\Sekisan\Test.SekkeiTorikomi\Gaia.Common.SekkeiTorikomi\";

        private string DEFAULT_TEST_LIST_FILE = @"C:\Tools\ユニットテスト作成用\テスト対象リスト(複数).csv";
        private string DEFAULT_SHOSHIKI_PATH = @"C:\ProgramData\CoBeing\GaiaCloud\ESpec\iniS\11埼玉県_土木.inis";
        private string DEFAULT_G_PATH = @"C:\Develop_Env\Sirius\sirius\Gaia\Client\Sekisan\Test.SekkeiTorikomi\TextKojiData\11埼玉県\埼玉県 （土木）\G";

        private string DEFAULT_ADD_DATA_PATH = DEFAULT_ROOT + @"AdditionalData\11埼玉県\11埼玉県_土木";
        private string DEFAULT_Additional_S = DEFAULT_ROOT + @"Additional_S\11埼玉県.cs";
        private string DEFAULT_TorikomiKoji_S = DEFAULT_ROOT + @"_TorikomiKoji_S\";
        private string DEFAULT_TorikomiTest_S = DEFAULT_ROOT + @"TorikomiTest_S\";

        public readonly string vTesListFile = "TestListFile";
        public readonly string vShoshiPath = "ShoshiPath";
        public readonly string vTextKojiDataPath = "TextKojiDataPath";
        public readonly string vAdditinalDataPath = "AdditinalDataPath";
        public readonly string vAddtionalSPath = "AddtionalSPath";
        public readonly string vTorikomiKojiPath = "TorikomiKojiPath";
        public readonly string vTorikomiTestPath = "TorikomiTestPath"; 
       
        public string TEST_LIST_FILE = "";
        public string SHOSHIKI_PATH = "";
        public string G_PATH = "";
        public string ADD_DATA_PATH = "";
        public string Additional_S = "";
        public string TorikomiKoji_S = "";
        public string TorikomiTest_S = "";

        string settingFile = Environment.CurrentDirectory +@"/csExport.ini";

        List<string> setting;

        public DefaultSetting(){
            CheckSetting();
        }

        public void CheckSetting() {
            if (!File.Exists(settingFile)) {
                File.Create(settingFile).Close();
                ResetSetting();
                LoadSetting();
            }
        }

        public void ResetSetting(){
            setting = new List<string>();

            setting.Add(vTesListFile + "=" + DEFAULT_TEST_LIST_FILE);
            setting.Add(vShoshiPath + "=" + DEFAULT_SHOSHIKI_PATH);
            setting.Add(vTextKojiDataPath + "=" + DEFAULT_G_PATH);
            setting.Add(vAdditinalDataPath + "=" + DEFAULT_ADD_DATA_PATH);
            setting.Add(vAddtionalSPath + "=" + DEFAULT_Additional_S);
            setting.Add(vTorikomiKojiPath + "=" + DEFAULT_TorikomiKoji_S);
            setting.Add(vTorikomiTestPath + "=" + DEFAULT_TorikomiTest_S);

            File.WriteAllLines(settingFile, setting);
            LoadSetting();
        }

        public void LoadSetting(){
            if(File.Exists(settingFile)){
                setting = File.ReadAllLines(settingFile).ToList();
                foreach(string line in setting){
                    if(line.Contains(vTesListFile)) TEST_LIST_FILE = line.Replace("TesListFile=", "");
                    if (line.Contains(vShoshiPath)) SHOSHIKI_PATH = line.Replace("ShoshiPath=", "");
                    if (line.Contains(vTextKojiDataPath)) G_PATH = line.Replace("TextKojiDataPath=", "");
                    if (line.Contains(vAdditinalDataPath)) ADD_DATA_PATH = line.Replace("AdditinalDataPath=", "");
                    if (line.Contains(vAddtionalSPath)) Additional_S = line.Replace("AddtionalSPath=", "");
                    if (line.Contains(vTorikomiKojiPath)) TorikomiKoji_S = line.Replace("TorikomiKojiPath=", "");
                    if (line.Contains(vTorikomiTestPath)) TorikomiTest_S = line.Replace("TorikomiTestPath=", "");
                }
            }
        }

        public void SetSetting(string settingitem, string newpath){
            LoadSetting();
            for(int i=0; i<setting.Count; i++){
                if (setting[i].Contains(settingitem)) {
                    setting[i] = setting[i].Replace(setting[i], settingitem + "=" + newpath);
                    break;
                } 
            }
            File.WriteAllLines(settingFile, setting);
        }

        public string ShortAddtionalData(string fullLink){
            return fullLink.Substring(fullLink.IndexOf(@"AdditionalData\")+15);
        }

        public string ShortGpath(string fullLink) {
            return fullLink.Substring(fullLink.IndexOf(@"TextKojiData\") + 13);
        }

        public string ShortPDFpath(string fullLink,string Gpath) {
            String shortGpath = ShortGpath(Gpath).Replace(@"\G","");
            return fullLink.Substring(fullLink.IndexOf(shortGpath) + shortGpath.Length);
        }
    }
}
