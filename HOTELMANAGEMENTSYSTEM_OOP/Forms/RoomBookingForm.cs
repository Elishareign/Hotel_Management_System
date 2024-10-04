using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class RoomBookingForm : Form
    {
        private RoomService roomService;
        private List<Room> roomsWithStatus;
        private System.Drawing.Image availableIcon;
        private System.Drawing.Image selectedIcon;
        private System.Drawing.Image occupiedIcon;
        private System.Drawing.Image underMaintenanceIcon;
        private PictureBox currentlySelectedPictureBox;

        public RoomBookingForm()
        {
            InitializeComponent();

            // Initialize icons from resources 
            availableIcon = Properties.Resources.availableRoomss;
            selectedIcon = Properties.Resources.selectedRoomss;
            occupiedIcon = Properties.Resources.occupiedRoomss;
            underMaintenanceIcon = Properties.Resources.undermaintenanceRoomss;

            // Initialize SQLite connection and repository
            IRoomRepository roomRepository = new SQLiteRoomRepository();
            roomService = new RoomService(roomRepository);


            InitializePictureBoxes();
            LoadRoomsWithStatus();
        }

        private void InitializePictureBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pictureBox && pictureBox.Name.StartsWith("pictureBox"))
                {
                    pictureBox.Image = availableIcon;
                    pictureBox.Tag = "Available";
                    pictureBox.Enabled = true;
                    pictureBox.Click += PictureBox_Click;
                }
            }
        }

        private void LoadRoomsWithStatus()
        {
            DateTime fromDate = dtpStartDate.Value.Date;
            DateTime toDate = dtpEndDate.Value.Date;

            if (fromDate == DateTime.MinValue)
                fromDate = DateTime.Today;

            if (toDate == DateTime.MinValue)
                toDate = DateTime.Today;

            roomsWithStatus = roomService.GetAvailableRooms(fromDate, toDate);
            UpdatePictureBoxes();
        }

        private void UpdatePictureBoxes()
        {
            foreach (Room room in roomsWithStatus)
            {
                PictureBox pictureBox = this.Controls.Find($"pictureBox{room.RoomID}", true).FirstOrDefault() as PictureBox;

                if (pictureBox != null)
                {
                    pictureBox.Tag = room.RoomStatus.ToString();

                    switch (room.RoomStatus)
                    {
                        case Status.Available:
                            pictureBox.Image = availableIcon;
                            break;
                        case Status.Occupied:
                            pictureBox.Image = occupiedIcon;
                            break;
                        case Status.UnderMaintenance:
                            pictureBox.Image = underMaintenanceIcon;
                            break;

                    }
                }
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox.Tag.ToString() == "Available")
            {
                // If there is a currently selected PictureBox, revert it to Available
                if (currentlySelectedPictureBox != null)
                {
                    currentlySelectedPictureBox.Tag = "Available";
                    currentlySelectedPictureBox.Image = availableIcon;
                }

                // Update the clicked PictureBox to Selected
                pictureBox.Tag = "Selected";
                pictureBox.Image = selectedIcon;

                // Update the reference to the currently selected PictureBox
                currentlySelectedPictureBox = pictureBox;
            }
            else if (pictureBox.Tag.ToString() == "Selected")
            {
                // Revert the selected PictureBox to Available
                pictureBox.Tag = "Available";
                pictureBox.Image = availableIcon;

                // Clear the reference to the currently selected PictureBox
                currentlySelectedPictureBox = null;
            }
        }

        private void RoomBookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            LoadRoomsWithStatus();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (currentlySelectedPictureBox != null)
            {
                try
                {
                    int roomId = int.Parse(currentlySelectedPictureBox.Name.Replace("pictureBox", ""));
                    RoomDetails roomDetails = roomService.GetRoomDetailsById(roomId);

                    if (roomDetails != null)
                    {
                        // Pass dates from date pickers to DetailsForm
                        DateTime fromDate = dtpStartDate.Value.Date;
                        DateTime toDate = dtpEndDate.Value.Date;

                        // Validate date selection
                        if (fromDate >= toDate)
                        {
                            MessageBox.Show("Please select valid booking dates where 'From' date is before 'To' date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Show DetailsForm 
                        DetailsForm detailsForm = new DetailsForm(roomDetails, fromDate, toDate);
                        detailsForm.ShowDialog();

                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve room details. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid room selection. Please select a valid room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a room before confirming.", "Room selection required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}