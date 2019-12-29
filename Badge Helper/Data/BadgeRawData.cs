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
                        rdi.Badges.Add(bi);
                    }
                }

                dataList.Add(rdi);
            }



            return dataList;
        }

        private static string GetRawDataFileName()
        {
            string directoryName = IOHelper.RootPath;
            return Path.Combine(directoryName, "RawData.xlsx");
        }
    }
}
