using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class BookingListForm : Form
    {
        private readonly BookingService _bookingService;
        private readonly InvoiceService _invoiceService;

        public BookingListForm()
        {
            InitializeComponent();
            _bookingService = new BookingService(new SQLiteBookingRepository());
            _invoiceService = new InvoiceService(new SQLiteInvoiceRepository());

            this.Load += BookingListForm_Load; 


            addBookingButton.Click += addBookingButton_Click;

           SearchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            LoadBookings(searchTerm);
        }


        private void BookingListForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }


        private void LoadBookings(string searchTerm = "")
        {
            try
            {
                // Clear existing rows
                dataGridViewBookings.Rows.Clear();

                // Fetch bookings from the booking service
                IEnumerable<BookingDisplayDTO> bookings = _bookingService.GetAllBookingsWithDetails();

                // Filter bookings based on the search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    bookings = bookings.Where(b =>
                        b.GuestFullName.ToLower().Contains(searchTerm) ||
                        b.BookingID.ToString().Contains(searchTerm) ||
                        b.RoomNumber.ToString().Contains(searchTerm)
                    );
                }

                // Debugging output
                if (bookings == null || !bookings.Any())
                {
                    MessageBox.Show("No bookings found.");
                    return;
                }

                // Add rows to DataGridView
                foreach (var booking in bookings)
                {
                    dataGridViewBookings.Rows.Add(
                        false,
                        booking.BookingID,
                        booking.RoomID,
                        booking.BookingDate.ToShortDateString(),
                        booking.GuestFullName,
                        booking.NumberOfGuests,
                        booking.CheckInDate.ToShortDateString(),
                        booking.CheckOutDate.ToShortDateString(),
                        booking.RoomNumber,
                        booking.RoomTypeName,
                        booking.BookingStatus.ToString(),
                        booking.GuestID
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }


        private void addBookingButton_Click(object sender, EventArgs e)
        {
            RoomBookingForm roomBookingForm = new RoomBookingForm();
            roomBookingForm.ShowDialog();
        }

        private void editBookingButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridViewBookings.SelectedRows[0];

                int bookingID = (int)selectedRow.Cells["BookingID"].Value;
                int roomID = (int)selectedRow.Cells["RoomID"].Value;
                int guestID = (int)selectedRow.Cells["GuestID"].Value;

           
                if (DateTime.TryParse(selectedRow.Cells["CheckInDate"].Value.ToString(), out DateTime checkInDate) &&
                    DateTime.TryParse(selectedRow.Cells["CheckOutDate"].Value.ToString(), out DateTime checkOutDate))
                {
                    // Open the EditBooking form with the selected booking details
                    EditBooking editBookingForm = new EditBooking(bookingID, roomID, guestID, checkInDate, checkOutDate);
                    editBookingForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Check-In or Check-Out date.");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to edit.");
            }
        }

        private void dataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                // Fetch the BookingID, RoomID, CheckInDate, and CheckOutDate from the selected row
                int bookingID = (int)dataGridViewBookings.Rows[e.RowIndex].Cells["BookingID"].Value;
                int roomID = (int)dataGridViewBookings.Rows[e.RowIndex].Cells["RoomID"].Value;
                int guestID = (int)dataGridViewBookings.Rows[e.RowIndex].Cells["GuestID"].Value;

                // Use TryParse to convert string to DateTime
                if (DateTime.TryParse(dataGridViewBookings.Rows[e.RowIndex].Cells["CheckInDate"].Value.ToString(), out DateTime checkInDate) &&
                    DateTime.TryParse(dataGridViewBookings.Rows[e.RowIndex].Cells["CheckOutDate"].Value.ToString(), out DateTime checkOutDate))
                {
   
                    MessageBox.Show($"Selected Booking ID: {bookingID}\nRoom ID: {roomID}\nCheck-In Date: {checkInDate.ToShortDateString()}\nCheck-Out Date: {checkOutDate.ToShortDateString()}");
                }
                else
                {
                    MessageBox.Show("Invalid Check-In or Check-Out date.");
                }
            }
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridViewBookings.SelectedRows[0];
                int bookingID = (int)selectedRow.Cells["BookingID"].Value;

                if (DateTime.TryParse(selectedRow.Cells["CheckInDate"].Value.ToString(), out DateTime checkInDate))
                {
                    if (checkInDate.Date == DateTime.Today)
                    {
                        bool isUpdated = _bookingService.UpdateBookingStatus(bookingID, "Confirmed");

                        if (isUpdated)
                        {
                            MessageBox.Show("Booking status updated to Confirmed.");
                            LoadBookings(); // Refresh the booking list
                        }
                        else
                        {
                            MessageBox.Show("Failed to update booking status. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can only check in on the day of the check-in date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Check-In date.");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to check in.");
            }
        }
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewBookings.SelectedRows[0];
                int bookingID = (int)selectedRow.Cells["BookingID"].Value;

                if (DateTime.TryParse(selectedRow.Cells["CheckInDate"].Value.ToString(), out DateTime checkInDate))
                {
                    if (checkInDate.Date <= DateTime.Today)
                    {
                        bool isUpdated = _bookingService.UpdateBookingStatus(bookingID, BookingStatus.Completed.ToString());

                        if (isUpdated)
                        {
                            MessageBox.Show("Checkout successful! Booking status updated to 'Completed'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBookings(); // Refresh the booking list
                        }
                        else
                        {
                            MessageBox.Show("Failed to update booking status. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can only check out on or after the check-in date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Check-In date.");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to check out.");
            }
        }
        private void CancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridViewBookings.SelectedRows[0];
                int bookingID = (int)selectedRow.Cells["BookingID"].Value;

                if (DateTime.TryParse(selectedRow.Cells["CheckInDate"].Value.ToString(), out DateTime checkInDate))
                {
                    // Check if the check-in date is at least two days away
                    if (checkInDate.Date > DateTime.Today.AddDays(2))
                    {
                        bool isUpdated = _bookingService.UpdateBookingStatus(bookingID, "Canceled");
                        bool isPaymentUpdated = _invoiceService.UpdatePaymentStatus(bookingID, "Refunded");

                        if (isUpdated && isPaymentUpdated)
                        {
                            MessageBox.Show("Booking has been successfully canceled, and payment status updated to 'Refunded'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBookings(); // Refresh the booking list
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel booking or update payment status. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can only cancel bookings that are at least two days away from the check-in date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Check-In date.");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridViewBookings.SelectedRows[0];
                int bookingID = (int)selectedRow.Cells["BookingID"].Value;
                string bookingStatus = selectedRow.Cells["Column8"].Value.ToString(); // Get the booking status

                // 
                if (bookingStatus != "Completed" && bookingStatus != "Canceled")
                {
                    MessageBox.Show("Only completed or canceled bookings can be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                // Confirm the delete action
                var confirmResult = MessageBox.Show("Are you sure you want to delete this booking?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = _bookingService.SoftDeleteBooking(bookingID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Booking has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings(); // Refresh the booking list
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}