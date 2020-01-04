using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class RawDataItem
    {
        public string Name { get; set; }
        public List<RawBadgeItem> Badges = new List<RawBadgeItem>();

        
    }
}
