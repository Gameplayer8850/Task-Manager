using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Data
{
    public class Global_Data
    {
        public static String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TM";
        public static String file_name = "TM_data.xml";
        public enum Mode {
            Active, Finished, Confirmed, All
        }
        public enum FormType {
            New, Edit
        }
    }
}
