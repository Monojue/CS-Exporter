using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exporter {
    class compare {
        private List<TestListBook> newList;
        private List<TestListBook> oldList;
        private List<TestListBook> tempList;
        //private List<TestListBook> minList;
        private List<TestListBook> exportList = new List<TestListBook>();
        //int maxLine;

        public compare(){

        }

        public void Compare(string newFile, string mainFile, BackgroundWorker background){

            TestListBook book = new TestListBook();
            background.ReportProgress(0);
            newList = book.GetTestCaseFormExcel(newFile , out Boolean newListisOldfile);
            background.ReportProgress(50);
            oldList = book.GetTestCaseFormExcel(mainFile, out Boolean oldListisOldfile);
            background.ReportProgress(100);
            if(newListisOldfile){
                tempList = oldList;
                oldList = newList;
                newList = tempList;
            }

            for(int i=0; i<oldList.Count; i++){
                Boolean found = false;
                background.ReportProgress(110);
                for (int j=0; j<newList.Count; j++){

                    // Check whole Test Case Path is contain in Other file
                    if(oldList[i].Link.Equals(newList[j].Link)){
                        exportList.Add(newList[j]);
                        exportList[i].Name = oldList[i].Name;
                        exportList[i].Biko = "Found!";
                        newList.RemoveAt(j);
                        found = true;
                        break;
                    }
                    else{
                        found = false;
                    }
                }

                //if(!found){
                //    for (int j = 0; j < newList.Count; j++) {

                //        // Check with FileName 
                //        // If FileName found, define as Path is Change
                //        if (Path.GetFileName(oldList[i].Link).Equals(Path.GetFileName(newList[j].Link))) {
                //            exportList.Add(newList[j]);
                //            exportList[i].Name = oldList[i].Name;
                //            exportList[i].Biko = "PathChange!";
                //            newList.RemoveAt(j);
                //            found = true;
                //            break;
                //        } else {
                //            found = false;
                //        }
                //    }
                //}
                
                // if Not Found
                if (!found){
                    exportList.Add(oldList[i]);
                    exportList[i].Biko = "NotFound!";
                }
            }
            
            // At this time, Test Case left in minList can be define as New Test Case
            foreach(TestListBook line in newList){
                line.Biko = "New!";
                exportList.Add(line);
            }

            book.ExportDataSetToExcel(exportList);
            //File.WriteAllLines(Environment.CurrentDirectory + "@/TestCaseSorted.txt", , Encoding.Default);
        }
    }
}
