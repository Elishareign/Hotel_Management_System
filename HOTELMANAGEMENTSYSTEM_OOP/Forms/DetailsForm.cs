using System;
using System.Text;
using System.Windows.Forms;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Utils;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class DetailsForm : Form
    {
        private EmailValidator emailValidator = new EmailValidator();
        private RoomDetails roomDetails;
        private DateTime fromDate;
        private DateTime toDate;


        private BookingService bookingService;
        private InvoiceService invoiceService;

        public DetailsForm(RoomDetails roomDetails, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            // Initialize fields
            this.roomDetails = roomDetails;
            this.fromDate = fromDate;
            this.toDate = toDate;

            // Initialize services
            this.bookingService = new BookingService(new SQLiteBookingRepository());
            this.invoiceService = new InvoiceService(new SQLiteInvoiceRepository());

            DisplayRoomDetails();
            LoadRoomImage(roomDetails.RoomTypeName);
        }

        private void LoadRoomImage(string roomTypeName)
        {
            // Load room image based on room type
            switch (roomTypeName)
            {
                case "Standard Room":
                    pictureBoxRoom.Image = Properties.Resources.standardRoomImage;
                    break;
                case "Deluxe Room":
                    pictureBoxRoom.Image = Properties.Resources.deluxeRoomImage;
                    break;
                case "Suite":
                    pictureBoxRoom.Image = Properties.Resources.suiteImage;
                    break;
                default:
                    // Handle default case (if needed)
                    break;
            }
        }

        private void DisplayRoomDetails()
        {
            // Display room details in labels
            lblRoomNumber.Text = roomDetails.RoomNumber.ToString();
            lblFloorNumber.Text = roomDetails.FloorNumber.ToString();
            lblRoomType.Text = roomDetails.RoomTypeName;
            lblPricePerNight.Text = roomDetails.PricePerNight.ToString("C");
            lblNumberOfBeds.Text = roomDetails.NumberOfBeds.ToString();
            lblCapacity.Text = roomDetails.Capacity.ToString();

            // Concatenate all amenities into a single string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < roomDetails.Amenities.Count; i++)
            {
                sb.Append(roomDetails.Amenities[i].AmenityName);

                if (i < roomDetails.Amenities.Count - 1)
                    sb.Append(", ");

                if ((i + 1) % 2 == 0 && i < roomDetails.Amenities.Count - 1)
                    sb.AppendLine();
            }

            string amenitiesText = sb.ToString();
            lblAmenities.Text = amenitiesText;

            // Display total amenity price
            lblTotalAmenityPrice.Text = roomDetails.TotalAmenityPrice.ToString("C");

            // Display booking dates
            lblFromDate.Text = $"From: {fromDate.ToShortDateString()}";
            lblToDate.Text = $"To: {toDate.ToShortDateString()}";

            // Calculate and display stay duration
            int stayDuration = (toDate - fromDate).Days;
            lblStayDuration.Text = $"{stayDuration} day/s";

            // Calculate and display total room rate
            decimal totalRoomRate = stayDuration * roomDetails.PricePerNight;
            lblTotalRoomRate.Text = $"{totalRoomRate.ToString("C")}";

            // Calculate and display VAT using the static VATPercentage
            decimal vat = totalRoomRate * Invoice.VATPercentage;
            lblVAT.Text = $"{vat.ToString("C")}";

            // Calculate and display total amount including amenities
            decimal totalAmount = totalRoomRate + roomDetails.TotalAmenityPrice + vat;
            lblTotalAmount.Text = $"{totalAmount.ToString("C")}";
        }

        private void SubmitBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and collect guest information
                string firstName = txtFirstName.Texts.Trim();
                string middleName = txtMiddleName.Texts.Trim();
                string lastName = txtLastName.Texts.Trim();
                string guestEmail = txtEmail.Texts.Trim();

                if (!long.TryParse(txtContactNo.Texts.Trim(), out long guestContactNo))
                {
                    MessageBox.Show("Please enter a valid integer for Contact Number.");
                    return;
                }

                if (txtContactNo.Texts.Trim().Length != 11)
                {
                    MessageBox.Show("Contact Number must be exactly 11 digits.");
                    return;
                }

                if (!emailValidator.IsValidEmail(guestEmail))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Create guest object
                Guest guest = new Guest(0, firstName, middleName, lastName, guestEmail, guestContactNo);

                // Validate and collect booking information
                if (!int.TryParse(txtNumberOfGuests.Texts.Trim(), out int numberOfGuests))
                {
                    MessageBox.Show("Please enter a valid number for Number of Guests.");
                    return;
                }

                string specialRequest = txtSpecialRequests.Texts.Trim();

                // Create booking object
                Booking booking = new Booking()
                {
                    RoomID = roomDetails.RoomID,
                    NumberOfGuests = numberOfGuests,
                    CheckInDate = fromDate,
                    CheckOutDate = toDate,
                    BookingDate = DateTime.Today,
                    SpecialRequest = specialRequest,
                    BookingStatus = BookingStatus.Pending
                };

                // Add guest and booking using booking service
                bookingService.AddGuestAndBooking(guest, booking);

                // Ensure the booking ID is set
                if (booking.BookingID == 0)
                {
                    MessageBox.Show("Failed to create booking. Please try again.");
                    return;
                }

                MessageBox.Show("Booking added successfully!");

                // Generate and add invoice
                AddInvoiceToDatabase(guest, booking);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddInvoiceToDatabase(Guest guest, Booking booking)
        {
            try
            {
                // Calculate invoice details
                decimal totalRoomRate = (booking.CheckOutDate - booking.CheckInDate).Days * roomDetails.PricePerNight;
                decimal vat = totalRoomRate * Invoice.VATPercentage;
                decimal totalAmount = totalRoomRate + roomDetails.TotalAmenityPrice + vat;

                // Validate payment
                if (!decimal.TryParse(txtPayment.Texts.Trim(), out decimal payment))
                {
                    MessageBox.Show("Please enter a valid number for Payment.");
                    return;
                }

                // Check if payment equals totalAmount
                if (payment != totalAmount)
                {
                    MessageBox.Show($"Payment must be equal to the total amount of {totalAmount:C}.");
                    return;
                }


                PaymentStatus paymentStatus = PaymentStatus.Paid;

                // Retrieve selected payment method from ComboBox
                if (!Enum.TryParse(cmbPaymentMethod.SelectedItem.ToString(), out PaymentMethod paymentMethod))
                {
                    MessageBox.Show("Please select a valid payment method.");
                    return;
                }

                Invoice invoice = new Invoice(
                    booking.BookingID,  
                    booking.RoomID,        
                    DateTime.Now,         
                    totalAmount,          
                    paymentStatus,         
                    paymentMethod,        
                    payment             
                );

                // Add invoice to database 
                invoiceService.AddInvoice(invoice);

                MessageBox.Show("Invoice added successfully!");

                // Close this form 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
