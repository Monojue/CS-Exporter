using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace CS_Exporter {
    class ErrorListBook {

        public ErrorListBook(){

        }

        public string Name { get; set; }
        public List<string> ErrorList { get; set; }

        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range range;

        public void GetErrorListFormExcel(List<string> Files, string path, BackgroundWorker background) {
            List<ErrorListBook> list = new List<ErrorListBook>();

            Excel.Application ExcelApp = new Excel.Application();
            int progress = 1;
            
            foreach (string file in Files){
                
                if(!background.CancellationPending){
                    workbook = ExcelApp.Workbooks.Open(file);
                    worksheet = workbook.Sheets[1];
                    range = worksheet.UsedRange;
                    int rowCount = range.Rows.Count;
                    int dataColumn = 8;

                    ErrorListBook book = new ErrorListBook();
                    book.ErrorList = new List<string>();
                    book.Name = range.Cells[2, 1].Value2;
                    for (int i = 2; i <= rowCount; i++) {
                        string cellValue = range.Cells[i, dataColumn].Value2;
                        if (range.Cells[i, dataColumn] != null && cellValue != null) {
                            if (!book.ErrorList.Contains(cellValue)) {
                                book.ErrorList.Add(cellValue);
                            }
                        }
                    }
                    list.Add(book);
                    background.ReportProgress(progress++);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(range);
                    Marshal.ReleaseComObject(worksheet);

                    //close and release
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                }
            }
            if (background.CancellationPending){
                //quit and release
                ExcelApp.Quit();
                Marshal.ReleaseComObject(ExcelApp);
            } else{
                ExportDataSetToExcel(list, ExcelApp, path);
            }
        }


        public void ExportDataSetToExcel(List<ErrorListBook> list, Excel.Application ExcelApp, string path) {
            try {
                //ExcelApp.Visible = false;
                //ExcelApp.DisplayAlerts = false;
                workbook = ExcelApp.Workbooks.Add();

                //Create an Excel workbook instance and open it from the predefined location
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "ErrorManger";

                List<string> colList = new List<string>();

                for (int j = 0; j < list.Count; j++) {
                    worksheet.Cells[j + 2, 1] = list[j].Name;
                    foreach(string item in list[j].ErrorList){
                        if(!colList.Contains(item)){
                            colList.Add(item);
                        }
                        worksheet.Cells[j + 2, colList.IndexOf(item) + 2] = "〇";
                        
                    }   
                }
                worksheet.Application.ActiveWindow.FreezePanes = true;
                worksheet.Cells[1, 1] = "テスト名";
                for(int i=0; i<colList.Count; i++){
                    worksheet.Cells[1, i+2] = colList[i];
                }

                workbook.SaveAs(path + @"/ErrorManager.csv", XlFileFormat.xlCSV);
            } catch (Exception) {
                
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(worksheet);

            //close and release
            workbook.Close();
            Marshal.ReleaseComObject(workbook);
            //quit and release
            ExcelApp.Quit();
            Marshal.ReleaseComObject(ExcelApp);
        }
    }
}
