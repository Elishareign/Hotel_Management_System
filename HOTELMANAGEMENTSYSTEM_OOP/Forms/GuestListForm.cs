using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class GuestListForm : Form
    {
        private readonly GuestService _guestService;

        public GuestListForm()
        {
            InitializeComponent();
            _guestService = new GuestService(new SQLiteGuestRepository()); // Initialize your service
            this.Load += new System.EventHandler(this.GuestListForm_Load);
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            LoadGuestBookingDetails(searchTerm);
        }


        private void GuestListForm_Load(object sender, EventArgs e)
        {
            LoadGuestBookingDetails();
        }

        private void LoadGuestBookingDetails(string searchTerm = "")
        {
            try
            {
                List<GuestBookingInfo> guestBookingInfos = _guestService.GetGuestBookingDetails();

                // Filter guest bookings based on the search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    guestBookingInfos = guestBookingInfos.FindAll(g =>
                        g.GuestName.ToLower().Contains(searchTerm) ||
                        g.GuestID.ToString().Contains(searchTerm) ||
                        g.EmailAddress.ToLower().Contains(searchTerm)
                    );
                }

                Console.WriteLine($"Number of guest bookings retrieved: {guestBookingInfos.Count}");

                if (guestBookingInfos.Count == 0)
                {
                    MessageBox.Show("No guest bookings found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear existing rows
                dataGridViewGuestList.Rows.Clear();

                // Add filtered guest booking details to DataGridView
                foreach (var bookingInfo in guestBookingInfos)
                {
                    dataGridViewGuestList.Rows.Add(
                        false,
                        bookingInfo.GuestID,
                        bookingInfo.GuestName,
                        bookingInfo.ContactNo,
                        bookingInfo.RoomTypeName,
                        bookingInfo.RoomNumber,
                        bookingInfo.CheckInDate,
                        bookingInfo.CheckOutDate,
                        bookingInfo.EmailAddress
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guest booking details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
