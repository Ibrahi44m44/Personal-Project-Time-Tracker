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
        public int TotalTime { get; set; } = 0;

        public clsTask(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
        public clsTask(string Name, string Description, int TotalTime)
        {
            this.Name = Name;
            this.Description = Description;
            this.TotalTime = TotalTime;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
