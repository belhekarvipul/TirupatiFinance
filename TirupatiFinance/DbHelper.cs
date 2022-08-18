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
                Utility.LogError(ex);
            }
            return new SqlConnection(connectionString);
        }

        public static SqlCommand GetCommand(SqlConnection connection, string query) {
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = 60;
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            return command;
        }

        public static object ExecuteInsert(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = GetCommand(connection, query);

            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public static object ExecuteUpdate(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = GetCommand(connection, query);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public static DataTable ExecuteSelect(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = GetCommand(connection, query);
            DataTable dataTable = new DataTable();         

            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
