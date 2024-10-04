using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using System;

namespace HOTELMANAGEMENTSYSTEM_OOP.Services
{
    public class GuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestService(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository ?? throw new ArgumentNullException(nameof(guestRepository));
        }

        public Guest GetGuestById(int guestId)
        {
            if (guestId <= 0)
            {
                throw new ArgumentException("Guest ID must be greater than zero.", nameof(guestId));
            }

            return _guestRepository.GetGuestById(guestId);
        }

        public Guest GetGuestByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email must be provided.", nameof(email));
            }

            return _guestRepository.GetGuestByEmail(email);
        }

        public void UpdateGuest(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest));
            }

            if (guest.GuestID <= 0)
            {
                throw new ArgumentException("Guest ID must be greater than zero.", nameof(guest.GuestID));
            }

            _guestRepository.UpdateGuest(guest);
        }

        public void DeleteGuest(int guestId)
        {
            if (guestId <= 0)
            {
                throw new ArgumentException("Guest ID must be greater than zero.", nameof(guestId));
            }

            _guestRepository.DeleteGuest(guestId);
        }


        public List<GuestBookingInfo> GetGuestBookingDetails()
        {
            return _guestRepository.GetGuestBookingDetails();
        }
    }
}
