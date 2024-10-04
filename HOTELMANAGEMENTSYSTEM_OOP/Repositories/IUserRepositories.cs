using HOTELMANAGEMENTSYSTEM_OOP.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace HOTELMANAGEMENTSYSTEM_OOP.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByEmailAndPassword(string email, string password);
    }

    public class SQLiteUserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public SQLiteUserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, name, email, password, usertype FROM User;";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("id"));
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                string email = reader.GetString(reader.GetOrdinal("email"));
                                string password = reader.GetString(reader.GetOrdinal("password"));
                                string userTypeStr = reader.GetString(reader.GetOrdinal("usertype"));

                                UserType userType = Enum.Parse<UserType>(userTypeStr);

                                User user = new User(id, name, email, password, userType);
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return users;
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            User user = null;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, name, email, password, usertype FROM User WHERE email = @Email AND password = @Password;";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("id"));
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                string userEmail = reader.GetString(reader.GetOrdinal("email"));
                                string userPassword = reader.GetString(reader.GetOrdinal("password"));
                                string userTypeStr = reader.GetString(reader.GetOrdinal("usertype"));

                                UserType userType = Enum.Parse<UserType>(userTypeStr);

                                user = new User(id, name, userEmail, userPassword, userType);
                            }
                            else
                            {
                                Console.WriteLine($"No user found with email: {email} and password: {password}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return user;
        }
    }
}
