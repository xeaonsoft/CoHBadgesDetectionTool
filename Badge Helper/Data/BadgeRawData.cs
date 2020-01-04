using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Badge_Helper
{
    public class BadgeRawData
    {
        public static List<RawDataItem> Read()
        {
            List<RawDataItem> dataList = new List<RawDataItem>();

            string fileName = GetRawDataFileName();
            XSSFWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(file);
            }

            int numberOfSheets = workbook.NumberOfSheets;
            for (int i = 0; i < numberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);

                RawDataItem rdi = new RawDataItem { Name = sheet.SheetName };

                for (int row = 0; row <= sheet.LastRowNum; row++)
                {
                    var sheetRow = sheet.GetRow(row);
                    if (sheetRow != null)
                    {


                        RawBadgeItem bi = new RawBadgeItem { Group = string.Empty };
                        var cell0 = sheetRow.GetCell(0);
                        if (cell0 == null)
                            continue;

                        bi.Name = cell0.StringCellValue;
                        var cell1 = sheetRow.GetCell(1);
                        if (cell1 != null)
                            bi.Group = cell1.StringCellValue;

                        var cell2 = sheetRow.GetCell(2);
                        if (cell2 != null)
                            bi.SetTitleID = (int)cell2.NumericCellValue;

                        rdi.Badges.Add(bi);
                    }
                }

                dataList.Add(rdi);
            }



            return dataList;
        }

        //public static void Save(List<RawDataItem> rawList)
        //{
        //    List<RawDataItem> dataList = new List<RawDataItem>();

        //    string directoryName = IOHelper.RootPath;
        //    string fileName = Path.Combine(directoryName, Guid.NewGuid().ToString("N") + ".xlsx");


        //    using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        //    {
        //        IWorkbook workbook = new XSSFWorkbook();

        //        foreach (var tab in rawList)
        //        {

        //            ISheet sheet = workbook.CreateSheet(tab.Name);

        //            foreach (var b in tab.Badges)
        //            {
        //                IRow row = sheet.CreateRow(sheet.PhysicalNumberOfRows + 1);
        //                row.CreateCell(0).SetCellValue(b.Name);
        //                row.CreateCell(1).SetCellValue(b.Group);
        //                row.CreateCell(2).SetCellValue(b.SetTitleID);
        //            }
        //        }
        //        workbook.Write(fs);
        //    }


        //}

        public static void Save(List<RawDataItem> rawList)
        {
            List<RawDataItem> dataList = new List<RawDataItem>();

            string fileName = GetRawDataFileName();

            XSSFWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(file);
            }

            int numberOfSheets = workbook.NumberOfSheets;
            for (int i = 0; i < numberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);
                var r = rawList.Single(a => a.Name == sheet.SheetName);


                for (int row = 0; row <= sheet.LastRowNum; row++)
                {
                    var sheetRow = sheet.GetRow(row);
                    if (sheetRow != null)
                    {



                        var cell0 = sheetRow.GetCell(0);
                        if (cell0 == null)
                            continue;

                        string name = cell0.StringCellValue;
                        var found = r.Badges.SingleOrDefault(a => a.Name == name);
                        var cell2 = sheetRow.GetCell(2);//get column 3, which is "settitleid"
                        if (cell2 == null)
                            cell2 = sheetRow.CreateCell(2);
                        cell2.SetCellValue(found.SetTitleID);
                    }
                }


            }



            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Write))
            {
                workbook.Write(file);
                file.Close();
            }



            //using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    IWorkbook workbook = new XSSFWorkbook();

            //    foreach (var tab in rawList)
            //    {

            //        ISheet sheet = workbook.CreateSheet(tab.Name);

            //        foreach (var b in tab.Badges)
            //        {
            //            IRow row = sheet.CreateRow(sheet.PhysicalNumberOfRows + 1);
            //            row.CreateCell(0).SetCellValue(b.Name);
            //            row.CreateCell(1).SetCellValue(b.Group);
            //            row.CreateCell(2).SetCellValue(b.SetTitleID);
            //        }
            //    }
            //    workbook.Write(fs);
            //}


        }

        public static void SaveImportData(string content, string category)
        {
            string directoryName = IOHelper.RootPath;
            string fileName = Path.Combine(directoryName, category + ".txt");
            File.WriteAllText(fileName, content);
        }

        private static string GetRawDataFileName()
        {
            string directoryName = IOHelper.RootPath;
            return Path.Combine(directoryName, "RawData.xlsx");
        }
    }
}
