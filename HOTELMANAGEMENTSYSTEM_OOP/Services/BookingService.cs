using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using System;
using System.Collections.Generic;

namespace HOTELMANAGEMENTSYSTEM_OOP.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
        }

        public Booking GetBookingById(int bookingId)
        {
            return _bookingRepository.GetBookingById(bookingId);
        }

        public BookingDetailDTO GetBookingDetailsById(int bookingId) 
        {
            return _bookingRepository.GetBookingDetailsById(bookingId);
        }

        public void AddGuestAndBooking(Guest guest, Booking booking)
        {
            int bookingId = _bookingRepository.AddGuestAndBooking(guest, booking);

            booking.GetType().GetProperty("BookingID").SetValue(booking, bookingId);
        }


        public bool UpdateBookingAndInvoice(UpdateBooking booking)
        {
            return _bookingRepository.UpdateBookingAndInvoice(booking);
        }

        public bool UpdateBookingStatus(int bookingId, string newStatus)
        {
            return _bookingRepository.UpdateBookingStatus(bookingId, newStatus);
        }

        public bool SoftDeleteBooking(int bookingID)
        {
            return _bookingRepository.SoftDeleteBooking(bookingID);
        }


        public int CalculateStayDuration(DateTime checkInDate, DateTime checkOutDate)
        {
            return (int)(checkOutDate - checkInDate).TotalDays;
        }

        public IEnumerable<BookingDisplayDTO> GetAllBookingsWithDetails()
        {
            return _bookingRepository.GetAllBookingsWithDetails();
        }
        public int CountTotalBookings()
        {
            return _bookingRepository.CountTotalBookings();
        }

        public int CountConfirmedBookings()
        {
            return _bookingRepository.CountConfirmedBookings();
        }

        public int CountCompletedBookings()
        {
            return _bookingRepository.CountCompletedBookings();
        }

        public List<BookingDetails> GetTodayCheckIns()
        {
            return _bookingRepository.GetTodayCheckIns();
        }


    }

}
