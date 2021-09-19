using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace CS_Exporter {
    class TestListBook {

        private string pdf, text, name, output, G = "";
        private string testBookpath, inis, addtionalDataPath, gPath, csFilePath = "";
        private int csKind = 0, Gpointer = 0;
        private string[] Glist;
        private List<TestListBook> testCases;

        public TestListBook(){

        }

        public TestListBook(string testBookpath, string inis, string addtionalDataPath, string gPath, string csFilePath, int csKind) {
            this.testBookpath = testBookpath;
            this.inis = inis;
            this.addtionalDataPath = addtionalDataPath;
            this.gPath = gPath;
            this.csFilePath = csFilePath;
            this.csKind = csKind;
        }

        public string Name { get; set; }
        public string Link { get; set; }

        public List<TestListBook> GetTestCaseFormExcel(string ExcelFilePath) {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook workbook = ExcelApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;
            List<TestListBook> list = new List<TestListBook>();
            for (int i = 2; i <= rowCount; i++) {
                TestListBook testCase = new TestListBook();
                for (int j = 1; j <= 2; j++) {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null) {
                        switch (j) {
                        case 1:
                            testCase.Name = range.Cells[i, j].Value2.ToString();
                            break;
                        case 2:
                            testCase.Link = range.Cells[i, j].Value2.ToString();
                            break;
                        }
                    }
                }
                list.Add(testCase);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(worksheet);

            //close and release
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            //quit and release
            ExcelApp.Quit();
            Marshal.ReleaseComObject(ExcelApp);

            return list;
        }

        public void ExportDotCS(){

            TestListBook book = new TestListBook();
            testCases = book.GetTestCaseFormExcel(testBookpath);

            SetHeaderAndPublicClass();

            output += "\n\n\t\t#region Test\n\n";
            name = "";
            pdf = "";
            G = @"\G\";
            text = "";

            if (!gPath.Equals(string.Empty) && csKind != 0) {
                Glist = Directory.GetFiles(gPath);
            }

            for (int i = 0; i < testCases.Count; i++) {

                try {
                    if (!testCases[i].Name.Equals(testCases[i + 1].Name) && testCases[i].Name != null && !testCases[i].Name.Trim().Equals(string.Empty)) {
                        name = testCases[i].Name;
                    }
                } catch (Exception) {
                    //last testcase
                    name = testCases[i].Name;
                }

                if (pdf.Equals("")) {
                    pdf = testCases[i].Link;
                }

                if (IsFukuSuuFile(i)) {
                    SetFukusuuTestCase(i);
                } else {
                    SetTestCase();
                }
            }

            output += "\t\t#endregion Test\n\t}\n}";
            Gpointer = 0;
            WriteCSFile();
        }

        private void SetHeaderAndPublicClass(){

            output = "\t/// <summary>\n\t/// " + inis + "の取込テスト\n\t/// </summary> \n";

            switch (csKind) {

            case (0)://Additional_S
                output += "\t[TestFixture, Apartment(System.Threading.ApartmentState.STA)]\n" +
    "\tpublic class Addtional_S_" + inis + "{\n" +
            "\t\tconst string FShoshikiName =\"" + inis + "\";\n" +
            "\t\tconst string FDirectoryName =   @\"" + addtionalDataPath + "\";\n" +
            "\t\tprivate string FInFilePath = $@\"{ TorikomiTest.C_Test_Data_Dir}\\Gaia.Common.SekkeiTorikomi\\AdditionalData\" + FDirectoryName + @\"\\S\";\n" +
            "\t\tprivate string FOutFilePath = Path.Combine(TorikomiTest.FUnitTestRootPath, \"S\", FDirectoryName);\n" +
            "\t\tprivate string FSekkeishoPath = Path.Combine(TorikomiTest.FRootPath, \"設計書\", FDirectoryName);\n";
                break;

            case (1)://_TorikomiKoji_S

                output += "\t[TestFixture, Apartment(System.Threading.ApartmentState.STA)]\n" +
 "\tpublic class Addtional_S_" + inis + "{\n" +
         "\t\tconst string FShoshikiName =\"" + inis + "\";\n" +
         "\t\tconst string FDirectoryName =   @\"" + addtionalDataPath + "\";\n" +
         "\t\tprivate string FInFilePath = $@\"{ TorikomiTest.C_Test_Data_Dir}\\Gaia.Common.SekkeiTorikomi\\AdditionalData\" + FDirectoryName + @\"\\S\";\n" +
         "\t\tprivate string FOutFilePath = Path.Combine(TorikomiTest.FUnitTestRootPath, \"S\", FDirectoryName);\n" +
         "\t\tprivate string FSekkeishoPath = Path.Combine(TorikomiTest.FRootPath, \"設計書\", FDirectoryName);\n";
                break;

            case (2)://TorikomiTest_S

                output += "\t[TestFixture, Apartment(System.Threading.ApartmentState.STA)]\n" +
    "\tpublic class Addtional_S_" + inis + "{\n" +
            "\t\tconst string FShoshikiName =\"" + inis + "\";\n" +
            "\t\tconst string FDirectoryName =   @\"" + addtionalDataPath + "\";\n" +
            "\t\tprivate string FInFilePath = $@\"{ TorikomiTest.C_Test_Data_Dir}\\Gaia.Common.SekkeiTorikomi\\AdditionalData\" + FDirectoryName + @\"\\S\";\n" +
            "\t\tprivate string FOutFilePath = Path.Combine(TorikomiTest.FUnitTestRootPath, \"S\", FDirectoryName);\n" +
            "\t\tprivate string FSekkeishoPath = Path.Combine(TorikomiTest.FRootPath, \"設計書\", FDirectoryName);\n";
                break;

            }
        }

        private void SetTestCase(){
            switch (csKind) {

            case (0)://Additional_S
                output += "\t\t[Test]\n" +
    "\t\tpublic void Test" + name + "() {\n" +
            "\t\t\tstring wTestName = @\"" + name + "\";\n" +
            "\t\t\tstring wTorikomiFile =   @\"" + pdf + "\";\n" +
            "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
            "\t\t\twTorikomiTest.ExecAdditionalTest(FInFilePath);\n" +
        "\t\t}\n\n";
                break;

            case (1)://_TorikomiKoji_S
                text = Glist[Gpointer];
                Gpointer++;
                output += "\t\t[Test]\n" +
    "\t\tpublic void Test" + name + "() {\n" +
            "\t\t\tstring wTestName = @\"" + name + "\";\n" +
            "\t\t\tstring wTorikomiFile = FSekkeishoPath + @\"" + pdf + "\";\n" +
            "\t\t\tstring wTestKojiFile = FInFilePath + @\"" + G + Path.GetFileName(text) + "\";\n" +
            "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
            "\t\t\twTorikomiTest.ExecTorikomiTest_TextKojiData(wTestKojiFile, true);\n" +
        "\t\t}\n\n";
                break;

            case (2)://TorikomiTest_S
                text = Glist[Gpointer];
                Gpointer++;
                output += "\t\t[Test]\n" +
    "\t\tpublic void Test" + name + "() {\n" +
            "\t\t\tstring wTestName = @\"" + name + "\";\n" +
            "\t\t\tstring wTorikomiFile = FSekkeishoPath + @\"" + pdf + "\";\n" +
            "\t\t\tstring wTestKojiFile = FInFilePath + @\"" + G + Path.GetFileName(text) + "\";\n" +
            "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
            "\t\t\twTorikomiTest.ExecTorikomiTest_TextKojiData(wTestKojiFile, 0);\n" +
        "\t\t}\n\n";
                break;

            }

            name = "";
            pdf = "";
        }

        private void SetFukusuuTestCase(int i){
            if (csKind == 0) {
                pdf += "\" + \"*\" + @\"" + testCases[i + 1].Link;
            } else if (csKind == 1) {
                pdf += "\" + \"*\" + @\"" + testCases[i + 1].Link;
            } else if (csKind == 2) {
                pdf += "\" + \"*\" + FSekkeishoPath + @\"" + testCases[i + 1].Link;
            } else {

            }
        }

        private Boolean IsFukuSuuFile(int i){
            try {
                if (testCases[i].Name.Equals(testCases[i + 1].Name) || testCases[i + 1].Name == null || testCases[i + 1].Name.Trim().Equals(string.Empty)) {
                    return true;
                }
            } catch (Exception e) {
                //last TestCase
                return false;
            }
            return false;
        }

        public Boolean WriteCSFile(){
            try{
                List<string> readline = File.ReadAllLines(csFilePath, Encoding.Default).ToList<string>();
                if (readline.Count > 0) {
                    //It is old file
                    readline[readline.Count - 1] = output;
                } else {
                    //It is new file
                    readline.Clear();
                    readline.Add("using NUnit.Framework;\nusing System.IO;\nusing Gaia.Common;\n");
                    readline.Add("namespace Sirius.Gaia.Common.SekkeiTorikomi.Additional_S." + Path.GetFileNameWithoutExtension(csFilePath) + " {");
                    readline.Add(output);
                }
                File.WriteAllLines(csFilePath, readline, Encoding.Default);
                return true;

            }catch(IOException e){
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }


}
