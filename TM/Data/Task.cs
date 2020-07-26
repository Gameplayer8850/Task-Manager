using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Data
{
    public class Task
    {
        public int id { get; set; }
        public String program_name { get; set; }
        public String project_name { get; set; }
        public String description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public DateTime commissioned_date { get; set; }
        public DateTime deadline_date { get; set; }
        public Boolean confirmed { get; set; }

    }
}
