using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Data.SQLite;

namespace HOTELMANAGEMENTSYSTEM_OOP.Repositories
{
    public interface IGuestRepository
    {
        Guest GetGuestById(int guestId);
        Guest GetGuestByEmail(string email);
        void UpdateGuest(Guest guest);
        void DeleteGuest(int guestId);
        List<GuestBookingInfo> GetGuestBookingDetails();
    }

    public class SQLiteGuestRepository : IGuestRepository
    {
        private readonly string _connectionString;

        public SQLiteGuestRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }

        public Guest GetGuestById(int guestId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Guest WHERE GuestID = @GuestID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestID", guestId);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Guest(
                            Convert.ToInt32(reader["GuestID"]),
                            Convert.ToString(reader["FirstName"]),
                            Convert.ToString(reader["MiddleName"]),
                            Convert.ToString(reader["LastName"]),
                            Convert.ToString(reader["EmailAddress"]),
                            Convert.ToInt64(reader["ContactNo"])
                        );
                    }
                    return null;
                }
            }
        }

        public List<GuestBookingInfo> GetGuestBookingDetails()
        {
            var guestBookingInfos = new List<GuestBookingInfo>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                g.GuestID,
                g.FirstName || ' ' || COALESCE(g.MiddleName, '') || ' ' || g.LastName AS GuestName,
                g.ContactNo,
                rt.RoomTypeName,
                r.RoomNumber,
                b.CheckInDate,
                b.CheckOutDate,
                g.EmailAddress
            FROM 
                Booking b
            JOIN 
                Guest g ON b.GuestID = g.GuestID
            JOIN 
                Room r ON b.RoomID = r.RoomID
            JOIN 
                RoomType rt ON r.RoomTypeID = rt.RoomTypeID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var guestBookingInfo = new GuestBookingInfo
                        {
                            GuestID = Convert.ToInt32(reader["GuestID"]),
                            GuestName = Convert.ToString(reader["GuestName"]),
                            ContactNo = Convert.ToInt64(reader["ContactNo"]),
                            RoomTypeName = Convert.ToString(reader["RoomTypeName"]),
                            RoomNumber = Convert.ToInt32(reader["RoomNumber"]),
                            CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                            CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                            EmailAddress = Convert.ToString(reader["EmailAddress"])
                        };
                        guestBookingInfos.Add(guestBookingInfo);
                    }
                }
            }

            return guestBookingInfos;
        }


        public Guest GetGuestByEmail(string email)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Guest WHERE EmailAddress = @EmailAddress";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmailAddress", email);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Guest(
                            Convert.ToInt32(reader["GuestID"]),
                            Convert.ToString(reader["FirstName"]),
                            Convert.ToString(reader["MiddleName"]),
                            Convert.ToString(reader["LastName"]),
                            Convert.ToString(reader["EmailAddress"]),
                            Convert.ToInt64(reader["ContactNo"])
                        );
                    }
                    return null;
                }
            }
        }


        public void UpdateGuest(Guest guest)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = "UPDATE Guest SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, " +
                                       "EmailAddress = @EmailAddress, ContactNo = @ContactNo WHERE GuestID = @GuestID";
                        using (var command = new SQLiteCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                            command.Parameters.AddWithValue("@MiddleName", guest.MiddleName);
                            command.Parameters.AddWithValue("@LastName", guest.LastName);
                            command.Parameters.AddWithValue("@EmailAddress", guest.GuestEmail);
                            command.Parameters.AddWithValue("@ContactNo", guest.GuestContactNo);
                            command.Parameters.AddWithValue("@GuestID", guest.GuestID);
                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        throw new Exception($"Error updating guest: {ex.Message}");
                    }
                }
            }
        }

        public void DeleteGuest(int guestId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = "DELETE FROM Guest WHERE GuestID = @GuestID";
                        using (var command = new SQLiteCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@GuestID", guestId);
                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        throw new Exception($"Error deleting guest: {ex.Message}");
                    }
                }
            }
        }
    }
}
