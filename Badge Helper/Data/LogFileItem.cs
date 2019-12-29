using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class LogFileItem
    {
        public static List<LogFileItem> List = new List<LogFileItem>();
        public string GlobalName { get; set; }
        public string LocalName { get; set; }
        public string File { get; set; }

        public DateTime StartDate { get; set; }

        public string CombinedName
        {
            get
            {
                return $"{this.GlobalName} / {this.LocalName}";
            }
        }

        public void FetchData()
        {
            /*
                Now entering the Rogue Isles, Nikma!
                Welcome to City of Heroes, Cold-Trust!
                Using global chat handle @xeaon
             */
            const string logInRed = "Now entering the Rogue Isles,";
            const string logInBlue = "Welcome to City of Heroes,";

            string[] lines;
            string path = this.File;
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();
                lines = content.Split('\r');
            }

            //read lines in reverse
            for(int i= lines.Length-1; i >= 0; i--)
            {
                string line = lines[i].Trim();
                if (line.Length > 20)
                {
                    string date = line.Substring(0, 20).Trim();
                    line = line.Substring(20, line.Length - 20);
                    if (line.Trim().StartsWith(logInRed) || line.Trim().StartsWith(logInBlue))
                    {

                        string name = line.Replace(logInRed, string.Empty).Replace(logInBlue, string.Empty);
                        this.LocalName = name.Substring(0, name.Length-1);//trim last char ("!")
                        this.StartDate = DateTime.Parse(date);
                        break;
                    }
                }
            }
        }
    }
}
