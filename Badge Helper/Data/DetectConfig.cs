using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class DetectConfig
    {

        public string FolderPath { get; set; }

        public string BadgesToIgnore { get; set; }

        public static DetectConfig Instance = Load();

        public static DetectConfig Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                DetectConfig instance = JsonConvert.DeserializeObject<DetectConfig>(jsonContent);
                return instance;
            }
            else
            {
                return new DetectConfig();
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
            return Path.Combine(directoryName, "DetectConfig.json");
        }
    }
}
