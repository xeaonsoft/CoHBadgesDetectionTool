using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class BindFileConfig
    {

        public string FolderPath { get; set; }

        public static BindFileConfig Instance = Load();

        public static BindFileConfig Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                BindFileConfig instance = JsonConvert.DeserializeObject<BindFileConfig>(jsonContent);
                return instance;
            }
            else
            {
                return new BindFileConfig();
            }

        }


        public void Save()
        {
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }

        private static string GetFileName()
        {
            string directoryName = IOHelper.RootPath; 
            return Path.Combine(directoryName, "BindFileConfig.json");
        }
    }
}
