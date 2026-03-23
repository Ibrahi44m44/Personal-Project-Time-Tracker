using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static DataTable GetAllStatus()
        {
            return StatusData.GetAllStatus();
        }
        public static string GetStatusString(int StatusID)
        {
            switch (StatusID)
            {
                case 1:
                    return "Pending ";
                case 2:
                    return "InProgress ";
                case 3:
                    return "Complete";
                default:
                    return "";

            }
        }
        public static int GetStatusID(string StatusName)
        {
            switch (StatusName)
            {
                case "Pending ":
                    return 1;
                case "InProgress ":
                    return 2;
                case "Complete":
                    return 3;
                default:
                    return 1;

            }
        }


    }
}
