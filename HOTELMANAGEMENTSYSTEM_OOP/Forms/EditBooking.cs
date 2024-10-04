using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace HOTELMANAGEMENTSYSTEM_OOP
{
    public partial class EditBooking : Form
    {
        private int _bookingID;
        private RoomService roomService;
        private int _guestID;
        private BookingService _bookingService;

        public EditBooking(int bookingID, int roomID, int guestID, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();
            _bookingID = bookingID;
            _guestID = guestID;
            roomService = new RoomService(new SQLiteRoomRepository());
            _bookingService = new BookingService(new SQLiteBookingRepository());

            // Set initial values for date pickers
            dtpStartDate.Value = checkInDate;
            dtpEndDate.Value = checkOutDate;

            // Attach event handlers
            dtpStartDate.ValueChanged += DateTimePicker_ValueChanged;
            dtpEndDate.ValueChanged += DateTimePicker_ValueChanged;

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateDatePickers();
        }

        private void ValidateDatePickers()
        {
            DateTime fromDate = dtpStartDate.Value.Date;
            DateTime toDate = dtpEndDate.Value.Date;

            if (fromDate >= toDate)
            {
                MessageBox.Show("End date must be later than start date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = fromDate.AddDays(1); // Set end date to one day after start date
            }
        }



        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            var bookingService = new BookingService(new SQLiteBookingRepository());
            var bookingDetails = bookingService.GetBookingDetailsById(_bookingID);

            // Load room types
            var roomTypes = roomService.GetRoomTypes();
            comboBoxRoomType.DataSource = roomTypes;
            comboBoxRoomType.DisplayMember = "RoomTypeName";
            comboBoxRoomType.ValueMember = "RoomTypeID";
            comboBoxFloorNumber.DataSource = Enumerable.Range(1, 10).ToList();

            comboBoxRoomType.OnSelectedIndexChanged += ComboBoxRoomType_SelectedIndexChanged;
            comboBoxFloorNumber.OnSelectedIndexChanged += ComboBoxFloorNumber_SelectedIndexChanged;

            // Call to filter available rooms initially
            FilterAvailableRooms();

            if (bookingDetails != null)
            {
                // Display Booking Details
                lblGuestName.Text = bookingDetails.GuestName;
                lblCheckInDate.Text = bookingDetails.CheckInDate.ToString("yyyy-MM-dd");
                lblCheckOutDate.Text = bookingDetails.CheckOutDate.ToString("yyyy-MM-dd");
                lblRoomTypeName.Text = bookingDetails.RoomTypeName;
                lblRoomNumber.Text = bookingDetails.RoomNumber.ToString();
                lblFloorNumber.Text = bookingDetails.FloorNumber.ToString();
                lblGuestCapacity.Text = bookingDetails.GuestCapacity.ToString();
                lblNumberOfBeds.Text = bookingDetails.NumberOfBeds.ToString();
                lblPricePerNight.Text = $"₱{bookingDetails.PricePerNight:N2}";
                lblTotalAmount.Text = $"₱{bookingDetails.TotalAmount:N2}";

                // Calculate stay duration
                TimeSpan stayDuration = bookingDetails.CheckOutDate - bookingDetails.CheckInDate;
                lblStayDuration.Text = $"{stayDuration.Days} day/s";

                // Calculate total room rate and VAT
                decimal roomRate = bookingDetails.PricePerNight;
                decimal totalRoomRate = roomRate * stayDuration.Days;
                decimal vat = totalRoomRate * 0.12m; // 12% VAT

                lblTotalRoomRate.Text = $"₱{totalRoomRate:N2}";
                lblVAT.Text = $"₱{vat:N2}";


                // Display total amenities
                decimal totalAmenityPrice = bookingDetails.TotalAmenityPrice; // Get total amenity price
                lblTotalAmenities.Text = $"₱{totalAmenityPrice:N2}";




                if (!string.IsNullOrEmpty(bookingDetails.Amenities))
                {
                    var amenitiesArray = bookingDetails.Amenities.Split(',')
                                                                 .Select(a => a.Trim())
                                                                 .ToList();

                    var concatenatedAmenities = new List<string>();

                    for (int i = 0; i < amenitiesArray.Count; i += 2)
                    {
                        if (i + 1 < amenitiesArray.Count)
                        {
                            concatenatedAmenities.Add($"{amenitiesArray[i]}, {amenitiesArray[i + 1]}");
                        }
                        else
                        {
                            concatenatedAmenities.Add(amenitiesArray[i]);
                        }
                    }

                    lblAmenities.Text = "Amenities:\n" + string.Join("\n", concatenatedAmenities);
                }
                else
                {
                    lblAmenities.Text = "No amenities available.";
                }
            }
            else
            {
                MessageBox.Show("Booking not found.");
            }
        }

        private void FilterAvailableRooms()
        {
            DateTime fromDate = dtpStartDate.Value;
            DateTime toDate = dtpEndDate.Value;

            var selectedRoomType = comboBoxRoomType.SelectedItem;
            string roomTypeName = selectedRoomType != null ?
                                  selectedRoomType.GetType().GetProperty("RoomTypeName")?.GetValue(selectedRoomType)?.ToString() :
                                  null;

            int? floorNumber = comboBoxFloorNumber.SelectedItem != null ?
                               (int?)Convert.ToInt32(comboBoxFloorNumber.SelectedItem) :
                               null;

            Debug.WriteLine($"Filtering available rooms for dates: {fromDate.ToShortDateString()} to {toDate.ToShortDateString()}");
            Debug.WriteLine($"Selected RoomType: {roomTypeName}");
            Debug.WriteLine($"Selected FloorNumber: {floorNumber}");

            var availableRooms = roomService.GetAvailableRoomsToEdit(fromDate, toDate, roomTypeName, floorNumber);

            Debug.WriteLine($"Available Rooms Count: {availableRooms.Count}");

            if (availableRooms != null && availableRooms.Count > 0)
            {
                foreach (var room in availableRooms)
                {
                    Debug.WriteLine($"RoomID: {room.RoomID}, RoomNumber: {room.RoomNumber}, FloorNumber: {room.FloorNumber}");
                }

                comboBoxAvailableRooms.DataSource = availableRooms;
                comboBoxAvailableRooms.DisplayMember = "RoomNumber";
                comboBoxAvailableRooms.ValueMember = "RoomID";
            }
            else
            {
                MessageBox.Show("No available rooms found.");
                comboBoxAvailableRooms.DataSource = null; // Clear ComboBox if no rooms are available
            }
        }

        private void ComboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAvailableRooms();
        }

        private void ComboBoxFloorNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAvailableRooms();
        }

        private void UpdateBookingButton_Click(object sender, EventArgs e)
        {
            int selectedRoomId = (int)comboBoxAvailableRooms.SelectedValue;
            DateTime fromDate = dtpStartDate.Value;
            DateTime toDate = dtpEndDate.Value;

            // Create and show the confirmation form, passing the necessary data
            EditBookingConfirmation confirmationForm = new EditBookingConfirmation(selectedRoomId, fromDate, toDate);
            confirmationForm.ShowDialog();
        }
        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {

            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Please ensure the end date is after the start date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Gather updated information from the form controls
            var updatedBooking = new UpdateBooking
            {
                BookingId = _bookingID,
                GuestId = _guestID,
                RoomId = (int)comboBoxAvailableRooms.SelectedValue,
                NumberOfGuests = int.TryParse(txtNumberOfGuests.Text, out int numberOfGuests) ? numberOfGuests : 0,
                CheckInDate = dtpStartDate.Value,
                CheckOutDate = dtpEndDate.Value,
                BookingStatus = "Pending",
                NewTotalAmount = CalculateNewTotalAmount() // Calculate the new total amount
            };

            // Call the service to update the booking and invoice
            bool isUpdated = _bookingService.UpdateBookingAndInvoice(updatedBooking);

            if (isUpdated)
            {
                MessageBox.Show("Booking updated successfully.");
                this.Close(); // Optionally close the form after saving
            }
            else
            {
                MessageBox.Show("Failed to update booking. Please try again.");
            }
        }


        private decimal CalculateNewTotalAmount()
        {
            // Get selected RoomID from the ComboBox
            int selectedRoomId = (int)comboBoxAvailableRooms.SelectedValue;

            // Fetch the room rate from the database
            decimal roomRate = GetRoomRateById(selectedRoomId);

            // Calculate stay duration in days
            int stayDuration = (dtpEndDate.Value - dtpStartDate.Value).Days;

            // Calculate total room rate
            decimal totalRoomRate = roomRate * stayDuration;

            // Get total amenities cost from the label
            decimal totalAmenityPrice = decimal.Parse(lblTotalAmenities.Text.Replace("₱", "").Replace(",", "").Trim());

            // Calculate the new total amount
            decimal totalAmount = totalRoomRate + totalAmenityPrice;

            return totalAmount;
        }

        private decimal GetRoomRateById(int roomId)
        {
            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();
                string query = @"
            SELECT rt.PricePerNight 
            FROM Room r
            JOIN RoomType rt ON r.RoomTypeID = rt.RoomTypeID
            WHERE r.RoomID = @RoomID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", roomId);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

    }
}
