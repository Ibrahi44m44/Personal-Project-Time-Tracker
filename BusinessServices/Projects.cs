using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalTime { get; set; }
        public int ActualTime { get; set; }
        enum enMode
        {
            AddMode = 1,
            UpdateMode = 2
        }

        enMode _Mode { get; set; }

        public Projects()
        {
            Id = -1;
            Name = string.Empty;
            Description = string.Empty;
            _Mode = enMode.AddMode;
        }
        private Projects(int ID, string Name, string Desc, int TotalTime, int ActualTime)
        {
            this.Id = ID;
            this.Name = Name;
            this.Description = Desc;
            this.TotalTime = TotalTime;
            this.ActualTime = ActualTime;
            this._Mode = enMode.UpdateMode;
        }


        private bool _AddNewPorject()
        {

            this.Id = ProjectData.AddNewProject(this.Name, this.Description, this.TotalTime);

            return this.Id != -1;

        }
        private bool _UpdateProjectData()
        {
            return ProjectData.UpdateProject(this.Id, this.Name, this.Description, this.TotalTime, this.ActualTime);
        }
        public static Projects Find(int ID)
        {
            string Name = "", Desc = "";
            int TotalTime = 0, ActualTime = 0;
            if (ProjectData.GetProjectData(ID, ref Name, ref Desc, ref TotalTime, ref ActualTime))
                return new Projects(ID, Name, Desc, TotalTime, ActualTime);
            else
                return null;
        }
        public static Projects Find(string Name)
        {
            string Desc = "";
            int TotalTime = 0, ActualTime = 0, ID = -1;
            if (ProjectData.GetProjectData(Name, ref ID, ref Desc, ref TotalTime, ref ActualTime))
                return new Projects(ID, Name, Desc, TotalTime, ActualTime);
            else
                return null;
        }
        static public bool DeleteProject(int ID)
        {
            return ProjectData.DeleteProject(ID);
        }
        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewPorject())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:

                    return _UpdateProjectData();
            }

            return false;
        }

        public static DataTable GetAllProjects()
        {
            return ProjectData.GetAllProjects();
        }
        public static string GetTimeString(int Time)
        {
            TimeSpan ts = TimeSpan.FromSeconds(Time);
            return ts.Hours + " H " + ts.Minutes + " M ";
        }
        public bool CheckOverDue()
        {
            TimeSpan Time = WorkSession.GetTotalTimeForProject(this.Id);
            int TotalSecound = (int)Time.TotalSeconds;
            if (TotalSecound > this.TotalTime)
                return true;
            return false;
        }
        public static int ConvertTimeToSecound(int Hours, int Minutes)
        {
            return (Hours * 3600) + (Minutes * 60);
        }
    }
}
