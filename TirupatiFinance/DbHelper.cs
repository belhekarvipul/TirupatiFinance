using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TirupatiFinance
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            }
            catch (Exception ex)
            {
                Utility.log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
            }
            return new SqlConnection(connectionString);
        }

        public static object ExecuteSQL(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();

            command.CommandTimeout = 60;
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Utility.log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}
