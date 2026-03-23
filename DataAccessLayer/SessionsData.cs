using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public class SessionsData
    {
        public static bool GetSession(int SessionID, ref DateTime StartTime, ref DateTime EndTime)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from WorkSessions Where SessionID = @SessionID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@SessionID", SessionID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    StartTime = (DateTime)Reader["StartTime"];
                    if (Reader["EndTime"] != DBNull.Value)
                        EndTime = (DateTime)Reader["EndTime"];
                    else
                        EndTime = new DateTime();
                }
            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;

        }
        public static int AddNewSession(int TaskID, DateTime StartTime)
        {
            int IDForNewSession = -1;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "INSERT INTO WorkSessions ( [StartTime] , [TaskID]  )" +
                "VALUES (@StartTime , @TaskID)" +
                " select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartTime", StartTime);
            Command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                {
                    IDForNewSession = NewID;
                }

            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return IDForNewSession;
        }


        public static DataTable GetAllSessionsForTask(int TaskId)
        {
            DataTable Datatable = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * From WorkSessions Where TaskID = @TaskId And EndTime is Not NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TaskId", TaskId);
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)

                {
                    Datatable.Load(Reader);
                }

            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return Datatable;
        }
        public static bool UpdateSession(int ID, DateTime EndTime)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[WorkSessions] SET [EndTime] = @EndTime  WHERE SessionID = @SessionID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@SessionID", ID);
            Command.Parameters.AddWithValue("@EndTime", EndTime);
            int RowAffected = 0;
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return RowAffected > 0;
        }

        public static DataTable GetAllSessionsForProject(int ProjectID)
        {
            DataTable Datatable = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "select * From WorkSessions " +
                "Where TaskID in (Select TaskID From Tasks Where ProjectID = @ProjectID And EndTime is not null)";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProjectID", ProjectID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)

                {
                    Datatable.Load(Reader);
                }

            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return Datatable;
        }

    }
}
