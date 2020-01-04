using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{

    public class ImportData
    {
        public string category { get; set; }

        public BadgeType type { get; set; }
        public int setTitleId { get; set; }


        public List<NameEntry> names { get; set; }


        public string GetNames()
        {
            List<string> list = new List<string>();
            names.ForEach(a => list.Add(a.value.Replace("|", "'")));
            return string.Join(" / ", list);
        }
    }

    public class NameEntry
    {
        public Alternate type { get; set; }
        public string value { get; set; }
    }

}
