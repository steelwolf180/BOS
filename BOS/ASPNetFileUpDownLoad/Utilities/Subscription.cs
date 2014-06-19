using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ASPNetFileUpDownLoad.Utilities
{
    public class Subscription
    {
        #region Database Connection
        private static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["DBConnectionString"];
        }

        private static void OpenConnection(SqlConnection connection)
        {
            connection.ConnectionString = GetConnectionString();
            connection.Open();
        }

        #endregion

        #region Account Details
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
                        ID = int.Parse(reader["ID"].ToString());
                    }
                }
                connection.Close();
                return ID;

            }
        }

        public static string GetAccountEmail(int AccountID)
        {
            string Email = "";

            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select Email From Account Where ID=@id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = AccountID;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Email = reader["Email"].ToString();
                    }
                }
                connection.Close();
                return Email;

            }
        }

        #endregion

        #region Subscription Details

        public static int GetSubscriptionID(int AccountID)
        {
            int SubID = 0;

            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select ID From Subscription Where AccountID=@accountID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@accountID", SqlDbType.Int);
                cmd.Parameters["@accountID"].Value = AccountID;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        SubID = int.Parse(reader["ID"].ToString());
                    }
                }
                connection.Close();
                return SubID;

            }
        }

        public static DataTable GetSubscription()
        {
            DataTable UserSub = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText = "SELECT * From Subscription", connection);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(UserSub);

                connection.Close();
            }

            return UserSub;
        }

        public static void DeleteSubscription(Int16 id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Delete From Subscription Where ID=@id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id", SqlDbType.SmallInt);
                cmd.Parameters["@id"].Value = id;

                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        #endregion

        #region Subscribe
        public static void Subscription3KW(int ID, string keyword1, string keyword2, string keyword3, int ContracttypeID, int Period, string sDate, string eDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                string commandText = "INSERT INTO Subscription (AccountID,KW1,KW2,KW3,KWChange,LastUpdate,ContractTypeID,Period,StartDate,EndDate) VALUES(@AccountID, @KW1, ";
                commandText = commandText + "@KW2, @KW3, @KWChange, @LastUpdate, @ContractTypeID, @Period, @StartDate, @EndDate)";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;
                                             
                cmd.Parameters.Add("@AccountID", SqlDbType.Int);
                cmd.Parameters.Add("@KW1", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW2", SqlDbType.VarChar);
                cmd.Parameters.Add("@KW3", SqlDbType.VarChar);
                cmd.Parameters.Add("@KWChange", SqlDbType.VarChar);
                cmd.Parameters.Add("@LastUpdate", SqlDbType.VarChar);
                cmd.Parameters.Add("@ContractTypeID", SqlDbType.Int);
                cmd.Parameters.Add("@Period", SqlDbType.Int);
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);

                cmd.Parameters["@AccountID"].Value = ID;
                cmd.Parameters["@KW1"].Value = keyword1;
                cmd.Parameters["@KW2"].Value = keyword2;
                cmd.Parameters["@KW3"].Value = keyword3;
                cmd.Parameters["@KWChange"].Value = 3;
                cmd.Parameters["@LastUpdate"].Value = DateTime.Today.ToShortDateString();
                cmd.Parameters["@ContractTypeID"].Value = ContracttypeID;
                cmd.Parameters["@Period"].Value = Period;
                cmd.Parameters["@StartDate"].Value = sDate;
                cmd.Parameters["@EndDate"].Value = eDate;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    
        public static void Subscription10KW(int ID, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6, string keyword7, string keyword8, string keyword9, string keyword10, int ContracttypeID, int Period, string sDate, string eDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                string commandText = "INSERT INTO Subscription VALUES(@AccountID, @KW1, ";
                commandText = commandText + "@KW2, @KW3, @KW4, @KW5, @KW6, @KW7, @KW8, @KW9, @KW10, @KWChange, @LastUpdate, @ContractTypeID, @Period, @StartDate, @EndDate)";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;
                                             
                cmd.Parameters.Add("@AccountID", SqlDbType.Int);
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
                cmd.Parameters.Add("@ContractTypeID", SqlDbType.Int);
                cmd.Parameters.Add("@Period", SqlDbType.Int);
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);

                cmd.Parameters["@AccountID"].Value = ID;
                cmd.Parameters["@KW1"].Value = keyword1;
                cmd.Parameters["@KW2"].Value = keyword2;
                cmd.Parameters["@KW3"].Value = keyword3;
                cmd.Parameters["@KW4"].Value = keyword4;
                cmd.Parameters["@KW5"].Value = keyword5;
                cmd.Parameters["@KW6"].Value = keyword6;
                cmd.Parameters["@KW7"].Value = keyword7;
                cmd.Parameters["@KW8"].Value = keyword8;
                cmd.Parameters["@KW9"].Value = keyword9;
                cmd.Parameters["@KW10"].Value = keyword10;
                cmd.Parameters["@KWChange"].Value = 10;
                cmd.Parameters["@LastUpdate"].Value = DateTime.Today.ToShortDateString();
                cmd.Parameters["@ContractTypeID"].Value = ContracttypeID;
                cmd.Parameters["@Period"].Value = Period;
                cmd.Parameters["@StartDate"].Value = sDate;
                cmd.Parameters["@EndDate"].Value = eDate;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
        #endregion

        #region Renewal
        public static void Renewal3KW(int SubID, int ID, string keyword1, string keyword2, string keyword3, int ContracttypeID, int Period, string sDate, string eDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                string commandText = "Update Subscription Set AccountID=@AccountID, KW1=@KW1, KW2=@KW2, KW3=@KW3, KW4=@KW4, KW5=@KW5, KW6=@KW6, KW7=@KW7, KW8=@KW8, KW9=@KW9, KW10=@KW10";
                commandText = commandText + ", KWChange=@KWChange, LastUpdate=@LastUpdate, ContractTypeID=@ContractTypeID, Period=@Period, StartDate=@StartDate, EndDate=@EndDate WHERE ID=@SubID";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@SubID", SqlDbType.Int);
                cmd.Parameters.Add("@AccountID", SqlDbType.Int);
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
                cmd.Parameters.Add("@ContractTypeID", SqlDbType.Int);
                cmd.Parameters.Add("@Period", SqlDbType.Int);
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);

                cmd.Parameters["@SubID"].Value = SubID;
                cmd.Parameters["@AccountID"].Value = ID;
                cmd.Parameters["@KW1"].Value = keyword1;
                cmd.Parameters["@KW2"].Value = keyword2;
                cmd.Parameters["@KW3"].Value = keyword3;
                cmd.Parameters["@KW4"].Value = "";
                cmd.Parameters["@KW5"].Value = "";
                cmd.Parameters["@KW6"].Value = "";
                cmd.Parameters["@KW7"].Value = "";
                cmd.Parameters["@KW8"].Value = "";
                cmd.Parameters["@KW9"].Value = "";
                cmd.Parameters["@KW10"].Value = "";
                cmd.Parameters["@KWChange"].Value = 3;
                cmd.Parameters["@LastUpdate"].Value = DateTime.Today.ToShortDateString();
                cmd.Parameters["@ContractTypeID"].Value = ContracttypeID;
                cmd.Parameters["@Period"].Value = Period;
                cmd.Parameters["@StartDate"].Value = sDate;
                cmd.Parameters["@EndDate"].Value = eDate;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void Renewal10KW(int SubID, int ID, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6, string keyword7, string keyword8, string keyword9, string keyword10, int ContracttypeID, int Period, string sDate, string eDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                string commandText = "Update Subscription Set AccountID=@AccountID, KW1=@KW1, ";
                commandText = commandText + "KW2=@KW2, KW3=@KW3, KW4=@KW4, KW5=@KW5, KW6=@KW6, KW7=@KW7, KW8=@KW8, KW9=@KW9, KW10=@KW10, KWChange=@KWChange, LastUpdate=@LastUpdate, ContractTypeID=@ContractTypeID, Period=@Period, StartDate=@StartDate, EndDate=@EndDate WHERE ID=@SubID";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@SubID", SqlDbType.Int);
                cmd.Parameters.Add("@AccountID", SqlDbType.Int);
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
                cmd.Parameters.Add("@ContractTypeID", SqlDbType.Int);
                cmd.Parameters.Add("@Period", SqlDbType.Int);
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);

                cmd.Parameters["@SubID"].Value = SubID;
                cmd.Parameters["@AccountID"].Value = ID;
                cmd.Parameters["@KW1"].Value = keyword1;
                cmd.Parameters["@KW2"].Value = keyword2;
                cmd.Parameters["@KW3"].Value = keyword3;
                cmd.Parameters["@KW4"].Value = keyword4;
                cmd.Parameters["@KW5"].Value = keyword5;
                cmd.Parameters["@KW6"].Value = keyword6;
                cmd.Parameters["@KW7"].Value = keyword7;
                cmd.Parameters["@KW8"].Value = keyword8;
                cmd.Parameters["@KW9"].Value = keyword9;
                cmd.Parameters["@KW10"].Value = keyword10;
                cmd.Parameters["@KWChange"].Value = 10;
                cmd.Parameters["@LastUpdate"].Value = DateTime.Today.ToShortDateString();
                cmd.Parameters["@ContractTypeID"].Value = ContracttypeID;
                cmd.Parameters["@Period"].Value = Period;
                cmd.Parameters["@StartDate"].Value = sDate;
                cmd.Parameters["@EndDate"].Value = eDate;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        #endregion
    }
}