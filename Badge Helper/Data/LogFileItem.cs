using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class LogFileItem
    {
        public static List<LogFileItem> List = new List<LogFileItem>();
        public string PlayerName { get; set; }
        public string File { get; set; }
    }
}
