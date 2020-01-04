using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{
    public class JsonImportReplace
    {

        public string Key { get; set; }
        public string Text { get; set; }



        public static List<JsonImportReplace> Instance = Load();

        public static List<JsonImportReplace> Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                List<JsonImportReplace> instance = JsonConvert.DeserializeObject<List<JsonImportReplace>>(jsonContent);
                return instance;
            }
            else
            {
                return new List<JsonImportReplace>();
            }

        }


        public static void Save()
        {
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(JsonImportReplace.Instance, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }

        private static string GetFileName()
        {
            string directoryName = IOHelper.RootPath;
            return Path.Combine(directoryName, "JsonImportReplace.json");
        }
    }
}
