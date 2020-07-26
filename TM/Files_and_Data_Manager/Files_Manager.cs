using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TM.Data;

namespace TM.Files_and_Data_Manager
{
    class Files_Manager
    {
        public Boolean File_Exist()
        {
            Directory.CreateDirectory(Global_Data.path);
            return File.Exists(Global_Data.path + @"\"+ Global_Data.file_name);
        }
        public List<Data.Task> File_Read() {
            List<Data.Task> tasks=new List<Data.Task>();
            try
            {
                using (var stream = new FileStream(Global_Data.path + @"\" + Global_Data.file_name, FileMode.Open))
                {
                    var XML = new XmlSerializer(typeof(List<Data.Task>));
                    tasks = (List<Data.Task>)XML.Deserialize(stream);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Błąd");
                tasks= new List<Data.Task>();
                return tasks;
            }
            return tasks;
        }
        public void File_Save(List<Data.Task> tasks) {
            using (var stream = new FileStream(Global_Data.path + @"\" + Global_Data.file_name, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Data.Task>));
                XML.Serialize(stream, tasks);
            }
        }

    }
}
