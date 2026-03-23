using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class StatusData
    {
        public static DataTable GetAllStatus()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * From Statuses";
            SqlCommand cmd = new SqlCommand(Query, connection);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
