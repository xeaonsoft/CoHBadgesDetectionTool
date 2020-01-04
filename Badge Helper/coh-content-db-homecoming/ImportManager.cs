using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{
    public class ImportManager
    {
        public static void Import()
        {
            List<ImportData> importList = new List<ImportData>();

            var jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;


            string rootPath = @"C:\CodeEnv\Xeaonsoft\CoH Stuff\coh-content-db-homecoming-master\src\badge";//todo: config file ?


            string[] files = Directory.GetFiles(rootPath, "*.ts", SearchOption.AllDirectories);


            foreach (string file in files)
            {

                const string keyWord = "IBadgeData =";
                string content = File.ReadAllText(file).Trim();
                int pos = content.IndexOf(keyWord);
                if (pos > 0)
                {

                    int l = pos + keyWord.Length;
                    string jsonContent = content.Substring(l, content.Length - l);
                    jsonContent = jsonContent.TrimEnd(';');
                    jsonContent = coh_content_db_homecoming.StripHelper.Strip(jsonContent);
                    var entry = JsonConvert.DeserializeObject<ImportData>(jsonContent, jsonSerializerSettings);

                    entry.category = parseCategeory(rootPath, file);
                    importList.Add(entry);

                }
            }

            {
                //var groupList = importList.GroupBy(a => a.category).Select(a => a.First());
                //foreach (var grp in groupList)
                //{
                //    var subset = importList.Where(a => a.category == grp.category);
                //    StringBuilder sb = new StringBuilder();
                //    foreach (var subEntry in subset)
                //    {
                //        sb.AppendLine($"{subEntry.GetNames()}|{subEntry.setTitleId}");
                //    }
                //    string subContent = sb.ToString();
                //    BadgeRawData.SaveImportData(subContent, grp.category);
                //}


                List<RawDataItem> rawDataList = BadgeRawData.Read();
                foreach (var rd in rawDataList)
                {
                    foreach (var b in rd.Badges)
                    {
                        var foundList = importList.Where(a => a.GetNames() == b.Name);
                        if (foundList.Count() == 0)
                        {
                            b.SetTitleID = 0;
                        }
                        else if (foundList.Count() == 1)
                        {
                            b.SetTitleID = foundList.First().setTitleId;
                        }
                        else
                        {

                        }
                    }
                }


                BadgeRawData.Save(rawDataList);
                {

                }
            }
        }

        private static string parseCategeory(string rootPath, string file)
        {

            string fileFolder = Path.GetDirectoryName(file);
            string key = fileFolder.Replace(rootPath, string.Empty);
            return key.TrimStart('\\');
        }
    }
}
