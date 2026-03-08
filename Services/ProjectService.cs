using Personal_Project_Time_Tracker.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Time_Tracker
{
    public static class ProjectService
    {
        public static List<clsProject> ProjectsList { get; set; } = new List<clsProject>();

        public static void LoadData()
        {
            ProjectService.ProjectsList = ProjectData.LoadProjects();
        }
        public static bool IsInputInvalid(string text)
        {
            return string.IsNullOrWhiteSpace(text) || text.Contains("#") || text.Contains(":");
        }

        public static void SaveData(bool Delete = false)
        {
            if (Delete)
            {
                ProjectsList.RemoveAll(p => p.MarkForDelete); // Linq 
            }

            ProjectData.SaveDataToFile(ProjectsList);
        }

        public static clsProject GetProjectByID(int ID)
        {
            foreach (clsProject project in ProjectsList)
            {
                if (project.ID == ID)
                {
                    return project;
                }
            }
            return null;
        }

        public static void GetProjectDataByID(int ID, out string Name, out string Description, out int ExpectedTime)
        {
            Name = "";
            Description = "";
            ExpectedTime = 0;

            clsProject project = GetProjectByID(ID);

            if (project != null)
            {
                Name = project.Name;
                Description = project.Description;
                ExpectedTime = project.ExpectedTime;
            }

            return;
        }


        public static bool UpdateProject(int ID, string name, string desc, int time)
        {

            clsProject project = GetProjectByID(ID);

            if (project != null)
            {
                project.Name = name;
                project.Description = desc;
                project.ExpectedTime = time;
                SaveData();
                return true;
            }
            return false;
        }
        public static int GetNextProjectID()
        {
            int maxID = 0;

            foreach (clsProject project in ProjectsList)
            {
                if (project.ID > maxID)
                {
                    maxID = project.ID;
                }
            }

            return maxID + 1;
        }
        public static void AddNewProject(clsProject project)
        {
            ProjectsList.Add(project);
            SaveData();
        }
        public static void AddNewTaskToProject(int ID, clsTask task)
        {
            clsProject project = GetProjectByID(ID);
            if (project != null)
                project.TasksList.Add(task);
            SaveData();
        }
        public static void UpdateTaskTime(clsTask Task, DateTime StartTime, DateTime EndTime)
        {
            TimeSpan Duration = EndTime - StartTime;
            int SecondsWorked = (int)Duration.TotalSeconds;

            Task.TotalTime += SecondsWorked;

            SaveData();

        }

        public static int GetProjectRemainingTime(int ID)
        {
            clsProject project = GetProjectByID(ID);

            if (project == null) return 0;

            int totalTaskSeconds = 0;
            int expectedSeconds = 0;

            foreach (clsTask t in project.TasksList)
                totalTaskSeconds += t.TotalTime;

            expectedSeconds = project.ExpectedTime;


            return expectedSeconds - totalTaskSeconds;
        }

        public static bool IsProjectOverdue(int ID)
        {
            return GetProjectRemainingTime(ID) <= 0;
        }

        public static string FormatSecondsToTime(int totalSeconds)
        {
            bool isNegative = totalSeconds < 0;

            TimeSpan t = TimeSpan.FromSeconds(Math.Abs(totalSeconds));

            string timeStr = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)t.TotalHours, t.Minutes, t.Seconds) + "Reminding";

            return isNegative ? "- " + timeStr : timeStr;
        }

        public static void DeleteProject(int ID)
        {
            clsProject project = GetProjectByID(ID);

            if (project != null)
            {
                project.MarkForDelete = true;
                SaveData(true);
            }
        }

        public static string GetNameById(int ID)
        {
            clsProject project = GetProjectByID(ID);

            if (project != null)
            {
                return project.Name;
            }
            return "";
        }

        public static List<clsTask> GetList(int ID)
        {
            clsProject project = GetProjectByID(ID);

            if (project != null)
            {
                return project.TasksList;
            }
            return null;
        }
    }
}
