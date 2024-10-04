namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public abstract class Room
    {
        public int RoomID { get; private set; }
        public int RoomTypeID { get; private set; }
        public string RoomTypeName { get; set; }
        public int RoomNumber { get; set; }
        public int FloorNumber { get;  set; }
        public int Capacity { get; set; }
        public int NumberOfBeds { get; set; }
        public decimal PricePerNight { get; set; }
        public Status? RoomStatus { get; set; }

        protected Room(int roomID, int roomTypeID, string roomTypeName, int roomNumber, int floorNumber, int capacity, int numberOfBeds, decimal pricePerNight, Status? roomStatus)
        {
            RoomID = roomID;
            RoomTypeID = roomTypeID;
            RoomTypeName = roomTypeName;
            RoomNumber = roomNumber;
            FloorNumber = floorNumber;
            Capacity = capacity;
            NumberOfBeds = numberOfBeds;
            PricePerNight = pricePerNight;
            RoomStatus = roomStatus;
        }
    }

    public enum Status
    {
        Available,
        Occupied,
        UnderMaintenance
    }

 
    public class StandardRoom : Room
    {
        public StandardRoom(int roomID, int roomTypeID, string roomTypeName, int roomNumber, int floorNumber, int capacity, int numberOfBeds, decimal pricePerNight, Status? roomStatus)
            : base(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus)
        {
        }
    }

    public class DeluxeRoom : Room
    {
        public DeluxeRoom(int roomID, int roomTypeID, string roomTypeName, int roomNumber, int floorNumber, int capacity, int numberOfBeds, decimal pricePerNight, Status? roomStatus)
            : base(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus)
        {
        }
    }

    public class SuiteRoom : Room
    {
        public SuiteRoom(int roomID, int roomTypeID, string roomTypeName, int roomNumber, int floorNumber, int capacity, int numberOfBeds, decimal pricePerNight, Status? roomStatus)
            : base(roomID, roomTypeID, roomTypeName, roomNumber, floorNumber, capacity, numberOfBeds, pricePerNight, roomStatus)
        {
        }
    }

    public class RoomDetails
    {
        public int RoomID { get; private set; }
        public int RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public Status RoomStatus { get; set; }
        public int RoomTypeID { get; private set; }
        public string RoomTypeName { get; set; }
        public decimal PricePerNight { get; set; }
        public int NumberOfBeds { get; set; }
        public int Capacity { get; set; }
        public List<Amenity> Amenities { get; set; }
        public decimal TotalAmenityPrice { get; set; }

        // Constructor for basic room details
        public RoomDetails(int roomID, int roomNumber, int floorNumber, Status roomStatus, int roomTypeID, string roomTypeName, decimal pricePerNight, int numberOfBeds, int capacity)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            FloorNumber = floorNumber;
            RoomStatus = roomStatus;
            RoomTypeID = roomTypeID;
            RoomTypeName = roomTypeName;
            PricePerNight = pricePerNight;
            NumberOfBeds = numberOfBeds;
            Capacity = capacity;
            Amenities = new List<Amenity>(); // Initialize amenities list
            TotalAmenityPrice = 0.0M; // Initialize total amenity price
        }

        // Constructor with amenities and total amenity price
        public RoomDetails(int roomID, int roomNumber, int floorNumber, Status roomStatus, int roomTypeID, string roomTypeName, decimal pricePerNight, int numberOfBeds, int capacity, List<Amenity> amenities, decimal totalAmenityPrice)
            : this(roomID, roomNumber, floorNumber, roomStatus, roomTypeID, roomTypeName, pricePerNight, numberOfBeds, capacity)
        {
            Amenities = amenities;
            TotalAmenityPrice = totalAmenityPrice;
        }

        public void AddAmenity(Amenity amenity)
        {
            Amenities.Add(amenity);
            TotalAmenityPrice += amenity.AmenityPrice;
        }


    }
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
    }

}

