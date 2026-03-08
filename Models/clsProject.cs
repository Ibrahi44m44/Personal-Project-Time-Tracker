using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Time_Tracker
{
    public class clsProject
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpectedTime { get; set; }

        public bool MarkForDelete { get; set; } = false;

        public List<clsTask> TasksList { get; set; } = new List<clsTask>();


        public clsProject(int ID, string Name, string Description, int ExpectedTime)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.ExpectedTime = ExpectedTime;
        }



    }
}
