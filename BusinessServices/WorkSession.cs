using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WorkSession
    {
        public int SessionID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TaskID { get; set; }


        public WorkSession()
        {
            SessionID = -1;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
            TaskID = -1;
        }


        // Operation
        public bool AddWorkSession()
        {
            this.SessionID = SessionsData.AddNewSession(this.TaskID, this.StartTime);

            return this.SessionID != -1;
        }
        public bool UpdateWorkSession(DateTime EndTime)
        {
            return SessionsData.UpdateSession(this.SessionID, EndTime);
        }

        // Get Times
        public static TimeSpan GetTimeForSession(int SessionID)
        {
            DateTime StartTime = DateTime.Now, EndTime = DateTime.Now;
            SessionsData.GetSession(SessionID, ref StartTime, ref EndTime);
            TimeSpan t = EndTime - StartTime;
            return t;
        }
        public static TimeSpan GetTotalTimeForTask(int TaskID)
        {
            TimeSpan totalTime = TimeSpan.Zero;
            DataTable dataTable = SessionsData.GetAllSessionsForTask(TaskID);

            foreach (DataRow Row in dataTable.Rows)
            {
                totalTime += GetTimeForSession((int)Row[0]);
            }

            return totalTime;
        }
        public static TimeSpan GetTotalTimeForProject(int ProjectID)
        {
            TimeSpan totalTime = TimeSpan.Zero;
            DataTable dataTable = SessionsData.GetAllSessionsForProject(ProjectID);

            foreach (DataRow Row in dataTable.Rows)
            {
                totalTime += GetTimeForSession((int)Row[0]);
            }

            return totalTime;
        }


    }
}
