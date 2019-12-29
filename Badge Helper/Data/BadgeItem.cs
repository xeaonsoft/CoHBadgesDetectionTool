using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Badge_Helper
{
    public class RawBadgeItem
    {



        public string Group { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }

    }
    public class BadgeItem
    {

        public string Name { get; set; }
        public bool Selected { get; set; }

    }

    public class BadgeManager
    {
        public static List<BadgeItem> List = new List<BadgeItem>();



        public static void Add(BadgeItem b)
        {
            b.Name = b.Name.Trim();
            if (!BadgeManager.List.Exists(a => a.Name == b.Name))
                BadgeManager.List.Add(b);
        }

        public static void Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                BadgeManager.List = JsonConvert.DeserializeObject<List<BadgeItem>>(jsonContent);
            }
            else
            {
                BadgeManager.List = new List<BadgeItem>();
            }

        }


        public static void Save()
        {
            PurgeIgnored();
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(BadgeManager.List, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }

        private static void PurgeIgnored()
        {

            List<string> toIgnoreList = new List<string>();
            DetectConfig.Instance.BadgesToIgnore.Split('|').Where(a => !string.IsNullOrEmpty(a)).ToList().ForEach(a => toIgnoreList.Add(a.Trim().ToLower()));

            BadgeManager.List = BadgeManager.List.Where(a => !toIgnoreList.Contains(a.Name.Trim().ToLower())).ToList();
            //DetectConfig
        }

        private static string GetFileName()
        {
            string directoryName = IOHelper.RootPath; //new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
            return Path.Combine(directoryName, "SaveFile.json");
        }



        public static void DetermineIfSelected(RawBadgeItem bi)
        {
            bi.Selected = false;

            var parts = bi.Name.Split('/');
            List<string> matchs = new List<string>();
            parts.ToList().ForEach(a => matchs.Add(a.Trim().ToLowerInvariant()));


            var f = BadgeManager.List.SingleOrDefault(a => matchs.Contains(a.Name.Trim().ToLowerInvariant()));
            if (f != null && f.Selected)
            {
                bi.Selected = true;
            }
        }

        public static List<RawBadgeItem> DetermineIfSelected(List<RawBadgeItem> badges, BadgeItem bi)
        {

            List<RawBadgeItem> foundList = new List<RawBadgeItem>();

            foreach (RawBadgeItem rbi in badges)
            {
                var parts = rbi.Name.Split('/');
                List<string> matchs = new List<string>();
                parts.ToList().ForEach(a => matchs.Add(a.Trim().ToLowerInvariant()));

                if (matchs.Contains(bi.Name.Trim().ToLowerInvariant()))
                {
                    foundList.Add(rbi);
                }
            }

            return foundList;
        }
    }


}
