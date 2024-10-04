using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;

namespace HOTELMANAGEMENTSYSTEM_OOP.Repositories
{
    public interface IRoomRepository
    {
        List<Room> GetAllRooms();
        List<Room> GetAvailableRooms(DateTime fromDate, DateTime toDate);
        RoomDetails GetRoomDetailsById(int roomId);
        void UpdateRoomStatus(int roomId, Status newStatus);
        bool RoomExists(int roomId);
        public List<Room> GetAvailableRoomsToEdit(DateTime fromDate, DateTime toDate, string roomTypeName, int? floorNumber);
        int GetAvailableRoomCount();
        void UpdateRoomStatusToUnderMaintenance(int roomId);

        List<RoomType> GetRoomTypes();

    }

    public class SQLiteRoomRepository : IRoomRepository
    {
        private readonly string _connectionString;

        public SQLiteRoomRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                r.RoomID, 
                r.RoomNumber, 
                r.FloorNumber, 
                r.RoomStatus, 
                r.RoomTypeID,
                rt.RoomTypeName, 
                rt.PricePerNight, 
                rt.NumberOfBeds, 
                rt.Capacity,
                CASE 
                    WHEN EXISTS (
                        SELECT 1 
                        FROM Booking b 
                        WHERE b.RoomID = r.RoomID 
                          AND DATE(b.CheckInDate) <= DATE('now', 'localtime') 
                          AND DATE(b.CheckOutDate) >= DATE('now', 'localtime')
                    ) THEN 'Occupied'
                    ELSE r.RoomStatus
                END AS CurrentRoomStatus
            FROM 
                Room r
            JOIN 
                RoomType rt ON r.RoomTypeID = rt.RoomTypeID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roomID = Convert.ToInt32(reader["RoomID"]);
                            int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                            int floorNumber = Convert.ToInt32(reader["FloorNumber"]);
                            Status roomStatus = Enum.Parse<Status>(reader["RoomStatus"].ToString());
                            int roomTypeID = Convert.ToInt32(reader["RoomTypeID"]);
                            string roomTypeName = reader["RoomTypeName"].ToString();
                            decimal pricePerNight = Convert.ToDecimal(reader["PricePerNight"]);
                            int numberOfBeds = Convert.ToInt32(reader["NumberOfBeds"]);
                            int capacity = Convert.ToInt32(reader["Capacity"]);

                            // Determine current room status based on the query result
                            string currentRoomStatusString = reader["CurrentRoomStatus"].ToString();
                            Status currentRoomStatus = Enum.Parse<Status>(currentRoomStatusString);

                            Room room = null; // Initialize room to null

                            // Create appropriate room type 
                            switch (roomTypeName)
                            {
                                case "Standard Room":
                                    room = new StandardRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, currentRoomStatus);
                                    break;
                                case "Deluxe Room":
                                    room = new DeluxeRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, currentRoomStatus);
                                    break;
                                case "Suite":
                                    room = new SuiteRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, currentRoomStatus);
                                    break;
                            }

                            if (room != null) // Check if room was created
                            {
                                rooms.Add(room);
                            }
                        }
                    }
                }
            }

            return rooms;
        }




        public List<Room> GetAvailableRooms(DateTime fromDate, DateTime toDate)
        {
            List<Room> availableRooms = new List<Room>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                              SELECT 
                                r.RoomID, 
                                r.RoomNumber, 
                                r.FloorNumber, 
                                CASE
                                    WHEN b.RoomID IS NOT NULL THEN 'Occupied'
                                    ELSE r.RoomStatus
                                END AS RoomStatus,
                                r.RoomTypeID, 
                                rt.RoomTypeName, 
                                rt.PricePerNight, 
                                rt.NumberOfBeds, 
                                rt.Capacity
                              FROM 
                                Room r
                              JOIN 
                                RoomType rt ON r.RoomTypeID = rt.RoomTypeID
                              LEFT JOIN (
                                SELECT DISTINCT RoomID
                                FROM Booking
                                WHERE 
                                  (CheckInDate <= @ToDate AND CheckOutDate >= @FromDate)
                                  AND BookingStatus IN ('Confirmed', 'Pending')
                              ) AS b ON r.RoomID = b.RoomID
                            ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FromDate", fromDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ToDate", toDate.ToString("yyyy-MM-dd"));

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int roomID = Convert.ToInt32(reader["RoomID"]);
                        int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                        int floorNumber = Convert.ToInt32(reader["FloorNumber"]);
                        Status roomStatus = Enum.Parse<Status>(reader["RoomStatus"].ToString());
                        int roomTypeID = Convert.ToInt32(reader["RoomTypeID"]);
                        string roomTypeName = reader["RoomTypeName"].ToString().Trim();
                        decimal pricePerNight = Convert.ToDecimal(reader["PricePerNight"]);
                        int numberOfBeds = Convert.ToInt32(reader["NumberOfBeds"]);
                        int capacity = Convert.ToInt32(reader["Capacity"]);

                        Room room = null;

                        switch (roomTypeName)
                        {
                            case "Standard Room":
                                room = new StandardRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            case "Deluxe Room":
                                room = new DeluxeRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            case "Suite":
                                room = new SuiteRoom(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            default:
                                // Handle any unexpected room type name from the database
                                Console.WriteLine($"Unexpected room type name: {roomTypeName}");
                                break;
                        }

                        // Add the room to the list if it was successfully created
                        if (room != null)
                        {
                            availableRooms.Add(room);
                        }
                    }
                }
            }

            return availableRooms;
        }


        public List<Room> GetAvailableRoomsToEdit(DateTime fromDate, DateTime toDate, string roomTypeName, int? floorNumber)
        {
            List<Room> availableRooms = new List<Room>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                r.RoomID, 
                r.RoomNumber, 
                r.RoomStatus,
                r.RoomTypeID, 
                rt.RoomTypeName, 
                rt.PricePerNight, 
                rt.NumberOfBeds, 
                rt.Capacity
            FROM 
                Room r
            JOIN 
                RoomType rt ON r.RoomTypeID = rt.RoomTypeID
            LEFT JOIN (
                SELECT DISTINCT RoomID
                FROM Booking
                WHERE 
                    (CheckInDate < @ToDate AND CheckOutDate > @FromDate)
                    AND BookingStatus IN ('Confirmed', 'Pending')
            ) AS b ON r.RoomID = b.RoomID
            WHERE 
                b.RoomID IS NULL
                AND (@RoomTypeName IS NULL OR rt.RoomTypeName = @RoomTypeName)
                AND (@FloorNumber IS NULL OR r.FloorNumber = @FloorNumber);
        ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FromDate", fromDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ToDate", toDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@RoomTypeName", string.IsNullOrEmpty(roomTypeName) ? (object)DBNull.Value : roomTypeName);
                    command.Parameters.AddWithValue("@FloorNumber", floorNumber.HasValue ? (object)floorNumber.Value : DBNull.Value);

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int roomID = Convert.ToInt32(reader["RoomID"]);
                        int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                        string roomStatusStr = reader["RoomStatus"].ToString();
                        Status roomStatus = Enum.TryParse(roomStatusStr, out Status statusResult) ? statusResult : Status.Available;
                        int roomTypeID = Convert.ToInt32(reader["RoomTypeID"]);
                        string roomTypeNameResult = reader["RoomTypeName"].ToString().Trim();
                        decimal pricePerNight = Convert.ToDecimal(reader["PricePerNight"]);
                        int numberOfBeds = Convert.ToInt32(reader["NumberOfBeds"]);
                        int capacity = Convert.ToInt32(reader["Capacity"]);

                        Room room = null;

                        // Create room based on room type
                        switch (roomTypeNameResult)
                        {
                            case "Standard Room":
                                room = new StandardRoom(roomID, roomTypeID, roomTypeNameResult, roomNumber, floorNumber ?? 0, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            case "Deluxe Room":
                                room = new DeluxeRoom(roomID, roomTypeID, roomTypeNameResult, roomNumber, floorNumber ?? 0, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            case "Suite":
                                room = new SuiteRoom(roomID, roomTypeID, roomTypeNameResult, roomNumber, floorNumber ?? 0, capacity, numberOfBeds, pricePerNight, roomStatus);
                                break;
                            default:
                                Console.WriteLine($"Unexpected room type name: {roomTypeNameResult}");
                                break;
                        }

                        // Add the room to the list if it was successfully created
                        if (room != null)
                        {
                            availableRooms.Add(room);
                        }
                    }
                }
            }
            return availableRooms;
        }



        public List<RoomType> GetRoomTypes()
        {
            List<RoomType> roomTypes = new List<RoomType>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT RoomTypeID, RoomTypeName FROM RoomType";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoomType roomType = new RoomType
                            {
                                RoomTypeID = Convert.ToInt32(reader["RoomTypeID"]),
                                RoomTypeName = reader["RoomTypeName"].ToString()
                            };
                            roomTypes.Add(roomType);
                        }
                    }
                }
            }

            return roomTypes;
        }



        public RoomDetails GetRoomDetailsById(int roomId)
        {
            RoomDetails roomDetails = null;
            decimal totalAmenityPrice = 0.0M;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        r.RoomID,
                        r.RoomNumber,
                        r.FloorNumber,
                        r.RoomStatus,
                        rt.RoomTypeID,
                        rt.RoomTypeName,
                        rt.PricePerNight,
                        rt.NumberOfBeds,
                        rt.Capacity,
                        a.AmenityID,
                        a.AmenityName,
                        a.AmenityPrice,
                        a.Description
                    FROM Room r
                    JOIN RoomType rt ON r.RoomTypeID = rt.RoomTypeID
                    LEFT JOIN RoomTypeAmenity rta ON rt.RoomTypeID = rta.RoomTypeID
                    LEFT JOIN Amenity a ON rta.AmenityID = a.AmenityID
                    WHERE r.RoomID = @RoomID
                ";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", roomId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (roomDetails == null)
                            {
                                int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                                int floorNumber = Convert.ToInt32(reader["FloorNumber"]);
                                Status roomStatus = Enum.Parse<Status>(reader["RoomStatus"].ToString());
                                int roomTypeId = Convert.ToInt32(reader["RoomTypeID"]);
                                string roomTypeName = reader["RoomTypeName"].ToString();
                                decimal pricePerNight = Convert.ToDecimal(reader["PricePerNight"]);
                                int numberOfBeds = Convert.ToInt32(reader["NumberOfBeds"]);
                                int capacity = Convert.ToInt32(reader["Capacity"]);

                                roomDetails = new RoomDetails(roomId, roomNumber, floorNumber, roomStatus,
                                                              roomTypeId, roomTypeName, pricePerNight,
                                                              numberOfBeds, capacity);
                            }

                            // Add amenities to the room details and sum up the amenity prices
                            if (reader["AmenityID"] != DBNull.Value)
                            {
                                int amenityId = Convert.ToInt32(reader["AmenityID"]);
                                string amenityName = reader["AmenityName"].ToString();
                                decimal amenityPrice = Convert.ToDecimal(reader["AmenityPrice"]);
                                string description = reader["Description"].ToString();

                                totalAmenityPrice += amenityPrice; // Accumulate total amenity price

                                if (roomDetails.Amenities == null)
                                {
                                    roomDetails.Amenities = new List<Amenity>();
                                }

                                roomDetails.AddAmenity(new Amenity(amenityId, amenityName, amenityPrice, description));
                            }
                        }
                    }
                }
            }

            // Set the total amenity price in the room details object 
            if (roomDetails != null)
            {
                roomDetails.TotalAmenityPrice = totalAmenityPrice;
            }

            return roomDetails;
        }

        public void UpdateRoomStatus(int roomId, Status newStatus)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE Room
                    SET RoomStatus = @NewStatus
                    WHERE RoomID = @RoomID;
                ";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewStatus", newStatus.ToString());
                    command.Parameters.AddWithValue("@RoomID", roomId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetAvailableRoomCount()
        {
            int availableRoomCount = 0;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
        SELECT COUNT(*)
            FROM Room r
            WHERE r.RoomStatus = 'Available'
              AND r.RoomID NOT IN (
                SELECT b.RoomID
                FROM Booking b
                WHERE b.CheckInDate <= DATE('now')
                  AND b.CheckOutDate >= DATE('now')
            );

        ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    availableRoomCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return availableRoomCount;
        }

        public void UpdateRoomStatusToUnderMaintenance(int roomId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            UPDATE Room
            SET RoomStatus = @RoomStatus
            WHERE RoomID = @RoomID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomStatus", "Under Maintenance");
                    command.Parameters.AddWithValue("@RoomID", roomId);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions as needed
                        Console.WriteLine($"Error updating room status: {ex.Message}");
                    }
                }
            }
        }


        public bool RoomExists(int roomId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT COUNT(*) FROM Room WHERE RoomID = @RoomID";
                    command.Parameters.AddWithValue("@RoomID", roomId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}