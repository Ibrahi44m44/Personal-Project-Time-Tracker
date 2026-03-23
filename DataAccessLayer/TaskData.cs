using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public class TaskData
    {
        static public bool GetTaskData(int ID, ref string Name, ref string Description
           , ref int TotalTime, ref int StatusId, ref int ProjectID)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from Tasks Where TaskId = @TasksId";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TasksID", ID);
            bool IsFound = false;
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    Name = (string)Reader["Name"];
                    TotalTime = (int)Reader["TotalTime"];
                    ProjectID = (int)Reader["PRojectID"];
                    StatusId = (int)Reader["StatusId"];
                    if (Reader["Description"] != DBNull.Value)
                    {
                        Description = (string)Reader["Description"];
                    }
                    else
                        Description = string.Empty;


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
        static public bool GetTaskData(string Name, ref int ID, ref string Descrition
            , ref int TotalTime, ref int ProjectID, ref int StatusId)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from Tasks Where Name = @TaskName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TaskName", Name);
            bool IsFound = false;
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["TaskID"];
                    TotalTime = (int)Reader["TotalTime"];
                    StatusId = (int)Reader["StatusId"];
                    ProjectID = (int)Reader["ProjectID"];
                    if (Reader["Description"] != DBNull.Value)
                    {
                        Descrition = (string)Reader["Description"];
                    }
                    else
                        Descrition = string.Empty;

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
        public static DataTable GetAllTasksForProject(int ProjectID)
        {
            DataTable Datatable = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * From Tasks Where ProjectID = @ProjectID";
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
        public static DataTable GetAllTasks()
        {
            DataTable Datatable = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * From Tasks ";
            SqlCommand Command = new SqlCommand(Query, Connection);

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
        static public int AddNewTasks(string Name, string Description, int ProjectID)
        {
            int IDForNewTasks = -1;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "INSERT INTO [dbo].[Tasks] ( [Name] , [Description] , [TotalTime] , [StatusID] , [ProjectID] )" +
                "VALUES (@TaskName , @Description,@TotalTime ,@StatusID , @ProjectID)" +
                " select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TaskName", Name);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@TotalTime", 0);
            Command.Parameters.AddWithValue("@StatusID", 1);
            Command.Parameters.AddWithValue("@ProjectID", ProjectID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                {
                    IDForNewTasks = NewID;
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

            return IDForNewTasks;
        }

        static public bool UpdateTask(int ID, string Name, string Description, int StatusID)
        {

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[Tasks]   SET [Name] = @Name ,[Description] = @Description " +
                ",[StatusID] = @StatusID  WHERE TaskID = @TaskID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TaskID", ID);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@StatusID", StatusID);

            if (!string.IsNullOrEmpty(Description))
            {
                Command.Parameters.AddWithValue("@Description", Description);
            }
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

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
        static public bool UpdateTask(int ID, string Name, string Description)
        {

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[Tasks]   SET [Name] = @Name ,[Description] = @Description " +
                "  WHERE TaskID = @TasksID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TasksID", ID);
            Command.Parameters.AddWithValue("@Name", Name);
            if (!string.IsNullOrEmpty(Description))
            {
                Command.Parameters.AddWithValue("@Description", Description);
            }
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

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
        static public bool UpdateTaskTotalTime(int ID, int TotalTime)
        {

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[Tasks]   SET [TotalTime] = @TotalTime WHERE TasksID = @TasksID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TasksID", ID);
            Command.Parameters.AddWithValue("@TotalTime", TotalTime);

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
        static public bool DeleteTasks(int ID)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "DELETE FROM WorkSessions WHERE TaskID = @TaskID;" +
                "  DELETE FROM Tasks WHERE TaskID = @TaskID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TaskID", ID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;

        }
    }
}
