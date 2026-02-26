using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Time_Tracker
{
    public class clsTask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalTime { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
