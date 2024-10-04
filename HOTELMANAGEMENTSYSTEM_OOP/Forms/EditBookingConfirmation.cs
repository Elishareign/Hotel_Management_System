using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HOTELMANAGEMENTSYSTEM_OOP
{
    public partial class EditBookingConfirmation : Form
    {
        private int _roomId;
        private DateTime _fromDate;
        private DateTime _toDate;

        public EditBookingConfirmation(int roomId, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            // Validate dates
            if (toDate <= fromDate)
            {
                MessageBox.Show("Check-out date must be after the check-in date.");
                return;
            }

            _roomId = roomId;
            _fromDate = fromDate;
            _toDate = toDate;

            LoadRoomDetails();
        }

        private void LoadRoomDetails()
        {
            var roomService = new RoomService(new SQLiteRoomRepository());
            var roomDetails = roomService.GetRoomDetailsById(_roomId);

            if (roomDetails != null)
            {
                lblRoomNumber.Text = roomDetails.RoomNumber.ToString();
                lblFloorNumber.Text = roomDetails.FloorNumber.ToString();
                lblRoomTypeName.Text = roomDetails.RoomTypeName;
                lblPricePerNight.Text = $"₱{roomDetails.PricePerNight:N2}";
                lblCapacity.Text = roomDetails.Capacity.ToString();
                lblNumberOfBeds.Text = roomDetails.NumberOfBeds.ToString();
                lblTotalAmenityPrice.Text = $"₱{roomDetails.TotalAmenityPrice:N2}";

                // Display amenities
                lblAmenities.Text = roomDetails.Amenities != null && roomDetails.Amenities.Count > 0
                    ? "Amenities:\n" + string.Join("\n", roomDetails.Amenities.Select(a => a.AmenityName))
                    : "No amenities available.";

                // Display selected dates
                lblStartDate.Text = _fromDate.ToString("yyyy-MM-dd");
                lblEndDate.Text = _toDate.ToString("yyyy-MM-dd");

                // Calculate stay duration
                TimeSpan stayDuration = _toDate - _fromDate;
                lblStayDuration.Text = $"{stayDuration.Days + 1} day/s";

                // Calculate total room rate and VAT
                decimal roomRate = roomDetails.PricePerNight;
                decimal totalRoomRate = roomRate * stayDuration.Days;
                decimal vat = totalRoomRate * 0.12m; // 12% VAT
                decimal totalAmount = totalRoomRate + vat + roomDetails.TotalAmenityPrice;

                // Display calculated values
                lblTotalRoomRate.Text = $"₱{totalRoomRate:N2}";
                lblVAT.Text = $"₱{vat:N2}";
                lblTotalAmount.Text = $"₱{totalAmount:N2}";
            }
            else
            {
                MessageBox.Show("Room details not found.");
            }
        }
    }
}
