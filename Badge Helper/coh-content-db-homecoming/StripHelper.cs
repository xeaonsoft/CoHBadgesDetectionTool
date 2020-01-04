using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{
    public class StripHelper
    {
        public static string Strip(string input)
        {
            FileKeys.Init();

            string text = input;

            foreach (JsonImportReplace jri in JsonImportReplace.Instance)
            {
                text = text.Replace(jri.Key, "\"" + jri.Text + "\"");
            }

            text = FixDescriptions(text);

            text = StripEnum<BadgeType>(text);
            text = StripEnum<BadgePartialType>(text);
            text = StripEnum<PlaqueType>(text);
            text = StripEnum<EnhancementCategory>(text);
            text = StripEnum<Alternate>(text);
            




            //FileKeys
            foreach (FileKeyItem mapKey in FileKeys.MapKeys.OrderBy(a => a.Group))
            {
                text = text.Replace("${" + mapKey.Name + ".key}",  mapKey.Name + ".__key");
            }

            foreach (FileKeyItem mapKey in FileKeys.MapKeys.OrderBy(a => a.Group))
            {
                text = text.Replace($"{mapKey.Name}.key", "\"" + mapKey.Name + "\"");
            }
            
            
            foreach (FileKeyItem badgeKey in FileKeys.BadgesKeys.OrderBy(a => a.Group))
            {
                text = text.Replace($"{badgeKey.Name}.key", "\"" + badgeKey.Name + "\"");
            }


            //text = text.Replace("`", "\"");
            text = text.Replace("'", "|");
            text = text.Replace("`", "'");

           // text = StripPartials(text);

            return text;

        }

        //private static string StripPartials(string input)
        //{
        //    //partials: [
        //    string text = input;

        //    const string keyWord = "partials: [";
        //    int pos = text.IndexOf(keyWord);
        //    if (pos > 0)
        //    {
        //        string left = text.Substring(0, pos);
        //        string right = text.Substring(pos, text.Length - pos);
        //        int posEnd = right.IndexOf("]");
        //        right = right.Substring(posEnd + 1, right.Length - posEnd - 1);
        //        text = left + right;
        //    }

        //    return text;
        //}

        private static string FixDescriptions(string input)
        {
            string text = input;

            bool hadSomethingToFix = true;

            while (hadSomethingToFix)
            {
                hadSomethingToFix = false;

                StringBuilder sb = new StringBuilder();

                string[] lines = text.Split('\n');

                //foreach(string line in lines)
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    line = line.Trim();

                    if (line.EndsWith("\" +"))
                    {
                        line = line.Substring(0, line.Length - 3);

                        string nextLine = lines[i + 1];
                        nextLine = nextLine.Trim().TrimStart('\"');
                        line = line + nextLine;
                        i++;
                        hadSomethingToFix = true;
                    }
                    sb.AppendLine(line);
                }

                text = sb.ToString();
            }

            return text;
        }


        public static string StripEnum<T>(string input)
        {
            string name = typeof(T).Name;
            string text = input;
            var values = Enum.GetValues(typeof(T)).Cast<T>();

            foreach (T v in values)
            {
                string textV = $"{name}.{v}";
                string intV = $"{Convert.ToInt32(v)}";
                text = text.Replace(textV, intV);
            }
            return text;
        }


    }
}
