using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Data
{
    class Global_Data
    {
        public static String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TM";
        public static String file_name = "TM_data.xml";
        public static Boolean file_exist;
    }
}
