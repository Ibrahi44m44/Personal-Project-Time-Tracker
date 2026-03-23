using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    static public class ProjectData
    {
        // Colums  Name Descriptiom(O) TotalTimeExpected ActualTotalTime(O)

        static public bool GetProjectData(int ID, ref string ProjectName, ref string ProjectDescrition
            , ref int TotalTimeExpected, ref int ActualTime)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from Projects Where ProjectID = @ProjectId";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProjectId", ID);
            bool IsFound = false;
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ProjectName = (string)Reader["Name"];
                    TotalTimeExpected = (int)Reader["TotalTimeExpected"];
                    if (Reader["Description"] != DBNull.Value)
                    {
                        ProjectDescrition = (string)Reader["Description"];
                    }
                    else
                        ProjectDescrition = string.Empty;
                    if (Reader["ActualTime"] != DBNull.Value)
                    {
                        ActualTime = (int)Reader["ActualTime"];

                    }
                    else
                        ActualTime = 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public bool GetProjectData(string ProjectName, ref int ID, ref string ProjectDescrition
            , ref int TotalTimeExpected, ref int ActualTime)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from Projects Where Name = @ProjectName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProjectName", ProjectName);
            bool IsFound = false;
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ProjectID"];
                    TotalTimeExpected = (int)Reader["TotalTimeExpected"];
                    if (Reader["Description"] != DBNull.Value)
                    {
                        ProjectDescrition = (string)Reader["Description"];
                    }
                    else
                        ProjectDescrition = string.Empty;
                    if (Reader["ActualTime"] != DBNull.Value)
                    {
                        ActualTime = (int)Reader["ActualTime"];

                    }
                    else
                        ActualTime = 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public int AddNewProject(string Name, string Description, int TotalTime)
        {
            int IDForNewProject = -1;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "INSERT INTO [dbo].[Projects] ([Name] ,[Description] ,[TotalTimeExpected] )" +
                " VALUES (@Name , @Description,@TotalTime );" +
                " select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            if (!string.IsNullOrEmpty(Description))
            {
                Command.Parameters.AddWithValue("@Description", Description);
            }
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);
            Command.Parameters.AddWithValue("@TotalTime", TotalTime);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                {
                    IDForNewProject = NewID;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return IDForNewProject;
        }
        static public bool UpdateProject(int ID, string Name, string Description, int TotalTime, int ActualTime)
        {

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "UPDATE [dbo].[Projects]   SET [Name] = @Name ,[Description] = @Description " +
                ",[TotalTimeExpected] = @TotalTime , ActualTime = @ActualTime" +
                " WHERE ProjectID = @ProjectID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@ProjectID", ID);
            if (!string.IsNullOrEmpty(Description))
            {
                Command.Parameters.AddWithValue("@Description", Description);
            }
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);
            if (ActualTime > 0)
            {
                Command.Parameters.AddWithValue("@ActualTime", ActualTime);
            }
            else
                Command.Parameters.AddWithValue("@ActualTime", DBNull.Value);
            Command.Parameters.AddWithValue("@TotalTime", TotalTime);
            int RowAffected = 0;
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();

            }
            return RowAffected > 0;
        }

        static public bool DeleteProject(int ID)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            //DataTable dataTable = TaskData.GetAllTasksForProject(ID);
            //foreach (DataRow Row in dataTable.Rows)
            //{
            //    TaskData.DeleteTasks((int)Row["TaskID"]);
            //}
            //string Query = "Delete Projects Where ProjectID = @ProjectID";

            string Query = "Delete From WorkSessions Where TaskID IN (SELECT TaskID FROM Tasks WHERE ProjectID = @ProjectID);" +
                "Delete From Tasks Where ProjectID = @ProjectID;" +
                "Delete From Projects Where ProjectID = @ProjectID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ProjectID", ID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;

        }
        static public DataTable GetAllProjects()
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * From Projects order by Name";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ProjectDataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    ProjectDataTable.Load(Reader);
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

            return ProjectDataTable;
        }
        static public string GetProjectName(int ID)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select Name from Projects Where ProjectID = @ProjectId";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProjectId", ID);
            string Name = "";
            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    Name = Result.ToString();
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
            return Name;
        }
    }
}