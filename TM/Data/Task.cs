using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Data
{
    class Task
    {
        public int id { get; set; }
        public String program_name { get; set; }
        public String project_name { get; set; }
        public String description { get; set; }
        public DateTime start_date { get; set; }
        public Boolean confirmed { get; set; }

    }
}
