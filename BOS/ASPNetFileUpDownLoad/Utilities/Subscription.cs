using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ASPNetFileUpDownLoad.Utilities
{
    public class Subscription
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["DBConnectionString"];
        }

        private static void OpenConnection(SqlConnection connection)
        {
            connection.ConnectionString = GetConnectionString();
            connection.Open();
        }

        public static int GetAccountID(string username)
        {
            int ID = 0;

            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select ID From Account Where UserName=@username";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = username;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        connection.Close();
                        ID = int.Parse(reader["ID"].ToString());
                        return ID;
                    }
                }
               
            }
        }

        public static void Subscript3KW6M(string Username, string keyword1, string keyword2, string keyword3, string ContracttypeID, string Period, string sDate, string eDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("dd-M-yyyy");

                string commandText = "INSERT INTO Subscription VALUES(@AccountID, @KW1, ";
                commandText = commandText + "@KW2, @KW3, @KW4, @KW5, @KW6, @KW7, @KW8, @KW9, @KW10, @KWChange, @LastUpdate, @ContractTypeID, @Period, @StartDate, @EndDate)";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;
                                             
                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW1", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW2", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW3", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW4", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW5", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW6", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW7", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW8", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW9", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW10", SqlDbType.VarChar);
                cmd.Parameters.Add("@KWChange", SqlDbType.VarChar);
                cmd.Parameters.Add("@LastUpdate", SqlDbType.VarChar);
                cmd.Parameters.Add("@ContractTypeID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Period", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);

                cmd.Parameters["@Name"].Value = name;
                cmd.Parameters["@ContentType"].Value = contentType;
                cmd.Parameters["@size"].Value = size;
                cmd.Parameters["@Data"].Value = data;
                cmd.Parameters["@Date"].Value = sqlFormattedDate;
                cmd.Parameters["@User"].Value = user;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}