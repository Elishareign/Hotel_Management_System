using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Data.SQLite;

namespace HOTELMANAGEMENTSYSTEM_OOP.Repositories
{
    public interface IInvoiceRepository
    {
        List<InvoiceDisplayDTO> GetAllInvoices();
        void AddInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int invoiceId);
        bool UpdatePaymentStatus(int bookingID, string status);
        List<InvoiceSummaryDTO> GetInvoiceSummaries();

        List<InvoiceModel> GetInvoices();
    }


    public class SQLiteInvoiceRepository : IInvoiceRepository
    {
        private readonly string _connectionString;

        public SQLiteInvoiceRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }


        public List<InvoiceDisplayDTO> GetAllInvoices()
        {
            List<InvoiceDisplayDTO> invoices = new List<InvoiceDisplayDTO>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
        SELECT 
            i.InvoiceID,
            i.BookingID,
            i.InvoiceDate,
            i.TotalAmount,
            i.PaymentStatus,
            i.PaymentMethod,
            g.FirstName || ' ' || COALESCE(g.MiddleName, '') || ' ' || g.LastName AS GuestFullName
        FROM 
            Invoice i
        JOIN 
            Booking b ON i.BookingID = b.BookingID
        JOIN 
            Guest g ON b.GuestID = g.GuestID;
    ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            PaymentStatus status;
                            Enum.TryParse(reader["PaymentStatus"].ToString(), out status);

                            PaymentMethod method;
                            Enum.TryParse(reader["PaymentMethod"].ToString(), out method);

                            InvoiceDisplayDTO invoiceDTO = new InvoiceDisplayDTO(
                                Convert.ToInt32(reader["InvoiceID"]),
                                Convert.ToInt32(reader["BookingID"]),
                                Convert.ToDateTime(reader["InvoiceDate"]),
                                Convert.ToDecimal(reader["TotalAmount"]),
                                status,
                                method,
                                reader["GuestFullName"].ToString()
                            );

                            invoices.Add(invoiceDTO);
                        }
                    }
                }
            }

            return invoices;
        }




        public void AddInvoice(Invoice invoice)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string addInvoiceQuery = @"
        INSERT INTO Invoice (BookingID, InvoiceDate, TotalAmount, PaymentStatus, PaymentMethod) 
        VALUES (@BookingID, @InvoiceDate, @TotalAmount, @PaymentStatus, @PaymentMethod)";
                using (var addInvoiceCommand = new SQLiteCommand(addInvoiceQuery, connection))
                {
                    addInvoiceCommand.Parameters.AddWithValue("@BookingID", invoice.BookingID);
                    addInvoiceCommand.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate.ToString("yyyy-MM-dd"));
                    addInvoiceCommand.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                    addInvoiceCommand.Parameters.AddWithValue("@PaymentStatus", invoice.PaymentStatus.ToString());
                    addInvoiceCommand.Parameters.AddWithValue("@PaymentMethod", invoice.PaymentMethod.ToString());

                    addInvoiceCommand.ExecuteNonQuery();
                }
            }
        }



        public void UpdateInvoice(Invoice invoice)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                        UPDATE Invoice
                        SET BookingID = @BookingID,
                            InvoiceDate = @InvoiceDate,
                            TotalAmount = @TotalAmount,
                            PaymentStatus = @PaymentStatus,
                            PaymentMethod = @PaymentMethod
                        WHERE InvoiceID = @InvoiceID;
                    ";

                        using (var command = new SQLiteCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@BookingID", invoice.BookingID);
                            command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate.Date);
                            command.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                            command.Parameters.AddWithValue("@PaymentStatus", invoice.PaymentStatus.ToString());
                            command.Parameters.AddWithValue("@PaymentMethod", invoice.PaymentMethod.ToString());
                            command.Parameters.AddWithValue("@InvoiceID", invoice.InvoiceID);

                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        throw new Exception($"Error updating invoice: {ex.Message}");
                    }
                }
            }
        }

        public bool UpdatePaymentStatus(int bookingID, string status)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Invoice SET PaymentStatus = @Status WHERE BookingID = @BookingID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if a row was updated
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error updating payment status: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public List<InvoiceModel> GetInvoices()
        {
            List<InvoiceModel> invoices = new List<InvoiceModel>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                i.InvoiceID,
                g.FirstName || ' ' || COALESCE(g.MiddleName, '') || ' ' || g.LastName AS GuestFullName,
                g.ContactNo,
                g.EmailAddress,
                b.CheckInDate,
                b.CheckOutDate,
                r.RoomNumber,
                rt.RoomTypeName,
                rt.PricePerNight,
                i.TotalAmount,
                GROUP_CONCAT(a.AmenityName) AS Amenities,
                GROUP_CONCAT(a.AmenityPrice) AS AmenityPrices,
                i.PaymentMethod
            FROM 
                Guest g
            JOIN 
                Booking b ON g.GuestID = b.GuestID
            JOIN 
                Room r ON b.RoomID = r.RoomID
            JOIN 
                RoomType rt ON r.RoomTypeID = rt.RoomTypeID
            JOIN 
                Invoice i ON b.BookingID = i.BookingID
            LEFT JOIN 
                RoomTypeAmenity rta ON rt.RoomTypeID = rta.RoomTypeID
            LEFT JOIN 
                Amenity a ON rta.AmenityID = a.AmenityID
            GROUP BY 
                i.InvoiceID;
        ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InvoiceModel invoice = new InvoiceModel(
                                    Convert.ToInt32(reader["InvoiceID"]),
                                    reader["GuestFullName"].ToString(),
                                    Convert.ToInt32(reader["ContactNo"]),
                                    reader["EmailAddress"].ToString(),
                                    Convert.ToDateTime(reader["CheckInDate"]),
                                    Convert.ToDateTime(reader["CheckOutDate"]),
                                    Convert.ToInt32(reader["RoomNumber"]),
                                    reader["RoomTypeName"].ToString(),
                                    Convert.ToDecimal(reader["PricePerNight"]),
                                    Convert.ToDecimal(reader["TotalAmount"]),
                                    reader["Amenities"].ToString().Split(',').ToList(),
                                    reader["AmenityPrices"].ToString().Split(',').Select(decimal.Parse).ToList(),
                                    (PaymentMethod)Enum.Parse(typeof(PaymentMethod), reader["PaymentMethod"].ToString())
                                );

                                invoices.Add(invoice);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error fetching invoices: {ex.Message}");
                        throw; // Rethrow the exception to handle it further up the call stack if needed
                    }
                }
            }

            return invoices;
        }


        public void DeleteInvoice(int invoiceId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                        DELETE FROM Invoice
                        WHERE InvoiceID = @InvoiceID;
                    ";

                        using (var command = new SQLiteCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@InvoiceID", invoiceId);
                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        throw new Exception($"Error deleting invoice: {ex.Message}");
                    }
                }
            }
        }

        public List<InvoiceSummaryDTO> GetInvoiceSummaries()
        {
            var invoiceSummaries = new List<InvoiceSummaryDTO>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    InvoiceDate AS Period,
                    SUM(TotalAmount) AS Total
                FROM 
                    Invoice
                GROUP BY 
                    InvoiceDate;
            ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var summary = new InvoiceSummaryDTO
                        {
                            Period = reader["Period"].ToString(),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total"))
                        };
                        invoiceSummaries.Add(summary);
                    }
                }
            }

            return invoiceSummaries;
        }


    }
}
