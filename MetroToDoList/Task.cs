using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroToDoList
{
    public class Task
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public string Status { get; set; }
    }
}
