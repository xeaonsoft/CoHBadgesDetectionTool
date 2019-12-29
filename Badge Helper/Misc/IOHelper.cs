using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper
{
    public class IOHelper
    {
        public static string RootPath
        {
            get
            {
                string directoryName = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
                return directoryName;
            }
        }
    }
}
