using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTE
{
    public class DatabaseInterface
    {

        private static DatabaseInterface instance = null;

        private String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
        private SqlConnection connection;

        private DatabaseInterface()
        {
            connection = new SqlConnection(connectionString);
        }

        ~DatabaseInterface()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static DatabaseInterface getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseInterface();
            }

            return instance;
        }

        public void createNewUser(User user)
        {
            connection.Open();
           
            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [User](username, password, administrator, state, birthdate, gender, race) VALUES (@username, @password, @administrator, @state, @birthdate, @gender, @race)";
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@administrator", 0);
                    command.Parameters.AddWithValue("@state", user.State);
                    command.Parameters.AddWithValue("@birthdate", user.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", user.Gender);
                    command.Parameters.AddWithValue("@race", user.Race);
                    command.ExecuteNonQuery();
                }

            }
            catch
            {

            }
            finally
            {

                connection.Close();
            }
        }

        public User authenticateUser(string username, string password)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [User] WHERE username=@username";
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[4], (String)reader[5], (String)reader[6], (String)reader[7], (Boolean)reader[3]);

                        if (user.Password == password)
                        {
                            return user;
                        }
                    }
                }

                return null;
            }
        }

        public Boolean doesUserExist(string username)
        {
            connection.Open();
            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT count(*) FROM [User] WHERE username=@username";
                    command.Parameters.AddWithValue("@username", username);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        return true;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return false;
        }
    }
}
