using System;

namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public class Booking
    {
        public int BookingID { get; private set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BookingDate { get; set; }
        public string SpecialRequest { get; set; }
        public BookingStatus BookingStatus { get; set; }

        // Derived property for stay duration
        public int StayDuration
        {
            get { return (CheckOutDate - CheckInDate).Days; }
        }

        public Booking()
        {
            // Initialize default values
            BookingDate = DateTime.Now;
            BookingStatus = BookingStatus.Pending;
        }

        // Constructor for initializing all properties, including BookingID
        public Booking(int bookingID, int guestID, int roomID, int numberOfGuests,
                       DateTime checkInDate, DateTime checkOutDate, DateTime bookingDate,
                       string specialRequest, BookingStatus bookingStatus)
        {
            BookingID = bookingID;
            GuestID = guestID;
            RoomID = roomID;
            NumberOfGuests = numberOfGuests;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            BookingDate = bookingDate;
            SpecialRequest = specialRequest;
            BookingStatus = bookingStatus;
        }
    }

    public class BookingDisplayDTO
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int GuestID { get; set; }
        public DateTime BookingDate { get; set; }
        public string GuestFullName { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public BookingStatus BookingStatus { get; set; }
    }


    public class BookingDetailDTO
    {
        public int BookingID { get; set; }
        public string GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string RoomTypeName { get; set; }
        public int RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public int GuestCapacity { get; set; }
        public decimal PricePerNight { get; set; }
        public int NumberOfBeds { get; set; }
        public string Amenities { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmenityPrice { get; set; }
    }


    public class UpdateBooking
    {
        public int BookingId { get; set; }
        public decimal NewTotalAmount { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string BookingStatus { get; set; }
    }
    public class BookingDetails
    {
        public int BookingID { get; set; }
        public string BookingDate { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string CheckInDate { get; set; }
    }




    public enum BookingStatus
    {
        Confirmed,
        Pending,
        Completed,
        Cancelled
    }
}
