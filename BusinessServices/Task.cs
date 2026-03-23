using BusinessServices;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalTime { get; set; }
        public int ProjectID { get; set; }
        public int StatusID { get; set; }
        enum enMode
        {
            AddMode = 1,
            UpdateMode = 2
        }

        enMode _Mode { get; set; }
        public Task()
        {
            Id = -1;
            Name = string.Empty;
            Description = string.Empty;
            TotalTime = 0;
            ProjectID = -1;
            StatusID = 1;
            _Mode = enMode.AddMode;
        }

        private Task(int ID, string Name, string Desc, int TotalTime, int ProjectId, int StatusID)
        {
            this.Id = ID;
            this.Name = Name;
            this.TotalTime = TotalTime;
            this.Description = Desc;
            this.ProjectID = ProjectId;
            this.StatusID = StatusID;
            this._Mode = enMode.UpdateMode;
        }

        public bool GetTask(int ID, ref string Name, ref string desc, ref int TotalTime, ref int ProjectID, ref int StatusID)
        {
            return TaskData.GetTaskData(ID, ref Name, ref desc, ref TotalTime, ref ProjectID, ref StatusID);
        }

        public bool _AddNewTask()
        {

            this.Id = TaskData.AddNewTasks(this.Name, this.Description, this.ProjectID);

            return this.Id != -1;

        }
        private bool _UpdateTaskData()
        {
            return TaskData.UpdateTask(this.Id, this.Name, this.Description, this.StatusID);

        }
        public static Task Find(int ID)
        {

            string Name = "", Desc = "";
            int TotalTime = 0, ProjectID = -1, StatusID = 1;
            if (TaskData.GetTaskData(ID, ref Name, ref Desc, ref TotalTime, ref ProjectID, ref StatusID))
                return new Task(ID, Name, Desc, TotalTime, ProjectID, StatusID);
            else
                return null;
        }
        public static Task Find(string Name)
        {
            string Desc = "";
            int TotalTime = 0, ProjectID = -1, StatusID = 1, ID = -1;
            if (TaskData.GetTaskData(Name, ref ID, ref Desc, ref TotalTime, ref ProjectID, ref StatusID))
                return new Task(ID, Name, Desc, TotalTime, ProjectID, StatusID);
            else
                return null;
        }
        static public bool DeleteTask(int ID)
        {
            return TaskData.DeleteTasks(ID);
        }
        public static DataTable GetAllTasks()
        {
            DataTable dataTable = TaskData.GetAllTasks();
            if (dataTable.Rows.Count > 0)
            {
                dataTable.Columns.Add("ProjectName", typeof(string));
                dataTable.Columns.Add("StatusName", typeof(string));

                foreach (DataRow row in dataTable.Rows)
                {
                    int.TryParse(row[4].ToString(), out int ProjectID);
                    int.TryParse(row[5].ToString(), out int StatusID);

                    row[6] = ProjectData.GetProjectName(ProjectID);
                    row[7] = Status.GetStatusString(StatusID);
                }
                dataTable.Columns.Remove("StatusID");

            }
            return dataTable;
        }
        public static DataTable GetAllTasksForProject(int ProjectID)
        {
            DataTable dataTable = TaskData.GetAllTasksForProject(ProjectID);
            if (dataTable.Rows.Count > 0)
            {
                dataTable.Columns.Add("ProjectName", typeof(string));
                dataTable.Columns.Add("StatusName", typeof(string));

                foreach (DataRow row in dataTable.Rows)
                {
                    int.TryParse(row[5].ToString(), out int StatusID);
                    row[6] = ProjectData.GetProjectName(ProjectID);
                    row[7] = Status.GetStatusString(StatusID);
                }
                dataTable.Columns.Remove("StatusID");

            }
            return dataTable;
        }
        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewTask())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:

                    return _UpdateTaskData();
            }

            return false;
        }
        public int ConvertTimeToSecound(int Hours, int Minutes)
        {
            return (Hours * 3600) + (Minutes * 60);
        }

    }
}
