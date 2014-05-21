using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ASPNetFileUpDownLoad.Utilities
{
    public class FileUtilities
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

        // Get the list of the files in the database
        public static DataTable GetFileList()
        {
            DataTable fileList = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "SELECT ID, Name, ContentType, Size, Date FROM Files";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(fileList);

                connection.Close();
            }

            return fileList;
        }

        // Get the list of under the user account
        public static DataTable GetFileUser(string user)
        {
            DataTable fileList = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText = "SELECT ID, Name, ContentType, Size, Date FROM Files Where U='" + user + "'", connection);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(fileList);

                connection.Close();
            }

            return fileList;
        }

        // Get the list of users
        public static DataTable GetUser()
        {
            DataTable UserList = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText = "SELECT ID, Username,Email, Company, HP, Type From Account ", connection);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(UserList);

                connection.Close();
            }

            return UserList;
        }

        // Save a file into the database
        public static void SaveFile(string name, string contentType,
            int size, byte[] data, string user)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("dd-M-yyyy");

                string commandText = "INSERT INTO Files VALUES(@Name, @ContentType, ";
                commandText = commandText + "@Size, @Data, @Date, @User)";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@ContentType", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@size", SqlDbType.Int);
                cmd.Parameters.Add("@Data", SqlDbType.VarBinary);
                cmd.Parameters.Add("@Date", SqlDbType.Date);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

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

        // Get a file from the database by ID
        public static DataTable GetAFile(string user)
        {
            DataTable file = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "SELECT * FROM Files "
                    + "WHERE User=@User";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.Add("@User", SqlDbType.Int);
                cmd.Parameters["@User"].Value = user;

                adapter.SelectCommand = cmd;
                adapter.Fill(file);

                connection.Close();
            }

            return file;
        }

        //Authenticate user to login to the website
        public static void Authentication(string user, string password, ref int type)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select UserName, Password, Type From Account WHERE UserName=@username And Password=@password";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = user;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        type = int.Parse(reader["Type"].ToString());
                    }
                    connection.Close();
                }
                else
                {
                    connection.Close();
                }
            }
        }

        //Insert data to create a user account to login to the website
        public static void AccountCreation(string username, string password, string email, string company, string hp)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Insert Into Account (Username, Password, Email, Company, HP, Type) Values(@username, @password, @email, @company, @hp, 2)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters.Add("@company", SqlDbType.VarChar);
                cmd.Parameters["@company"].Value = company;
                cmd.Parameters.Add("@hp", SqlDbType.VarChar);
                cmd.Parameters["@hp"].Value = hp;

                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        // Password reset to check account by email
        public static void CheckAccountByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select Email From Account Where Email=@email";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Utilities.Email.SendPassword(email);
                    connection.Close();
                }
            }
        }

        // Password reset to check account by username
        public static void CheckAccountByUser(string user)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                string email = "";
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Select * From Account Where UserName=@user";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@user", SqlDbType.VarChar);
                cmd.Parameters["@user"].Value = user;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        email = reader["Email"].ToString();
                    }
                    connection.Close();
                    Utilities.Email.SendPassword(email);

                }
            }
        }

        // Reset the user's password
        public static void PasswordReset(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Update Account Set Password=@password Where Email=@email";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Delete user from database
        public static void DeleteUser(Int16 id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                OpenConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "Delete From Account Where ID=@id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id", SqlDbType.SmallInt);
                cmd.Parameters["@id"].Value = id;

                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }
    }
}