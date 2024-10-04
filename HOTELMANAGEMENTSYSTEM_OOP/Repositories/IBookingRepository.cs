using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace HOTELMANAGEMENTSYSTEM_OOP.Repositories
{
    public interface IBookingRepository
    {
        Booking GetBookingById(int bookingId);
        BookingDetailDTO GetBookingDetailsById(int bookingId);

        int AddGuestAndBooking(Guest guest, Booking booking); 
        bool UpdateBookingStatus(int bookingId, string newStatus);
        bool UpdateBookingAndInvoice(UpdateBooking booking);
        bool SoftDeleteBooking(int bookingID);
        IEnumerable<BookingDisplayDTO> GetAllBookingsWithDetails();
        int CountConfirmedBookings();
        int CountCompletedBookings();
        List<BookingDetails> GetTodayCheckIns();
        int CountTotalBookings();
    }


    public class SQLiteBookingRepository : IBookingRepository
    {
        private readonly string _connectionString;

        public SQLiteBookingRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }
        public Booking GetBookingById(int bookingId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Booking WHERE BookingID = @BookingID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", bookingId);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Booking(
                            Convert.ToInt32(reader["BookingID"]),
                            Convert.ToInt32(reader["GuestID"]),
                            Convert.ToInt32(reader["RoomID"]),
                            Convert.ToInt32(reader["NumberOfGuests"]),
                            Convert.ToDateTime(reader["CheckInDate"]),
                            Convert.ToDateTime(reader["CheckOutDate"]),
                            Convert.ToDateTime(reader["BookingDate"]),
                            reader["SpecialRequest"] == DBNull.Value ? null : reader["SpecialRequest"].ToString(),
                            (BookingStatus)Enum.Parse(typeof(BookingStatus), reader["BookingStatus"].ToString())
                        );
                    }
                    return null;
                }
            }
        }


        public List<BookingDetails> GetTodayCheckIns()
        {
            List<BookingDetails> checkIns = new List<BookingDetails>();
            string query = @"
        SELECT 
            b.BookingID,
            b.BookingDate,
            (g.FirstName || ' ' || IFNULL(g.MiddleName, '') || ' ' || g.LastName) AS GuestName,
            r.RoomNumber,
            rt.RoomTypeName,
            b.CheckInDate
        FROM 
            Booking b
            INNER JOIN Guest g ON b.GuestID = g.GuestID
            INNER JOIN Room r ON b.RoomID = r.RoomID
            INNER JOIN RoomType rt ON r.RoomTypeID = rt.RoomTypeID
        WHERE
            DATE(b.CheckInDate) = DATE('now');
    ";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bookingDetail = new BookingDetails
                            {
                                BookingID = reader.GetInt32(0),
                                BookingDate = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                                GuestName = reader.GetString(2),
                                RoomNumber = reader.GetInt32(3),
                                RoomTypeName = reader.GetString(4),
                                CheckInDate = reader.GetDateTime(5).ToString("yyyy-MM-dd")
                            };
                            checkIns.Add(bookingDetail);
                        }
                    }
                }
            }

            return checkIns;
        }


        public int CountConfirmedBookings()
        {
            int confirmedBookingCount = 0;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                SELECT COUNT(*)
                FROM Booking
                WHERE BookingStatus = 'Confirmed';
            ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    confirmedBookingCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return confirmedBookingCount;
        }

        public int CountCompletedBookings()
        {
            int completedBookingCount = 0;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                SELECT COUNT(*)
                FROM Booking
                WHERE BookingStatus = 'Completed';
            ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    completedBookingCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return completedBookingCount;
        }


        public int CountTotalBookings()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
        SELECT COUNT(*) 
        FROM Booking 
        WHERE isDeleted = 0"; // Exclude soft-deleted bookings

                using (var command = new SQLiteCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }



        public int AddGuestAndBooking(Guest guest, Booking booking)
        {
            int bookingId = 0;
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Add guest to database
                        string addGuestQuery = @"
                INSERT INTO Guest (FirstName, MiddleName, LastName, EmailAddress, ContactNo) 
                VALUES (@FirstName, @MiddleName, @LastName, @EmailAddress, @ContactNo)";
                        using (var addGuestCommand = new SQLiteCommand(addGuestQuery, connection, transaction))
                        {
                            addGuestCommand.Parameters.AddWithValue("@FirstName", guest.FirstName);
                            addGuestCommand.Parameters.AddWithValue("@MiddleName", guest.MiddleName);
                            addGuestCommand.Parameters.AddWithValue("@LastName", guest.LastName);
                            addGuestCommand.Parameters.AddWithValue("@EmailAddress", guest.GuestEmail);
                            addGuestCommand.Parameters.AddWithValue("@ContactNo", guest.GuestContactNo);
                            addGuestCommand.CommandTimeout = 10; // Set command timeout to 10 seconds
                            addGuestCommand.ExecuteNonQuery();
                        }

                        // Retrieve the newly inserted guest ID
                        string getGuestIdQuery = "SELECT last_insert_rowid()";
                        int guestId;
                        using (var getGuestIdCommand = new SQLiteCommand(getGuestIdQuery, connection, transaction))
                        {
                            getGuestIdCommand.CommandTimeout = 10; // Set command timeout to 10 seconds
                            guestId = Convert.ToInt32(getGuestIdCommand.ExecuteScalar());
                        }

                        // Set guest ID for booking
                        booking.GuestID = guestId;

                        // Add booking to the database
                        string addBookingQuery = @"
                INSERT INTO Booking (GuestID, RoomID, NumberOfGuests, CheckInDate, CheckOutDate, BookingDate, SpecialRequest, BookingStatus)
                VALUES (@GuestID, @RoomID, @NumberOfGuests, @CheckInDate, @CheckOutDate, @BookingDate, @SpecialRequest, @BookingStatus);
                SELECT last_insert_rowid()";
                        using (var addBookingCommand = new SQLiteCommand(addBookingQuery, connection, transaction))
                        {
                            addBookingCommand.Parameters.AddWithValue("@GuestID", booking.GuestID);
                            addBookingCommand.Parameters.AddWithValue("@RoomID", booking.RoomID);
                            addBookingCommand.Parameters.AddWithValue("@NumberOfGuests", booking.NumberOfGuests);
                            addBookingCommand.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate.ToString("yyyy-MM-dd"));
                            addBookingCommand.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate.ToString("yyyy-MM-dd"));
                            addBookingCommand.Parameters.AddWithValue("@BookingDate", booking.BookingDate.ToString("yyyy-MM-dd"));
                            addBookingCommand.Parameters.AddWithValue("@SpecialRequest", string.IsNullOrEmpty(booking.SpecialRequest) ? DBNull.Value : (object)booking.SpecialRequest);
                            addBookingCommand.Parameters.AddWithValue("@BookingStatus", booking.BookingStatus.ToString());
                            addBookingCommand.CommandTimeout = 10; // Set command timeout to 10 seconds

                            bookingId = Convert.ToInt32(addBookingCommand.ExecuteScalar());
                        }

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        if (ex.ResultCode == SQLiteErrorCode.Busy)
                        {
                            throw new Exception("Database is busy. Please try again.");
                        }
                        else
                        {
                            throw new Exception($"Error adding booking: {ex.Message}");
                        }
                    }
                }
            }
            return bookingId;
        }


        public IEnumerable<BookingDisplayDTO> GetAllBookingsWithDetails()
        {
            var bookings = new List<BookingDisplayDTO>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
        SELECT 
            b.BookingID,
            r.RoomID,
            g.GuestID,
            b.BookingDate,
            g.FirstName || ' ' || IFNULL(g.MiddleName || ' ', '') || g.LastName AS GuestFullName,
            b.NumberOfGuests,
            b.CheckInDate,
            b.CheckOutDate,
            r.RoomNumber,
            rt.RoomTypeName,
            b.BookingStatus
        FROM 
            Booking b
        JOIN 
            Guest g ON b.GuestID = g.GuestID
        JOIN 
            Room r ON b.RoomID = r.RoomID
        JOIN 
            RoomType rt ON r.RoomTypeID = rt.RoomTypeID
        WHERE 
            b.isDeleted = 0;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var booking = new BookingDisplayDTO
                            {
                                BookingID= Convert.ToInt32(reader["BookingID"]),
                                RoomID = Convert.ToInt32(reader["RoomID"]),
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                BookingDate = Convert.ToDateTime(reader["BookingDate"]),
                                GuestFullName = reader["GuestFullName"].ToString(),
                                NumberOfGuests = Convert.ToInt32(reader["NumberOfGuests"]),
                                CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                                CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                                RoomNumber = Convert.ToInt32(reader["RoomNumber"]),
                                RoomTypeName = reader["RoomTypeName"].ToString(),
                                BookingStatus = (BookingStatus)Enum.Parse(typeof(BookingStatus), reader["BookingStatus"].ToString())
                            };

                            bookings.Add(booking);
                        }
                    }
                }
            }

            Debug.WriteLine($"Bookings retrieved: {bookings.Count()}");
            return bookings;
        }


        public BookingDetailDTO GetBookingDetailsById(int bookingId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                B.BookingID,
                G.FirstName || ' ' || G.LastName AS GuestName,
                B.CheckInDate,
                B.CheckOutDate,
                RT.RoomTypeName,
                R.RoomNumber,
                R.FloorNumber,
                RT.Capacity AS GuestCapacity,
                RT.PricePerNight, 
                RT.NumberOfBeds,
                GROUP_CONCAT(A.AmenityName, ', ') AS Amenities,
                SUM(A.AmenityPrice) AS TotalAmenityPrice, 
                I.TotalAmount
            FROM 
                Booking B
            JOIN 
                Guest G ON B.GuestID = G.GuestID
            JOIN 
                Room R ON B.RoomID = R.RoomID
            JOIN 
                RoomType RT ON R.RoomTypeID = RT.RoomTypeID
            LEFT JOIN 
                RoomTypeAmenity RTA ON RT.RoomTypeID = RTA.RoomTypeID
            LEFT JOIN 
                Amenity A ON RTA.AmenityID = A.AmenityID
            JOIN
                Invoice I ON B.BookingID = I.BookingID
            WHERE 
                B.BookingID = @bookingID
            GROUP BY 
                B.BookingID, G.FirstName, G.LastName, B.CheckInDate, B.CheckOutDate, 
                RT.RoomTypeName, R.RoomNumber, R.FloorNumber, RT.Capacity, 
                RT.NumberOfBeds, I.TotalAmount;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookingID", bookingId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new BookingDetailDTO
                            {
                                BookingID = Convert.ToInt32(reader["BookingID"]),
                                GuestName = reader["GuestName"].ToString(),
                                CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                                CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                                RoomTypeName = reader["RoomTypeName"].ToString(),
                                RoomNumber = Convert.ToInt32(reader["RoomNumber"]),
                                FloorNumber = Convert.ToInt32(reader["FloorNumber"]),
                                GuestCapacity = Convert.ToInt32(reader["GuestCapacity"]),
                                PricePerNight = Convert.ToDecimal(reader["PricePerNight"]), // Changed to decimal
                                NumberOfBeds = Convert.ToInt32(reader["NumberOfBeds"]),
                                Amenities = reader["Amenities"]?.ToString(),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                TotalAmenityPrice = Convert.ToDecimal(reader["TotalAmenityPrice"]) // Added TotalAmenityPrice
                            };
                        }
                    }
                }
            }
            return null; // Return null if no results found
        }





        public bool UpdateBookingAndInvoice(UpdateBooking booking)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update the Booking table without SpecialRequest and BookingDate
                        var updateBookingCommand = new SQLiteCommand(@"
                    UPDATE Booking 
                    SET GuestID = @GuestID, 
                        RoomID = @RoomID, 
                        NumberOfGuests = @NumberOfGuests, 
                        CheckInDate = @CheckInDate, 
                        CheckOutDate = @CheckOutDate, 
                        BookingStatus = @BookingStatus 
                    WHERE BookingID = @BookingID", connection);

                        updateBookingCommand.Parameters.AddWithValue("@GuestID", booking.GuestId);
                        updateBookingCommand.Parameters.AddWithValue("@RoomID", booking.RoomId);
                        updateBookingCommand.Parameters.AddWithValue("@NumberOfGuests", booking.NumberOfGuests);
                        updateBookingCommand.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate.ToString("yyyy-MM-dd"));
                        updateBookingCommand.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate.ToString("yyyy-MM-dd"));
                        updateBookingCommand.Parameters.AddWithValue("@BookingStatus", booking.BookingStatus);
                        updateBookingCommand.Parameters.AddWithValue("@BookingID", booking.BookingId);
                        updateBookingCommand.ExecuteNonQuery();

                        // Update the Invoice table
                        var updateInvoiceCommand = new SQLiteCommand(@"
                    UPDATE Invoice 
                    SET TotalAmount = @TotalAmount 
                    WHERE BookingID = @BookingID", connection);

                        updateInvoiceCommand.Parameters.AddWithValue("@TotalAmount", booking.NewTotalAmount);
                        updateInvoiceCommand.Parameters.AddWithValue("@BookingID", booking.BookingId);
                        updateInvoiceCommand.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        // Rollback the transaction if something goes wrong
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public bool UpdateBookingStatus(int bookingId, string newStatus)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateCommand = new SQLiteCommand(@"
                    UPDATE Booking
                    SET BookingStatus = @BookingStatus
                    WHERE BookingID = @BookingID", connection);

                        updateCommand.Parameters.AddWithValue("@BookingStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@BookingID", bookingId);
                        updateCommand.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        // Rollback the transaction if something goes wrong
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }




        public bool SoftDeleteBooking(int bookingID)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Booking SET isDeleted = 1 WHERE BookingID = @BookingID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", bookingID);
                    return command.ExecuteNonQuery() > 0; // Return true if any rows were updated
                }
            }
        }



    }
}

