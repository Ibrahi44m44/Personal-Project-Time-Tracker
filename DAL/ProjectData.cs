using System;
using System.Collections.Generic;
using System.IO;

namespace Personal_Project_Time_Tracker.DAL
{
    public static class ProjectData
    {
        private const string FilePath = "Projects.txt";

        public static void SaveDataToFile(List<clsProject> projects)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                foreach (clsProject project in projects)
                {
                    writer.WriteLine($"P#:#{project.ID}#:#{project.Name}#:#{project.Description}#:#{project.ExpectedTime}");

                    foreach (clsTask task in project.TasksList)
                    {
                        writer.WriteLine($"T#:#{task.Name}#:#{task.Description}#:#{task.TotalTime}");
                    }
                }
            }
        }

        public static List<clsProject> LoadProjects()
        {
            List<clsProject> projects = new List<clsProject>();

            if (!File.Exists(FilePath))
                return projects;

            clsProject currentProject = null;

            foreach (string line in File.ReadAllLines(FilePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(new[] { "#:#" }, StringSplitOptions.None);

                if (parts[0] == "P")
                {
                    currentProject = new clsProject(int.Parse(parts[1]), parts[2], parts[3], int.Parse(parts[4]));

                    projects.Add(currentProject);
                }
                else if (parts[0] == "T" && currentProject != null)
                {
                    currentProject.TasksList.Add(new clsTask(parts[1], parts[2], int.Parse(parts[3])));
                }
            }

            return projects;
        }
    }
}