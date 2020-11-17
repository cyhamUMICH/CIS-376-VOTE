using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BCrypt.Net;
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

        public void changeBallotDate(Ballot ballot, DateTime date)
        {

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
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(user.Password, BCrypt.Net.BCrypt.GenerateSalt(12)));
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

        public List<Ballot> getAllBallots()
        {
            connection.Open();

            List<Ballot> ballots = new List<Ballot>();

            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Ballot]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ballotId = reader.GetInt32(0);
                            string ballotName = reader.GetString(1);
                            DateTime openDate = reader.GetDateTime(2);
                            DateTime dueDate = reader.GetDateTime(3);

                            Ballot ballot = new Ballot(ballotId, ballotName, openDate, dueDate);

                            ballots.Add(ballot);
                        }
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

            return ballots;
        }

        public List<Ballot> getActiveBallots()
        {
            connection.Open();

            List<Ballot> ballots = new List<Ballot>();

            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Ballot] WHERE OpenDate < @now AND DueDate > @now";
                    command.Parameters.AddWithValue("@now", DateTime.UtcNow);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ballotId = reader.GetInt32(0);
                            string ballotName = reader.GetString(1);
                            DateTime openDate = reader.GetDateTime(2);
                            DateTime dueDate = reader.GetDateTime(3);

                            Ballot ballot = new Ballot(ballotId, ballotName, openDate, dueDate);

                            ballots.Add(ballot);
                        }
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

            return ballots;
        }

        public User authenticateUser(string username, string password)
        {
            connection.Open();

            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [User] WHERE username=@username";
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            String usernameDb = reader.GetString(1).TrimEnd();
                            String passwordDb = reader.GetString(2);
                            String state = reader.GetString(4).TrimEnd();
                            DateTime dateOfBirth = reader.GetDateTime(5);
                            String gender = reader.GetString(6).TrimEnd();
                            String race = reader.GetString(7).TrimEnd();
                            Boolean administrator = reader.GetBoolean(3);

                            User user = new User(userId, usernameDb, passwordDb, state, dateOfBirth.ToString("yyyy-MM-dd"), gender, race, administrator);

                            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                            {
                                return user;
                            }
                        }
                    }
                }
            } catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            } finally
            {
                connection.Close();
            }

            return null;
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
