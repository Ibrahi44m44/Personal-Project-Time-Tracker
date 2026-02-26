using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Time_Tracker
{
    public class clsProject
    {
        public int TotalTime;
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpectedTime { get; set; }
        public List<clsTask> Tasks { get; set; } = new List<clsTask>();

        public override string ToString()
        {
            return Name;
        }
    }
}
