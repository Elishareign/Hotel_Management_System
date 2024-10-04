using FontAwesome.Sharp;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;


namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{

    public partial class DashboardFrm : Form
    {
        private BookingService bookingService;
        private IBookingRepository bookingRepository;
        private RoomService roomService;
        private IRoomRepository roomRepository;
        private IconButton currentBtn;
        private Panel rightBorderBtn;
        private Form currentChildForm;
        private bool isDashboardActive = true;
        private InvoiceService invoiceService;
        private IInvoiceRepository invoiceRepository;

        public DashboardFrm(Model.User loggedInUser)
        {
            InitializeComponent();
            rightBorderBtn = new Panel();
            rightBorderBtn.Size = new Size(2, 5);
            rightBorderBtn.BackColor = Color.White;
            panelMenu.Controls.Add(rightBorderBtn);


            // Form Layout
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            roomRepository = new SQLiteRoomRepository();
            roomService = new RoomService(roomRepository);
            bookingRepository = new SQLiteBookingRepository();
            bookingService = new BookingService(bookingRepository);
            invoiceRepository = new SQLiteInvoiceRepository();
            invoiceService = new InvoiceService(invoiceRepository);

        // Display totals in label
        DisplayTotalBookingsAndAvailableRooms();
            DisplayConfirmedBookings();
            DisplayCompletedBookings();
            DisplayTodayCheckIns();


            // Initialize buttons
            InitializeButtons();
        }


        private void DisplayTotalBookingsAndAvailableRooms()
        {
            // Get the total booking count
            int totalBookingCount = bookingService.CountTotalBookings();

            // Get the available room count
            int availableRoomCount = roomService.GetAvailableRoomCount();

            // Display the counts in the labels
            lblBooking.Text = $"{totalBookingCount}";
            lblAvailableRooms.Text = $"{availableRoomCount}";
        }


        private void DisplayConfirmedBookings()
        {
            // Get the total confirmed booking count
            int confirmedBookingCount = bookingService.CountConfirmedBookings();

            // Display the count in the label
            lblConfirmedBooking.Text = $"{confirmedBookingCount}";
        }

        private void DisplayCompletedBookings()
        {
            // Get the total confirmed booking count
            int completedBookingCount = bookingService.CountCompletedBookings();

            // Display the count in the label
            lblCompletedBooking.Text = $"{completedBookingCount}";
        }


        private void InitializeButtons()
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is IconButton)
                {
                    ctrl.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        // Methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 70, 116);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;


                currentBtn.Width -= 10;

                // Set border radius
                int borderRadius = 20;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(currentBtn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(currentBtn.Width - borderRadius, currentBtn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, currentBtn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();
                currentBtn.Region = new Region(path);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 7, 45);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;


                currentBtn.Width += 10;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Close the current child form if it exists.
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Set Dashboard as inactive since a new form is opened
            isDashboardActive = false;
        }

        private void Booking_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new BookingListForm());
        }

        private void Room_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new RoomListForm());
        }

        private void Guests_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new GuestListForm());
        }

        private void Invoices_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // Create an instance of InvoiceListForm with InvoiceDisplayDTO
            OpenChildForm(new InvoiceListForm());
        }


        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            // Only activate the Dashboard if it is not already active
            if (!isDashboardActive)
            {
                ActivateButton(sender);
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    currentChildForm = null;
                }
                isDashboardActive = true;
            }
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (invoiceService != null)
            {
                ReportForm reportForm = new ReportForm(invoiceService);
                OpenChildForm(reportForm);
            }
            else
            {
                MessageBox.Show("InvoiceService is not initialized.");
            }
        }

    
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximized_WindowButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimized_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // To drag the window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void windowDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayTodayCheckIns()
        {
            var todayCheckIns = bookingService.GetTodayCheckIns();

            dataGridViewTodayCheckIns.Rows.Clear();
            foreach (var checkIn in todayCheckIns)
            {
                dataGridViewTodayCheckIns.Rows.Add(
                    checkIn.BookingID,
                    checkIn.BookingDate,
                    checkIn.GuestName,
                    checkIn.RoomNumber,
                    checkIn.RoomTypeName,
                    checkIn.CheckInDate
                );
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DisplayTodayCheckIns();
        }

    }
}

