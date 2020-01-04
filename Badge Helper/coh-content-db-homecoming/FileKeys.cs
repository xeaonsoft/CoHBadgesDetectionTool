using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{
    public class FileKeyItem
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
    public class FileKeys
    {
        private static bool _init = false;
        public static List<FileKeyItem> MapKeys = new List<FileKeyItem>();
        public static List<FileKeyItem> BadgesKeys = new List<FileKeyItem>();

        //public FileKeys()
        //{
        //    ReadMapKeys();
        //}
        public static void Init()
        {
            if (!_init)
            {
                ReadMapKeys();
                _init = true;
            }
        }
        public static void ReadMapKeys()
        {
            string folder = @"C:\CodeEnv\Xeaonsoft\CoH Stuff\coh-content-db-homecoming-master\src\map";
            MapKeys = ReadKeys(folder);





            MapKeys.ForEach(a => a.Group = 9);
            MapKeys.Where(a => a.Name.ToLower().StartsWith("echo")).ToList().ForEach(a => a.Group = 1);
            MapKeys.Where(a => a.Name.ToLower().StartsWith("underground")).ToList().ForEach(a => a.Group = 2);
            MapKeys.Where(a => a.Name.ToLower().StartsWith("safeguard")).ToList().ForEach(a => a.Group = 3);
            MapKeys.Where(a => a.Name.ToLower().StartsWith("mayhem")).ToList().ForEach(a => a.Group = 4);



            folder = @"C:\CodeEnv\Xeaonsoft\CoH Stuff\coh-content-db-homecoming-master\src\badge";
            BadgesKeys = ReadKeys(folder);

            BadgesKeys.ForEach(a => a.Group = 9);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("arena")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("shadow")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("baumton")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("underground")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("praetorian")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("ouroboros")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("house")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("egg")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("master")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("lt")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("major")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("arms")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("urban")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("sprawl")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("snake")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("thrill")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("unethica")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("justice")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("vengeance")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("citadels")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("dimensional")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("city")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("circle")).ToList().ForEach(a => a.Group = 1);
            BadgesKeys.Where(a => a.Name.ToLower().StartsWith("theperfect")).ToList().ForEach(a => a.Group = 1);
            



        }
        public static List<FileKeyItem> ReadKeys(string folder)
        {



            List<FileKeyItem> keys = new List<FileKeyItem>();


            const string keyWord = "export const";

            string[] files = Directory.GetFiles(folder, "*.ts", SearchOption.AllDirectories);
            foreach (string file in files)
            {

                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (line.StartsWith(keyWord))
                    {
                        string lineText = line.Substring(keyWord.Length, line.Length - keyWord.Length).Trim();
                        string[] splitted = lineText.Split(':');
                        string key = splitted[0];

                        if (!keys.Exists(a => a.Name == key))
                            keys.Add(new FileKeyItem { Name = key });
                    }
                }
            }
            return keys;
        }
    }
}
