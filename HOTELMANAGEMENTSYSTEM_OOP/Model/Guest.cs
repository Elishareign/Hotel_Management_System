using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public class Guest
    {
        public int GuestID { get; private set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string GuestEmail { get; set; }
        public long GuestContactNo { get; set; }


        public Guest(int guestID, string firstName, string? middleName, string lastName, string guestEmail, long guestContactNo)
        {
            GuestID = guestID;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            GuestEmail = guestEmail;
            GuestContactNo = guestContactNo;
        }
    }


    public class GuestBookingInfo
    {
        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public long ContactNo { get; set; }
        public string RoomTypeName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string EmailAddress { get; set; }
    }

}