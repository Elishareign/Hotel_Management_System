namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class DashboardFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFrm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Dashboard_Button = new FontAwesome.Sharp.IconButton();
            panelMenu = new Customs.RoundedPanel();
            pictureBox3 = new PictureBox();
            Report_Button = new FontAwesome.Sharp.IconButton();
            Invoices_Button = new FontAwesome.Sharp.IconButton();
            Guests_Button = new FontAwesome.Sharp.IconButton();
            Room_Button = new FontAwesome.Sharp.IconButton();
            Booking_Button = new FontAwesome.Sharp.IconButton();
            roundedPanel2 = new Customs.RoundedPanel();
            Maximized_Button = new FontAwesome.Sharp.IconButton();
            Exit_Button = new FontAwesome.Sharp.IconButton();
            Minimized_Button = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblBooking = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Customs.RoundedPanel();
            roundedPanel4 = new Customs.RoundedPanel();
            lblCompletedBooking = new Label();
            label12 = new Label();
            roundedPanel12 = new Customs.RoundedPanel();
            roundedPanel3 = new Customs.RoundedPanel();
            lblConfirmedBooking = new Label();
            roundedPanel11 = new Customs.RoundedPanel();
            roundedPanel1 = new Customs.RoundedPanel();
            lblAvailableRooms = new Label();
            roundedPanel10 = new Customs.RoundedPanel();
            roundedPanel9 = new Customs.RoundedPanel();
            roundedPanel8 = new Customs.RoundedPanel();
            roundedPanel6 = new Customs.RoundedPanel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            dataGridViewTodayCheckIns = new DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panelDesktop.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel9.SuspendLayout();
            roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTodayCheckIns).BeginInit();
            SuspendLayout();
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dashboard_Button.FlatAppearance.BorderSize = 0;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Dashboard_Button.ForeColor = Color.White;
            Dashboard_Button.IconChar = FontAwesome.Sharp.IconChar.Clock;
            Dashboard_Button.IconColor = Color.White;
            Dashboard_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Dashboard_Button.IconSize = 30;
            Dashboard_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.Location = new Point(8, 213);
            Dashboard_Button.Margin = new Padding(3, 2, 3, 2);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Padding = new Padding(20, 0, 20, 0);
            Dashboard_Button.Size = new Size(233, 62);
            Dashboard_Button.TabIndex = 31;
            Dashboard_Button.Text = "DASHBOARD";
            Dashboard_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashboard_Button.UseVisualStyleBackColor = true;
            Dashboard_Button.Click += Dashboard_Button_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 7, 45);
            panelMenu.BorderColor = Color.FromArgb(0, 7, 45);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(Report_Button);
            panelMenu.Controls.Add(Invoices_Button);
            panelMenu.Controls.Add(Guests_Button);
            panelMenu.Controls.Add(Room_Button);
            panelMenu.Controls.Add(Booking_Button);
            panelMenu.Controls.Add(Dashboard_Button);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(4, 1);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(10, 0, 10, 0);
            panelMenu.Radius = 10;
            panelMenu.Size = new Size(247, 981);
            panelMenu.TabIndex = 32;
            panelMenu.Thickness = 2F;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._446021771_441181385447245_7163526141246612465_n;
            pictureBox3.Location = new Point(8, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 162);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // Report_Button
            // 
            Report_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Report_Button.FlatAppearance.BorderSize = 0;
            Report_Button.FlatStyle = FlatStyle.Flat;
            Report_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Report_Button.ForeColor = Color.White;
            Report_Button.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            Report_Button.IconColor = Color.White;
            Report_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Report_Button.IconSize = 30;
            Report_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Report_Button.Location = new Point(8, 553);
            Report_Button.Margin = new Padding(3, 2, 3, 2);
            Report_Button.Name = "Report_Button";
            Report_Button.Padding = new Padding(20, 0, 20, 0);
            Report_Button.Size = new Size(233, 62);
            Report_Button.TabIndex = 37;
            Report_Button.Text = "REPORT";
            Report_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Report_Button.UseVisualStyleBackColor = true;
            Report_Button.Click += Report_Button_Click;
            // 
            // Invoices_Button
            // 
            Invoices_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Invoices_Button.FlatAppearance.BorderSize = 0;
            Invoices_Button.FlatStyle = FlatStyle.Flat;
            Invoices_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Invoices_Button.ForeColor = Color.White;
            Invoices_Button.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            Invoices_Button.IconColor = Color.White;
            Invoices_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Invoices_Button.IconSize = 30;
            Invoices_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Invoices_Button.Location = new Point(8, 485);
            Invoices_Button.Margin = new Padding(3, 2, 3, 2);
            Invoices_Button.Name = "Invoices_Button";
            Invoices_Button.Padding = new Padding(20, 0, 20, 0);
            Invoices_Button.Size = new Size(233, 62);
            Invoices_Button.TabIndex = 36;
            Invoices_Button.Text = "INVOICES";
            Invoices_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Invoices_Button.UseVisualStyleBackColor = true;
            Invoices_Button.Click += Invoices_Button_Click;
            // 
            // Guests_Button
            // 
            Guests_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Guests_Button.FlatAppearance.BorderSize = 0;
            Guests_Button.FlatStyle = FlatStyle.Flat;
            Guests_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Guests_Button.ForeColor = Color.White;
            Guests_Button.IconChar = FontAwesome.Sharp.IconChar.Person;
            Guests_Button.IconColor = Color.White;
            Guests_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Guests_Button.IconSize = 30;
            Guests_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Guests_Button.Location = new Point(8, 417);
            Guests_Button.Margin = new Padding(3, 2, 3, 2);
            Guests_Button.Name = "Guests_Button";
            Guests_Button.Padding = new Padding(20, 0, 20, 0);
            Guests_Button.Size = new Size(233, 62);
            Guests_Button.TabIndex = 35;
            Guests_Button.Text = "GUESTS";
            Guests_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Guests_Button.UseVisualStyleBackColor = true;
            Guests_Button.Click += Guests_Button_Click;
            // 
            // Room_Button
            // 
            Room_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Room_Button.FlatAppearance.BorderSize = 0;
            Room_Button.FlatStyle = FlatStyle.Flat;
            Room_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Room_Button.ForeColor = Color.White;
            Room_Button.IconChar = FontAwesome.Sharp.IconChar.Bed;
            Room_Button.IconColor = Color.White;
            Room_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Room_Button.IconSize = 30;
            Room_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Room_Button.Location = new Point(8, 349);
            Room_Button.Margin = new Padding(3, 2, 3, 2);
            Room_Button.Name = "Room_Button";
            Room_Button.Padding = new Padding(20, 0, 20, 0);
            Room_Button.Size = new Size(233, 62);
            Room_Button.TabIndex = 34;
            Room_Button.Text = "ROOMS";
            Room_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Room_Button.UseVisualStyleBackColor = true;
            Room_Button.Click += Room_Button_Click;
            // 
            // Booking_Button
            // 
            Booking_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Booking_Button.FlatAppearance.BorderSize = 0;
            Booking_Button.FlatStyle = FlatStyle.Flat;
            Booking_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Booking_Button.ForeColor = Color.White;
            Booking_Button.IconChar = FontAwesome.Sharp.IconChar.Book;
            Booking_Button.IconColor = Color.White;
            Booking_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Booking_Button.IconSize = 30;
            Booking_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Booking_Button.Location = new Point(8, 281);
            Booking_Button.Margin = new Padding(3, 2, 3, 2);
            Booking_Button.Name = "Booking_Button";
            Booking_Button.Padding = new Padding(20, 0, 20, 0);
            Booking_Button.Size = new Size(233, 62);
            Booking_Button.TabIndex = 33;
            Booking_Button.Text = "BOOKING";
            Booking_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Booking_Button.UseVisualStyleBackColor = true;
            Booking_Button.Click += Booking_Button_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = SystemColors.Control;
            roundedPanel2.BorderColor = SystemColors.Control;
            roundedPanel2.Controls.Add(Maximized_Button);
            roundedPanel2.Controls.Add(Exit_Button);
            roundedPanel2.Controls.Add(Minimized_Button);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.Location = new Point(251, 1);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(5, 5, 10, 0);
            roundedPanel2.Radius = 20;
            roundedPanel2.Size = new Size(1237, 26);
            roundedPanel2.TabIndex = 33;
            roundedPanel2.Thickness = 5F;
            roundedPanel2.MouseDown += panelMenu_MouseDown;
            // 
            // Maximized_Button
            // 
            Maximized_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximized_Button.IconChar = FontAwesome.Sharp.IconChar.Square;
            Maximized_Button.IconColor = Color.Black;
            Maximized_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Maximized_Button.IconSize = 18;
            Maximized_Button.Location = new Point(1165, 0);
            Maximized_Button.Name = "Maximized_Button";
            Maximized_Button.Size = new Size(31, 23);
            Maximized_Button.TabIndex = 2;
            Maximized_Button.UseVisualStyleBackColor = true;
            Maximized_Button.Click += Maximized_WindowButton_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit_Button.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            Exit_Button.IconColor = Color.Black;
            Exit_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Exit_Button.IconSize = 20;
            Exit_Button.Location = new Point(1195, 2);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(34, 21);
            Exit_Button.TabIndex = 1;
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Minimized_Button
            // 
            Minimized_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimized_Button.IconChar = FontAwesome.Sharp.IconChar.Minus;
            Minimized_Button.IconColor = Color.Black;
            Minimized_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Minimized_Button.IconSize = 20;
            Minimized_Button.Location = new Point(1131, 2);
            Minimized_Button.Name = "Minimized_Button";
            Minimized_Button.Size = new Size(34, 22);
            Minimized_Button.TabIndex = 0;
            Minimized_Button.UseVisualStyleBackColor = true;
            Minimized_Button.Click += Minimized_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // lblBooking
            // 
            lblBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBooking.BackColor = Color.Transparent;
            lblBooking.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooking.ForeColor = Color.Black;
            lblBooking.Location = new Point(164, 69);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(74, 59);
            lblBooking.TabIndex = 3;
            lblBooking.Text = "50";
            lblBooking.TextAlign = ContentAlignment.MiddleRight;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 44;
            iconPictureBox1.Location = new Point(18, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(44, 52);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(70, 19);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 1;
            label3.Text = "New Booking";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = Color.FromArgb(0, 7, 45);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconPictureBox3.IconColor = Color.FromArgb(0, 7, 45);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 42;
            iconPictureBox3.Location = new Point(15, 12);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(42, 50);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox3.TabIndex = 13;
            iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 7, 45);
            label4.Location = new Point(61, 21);
            label4.Name = "label4";
            label4.Size = new Size(201, 27);
            label4.TabIndex = 12;
            label4.Text = "Rooms Available";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 7, 45);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            iconPictureBox2.IconColor = Color.FromArgb(0, 7, 45);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 42;
            iconPictureBox2.Location = new Point(30, 16);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(42, 50);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 13;
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 7, 45);
            label2.Location = new Point(78, 19);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 12;
            label2.Text = "Check-In";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.White;
            iconPictureBox4.ForeColor = Color.Black;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconPictureBox4.IconColor = Color.Black;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 50;
            iconPictureBox4.Location = new Point(19, 14);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(58, 50);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox4.TabIndex = 12;
            iconPictureBox4.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.BackColor = SystemColors.Control;
            panelDesktop.BorderColor = SystemColors.Control;
            panelDesktop.Controls.Add(roundedPanel4);
            panelDesktop.Controls.Add(roundedPanel12);
            panelDesktop.Controls.Add(roundedPanel3);
            panelDesktop.Controls.Add(roundedPanel11);
            panelDesktop.Controls.Add(roundedPanel1);
            panelDesktop.Controls.Add(roundedPanel10);
            panelDesktop.Controls.Add(roundedPanel9);
            panelDesktop.Controls.Add(roundedPanel8);
            panelDesktop.Controls.Add(roundedPanel6);
            panelDesktop.Controls.Add(label1);
            panelDesktop.Location = new Point(251, 27);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Padding = new Padding(10);
            panelDesktop.Radius = 50;
            panelDesktop.Size = new Size(1237, 952);
            panelDesktop.TabIndex = 34;
            panelDesktop.Thickness = 5F;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.None;
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.BorderColor = Color.White;
            roundedPanel4.Controls.Add(lblCompletedBooking);
            roundedPanel4.Controls.Add(iconPictureBox4);
            roundedPanel4.Controls.Add(label12);
            roundedPanel4.Location = new Point(931, 93);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Padding = new Padding(5);
            roundedPanel4.Radius = 25;
            roundedPanel4.Size = new Size(268, 142);
            roundedPanel4.TabIndex = 30;
            roundedPanel4.Thickness = 2F;
            // 
            // lblCompletedBooking
            // 
            lblCompletedBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCompletedBooking.BackColor = Color.Transparent;
            lblCompletedBooking.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompletedBooking.ForeColor = Color.Black;
            lblCompletedBooking.Location = new Point(163, 63);
            lblCompletedBooking.Name = "lblCompletedBooking";
            lblCompletedBooking.Size = new Size(74, 59);
            lblCompletedBooking.TabIndex = 3;
            lblCompletedBooking.Text = "50";
            lblCompletedBooking.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 7, 45);
            label12.Location = new Point(83, 24);
            label12.Name = "label12";
            label12.Size = new Size(140, 28);
            label12.TabIndex = 12;
            label12.Text = "Check-Out";
            // 
            // roundedPanel12
            // 
            roundedPanel12.Anchor = AnchorStyles.None;
            roundedPanel12.BackColor = Color.FromArgb(166, 124, 0);
            roundedPanel12.BorderColor = Color.White;
            roundedPanel12.Location = new Point(940, 104);
            roundedPanel12.Name = "roundedPanel12";
            roundedPanel12.Padding = new Padding(5);
            roundedPanel12.Radius = 25;
            roundedPanel12.Size = new Size(268, 140);
            roundedPanel12.TabIndex = 29;
            roundedPanel12.Thickness = 2F;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.None;
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderColor = Color.White;
            roundedPanel3.Controls.Add(lblConfirmedBooking);
            roundedPanel3.Controls.Add(iconPictureBox2);
            roundedPanel3.Controls.Add(label2);
            roundedPanel3.Location = new Point(635, 93);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Padding = new Padding(5);
            roundedPanel3.Radius = 25;
            roundedPanel3.Size = new Size(268, 142);
            roundedPanel3.TabIndex = 28;
            roundedPanel3.Thickness = 2F;
            // 
            // lblConfirmedBooking
            // 
            lblConfirmedBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConfirmedBooking.BackColor = Color.Transparent;
            lblConfirmedBooking.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmedBooking.ForeColor = Color.Black;
            lblConfirmedBooking.Location = new Point(161, 63);
            lblConfirmedBooking.Name = "lblConfirmedBooking";
            lblConfirmedBooking.Size = new Size(74, 59);
            lblConfirmedBooking.TabIndex = 3;
            lblConfirmedBooking.Text = "50";
            lblConfirmedBooking.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roundedPanel11
            // 
            roundedPanel11.Anchor = AnchorStyles.None;
            roundedPanel11.BackColor = Color.FromArgb(64, 68, 114);
            roundedPanel11.BorderColor = Color.White;
            roundedPanel11.Location = new Point(644, 104);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Padding = new Padding(5);
            roundedPanel11.Radius = 25;
            roundedPanel11.Size = new Size(268, 140);
            roundedPanel11.TabIndex = 27;
            roundedPanel11.Thickness = 2F;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(lblAvailableRooms);
            roundedPanel1.Controls.Add(iconPictureBox3);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(333, 92);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5);
            roundedPanel1.Radius = 25;
            roundedPanel1.Size = new Size(268, 142);
            roundedPanel1.TabIndex = 26;
            roundedPanel1.Thickness = 2F;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableRooms.BackColor = Color.Transparent;
            lblAvailableRooms.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRooms.ForeColor = Color.Black;
            lblAvailableRooms.Location = new Point(161, 70);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(74, 59);
            lblAvailableRooms.TabIndex = 3;
            lblAvailableRooms.Text = "50";
            lblAvailableRooms.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roundedPanel10
            // 
            roundedPanel10.Anchor = AnchorStyles.None;
            roundedPanel10.BackColor = Color.FromArgb(212, 177, 57);
            roundedPanel10.BorderColor = Color.White;
            roundedPanel10.Location = new Point(342, 103);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Padding = new Padding(5);
            roundedPanel10.Radius = 25;
            roundedPanel10.Size = new Size(268, 140);
            roundedPanel10.TabIndex = 25;
            roundedPanel10.Thickness = 2F;
            // 
            // roundedPanel9
            // 
            roundedPanel9.Anchor = AnchorStyles.None;
            roundedPanel9.BackColor = Color.White;
            roundedPanel9.BorderColor = Color.White;
            roundedPanel9.Controls.Add(label3);
            roundedPanel9.Controls.Add(iconPictureBox1);
            roundedPanel9.Controls.Add(lblBooking);
            roundedPanel9.Location = new Point(28, 93);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Padding = new Padding(5);
            roundedPanel9.Radius = 25;
            roundedPanel9.Size = new Size(268, 142);
            roundedPanel9.TabIndex = 24;
            roundedPanel9.Thickness = 2F;
            // 
            // roundedPanel8
            // 
            roundedPanel8.Anchor = AnchorStyles.None;
            roundedPanel8.BackColor = Color.FromArgb(92, 95, 124);
            roundedPanel8.BorderColor = Color.White;
            roundedPanel8.Location = new Point(37, 104);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Padding = new Padding(5);
            roundedPanel8.Radius = 25;
            roundedPanel8.Size = new Size(268, 140);
            roundedPanel8.TabIndex = 23;
            roundedPanel8.Thickness = 2F;
            // 
            // roundedPanel6
            // 
            roundedPanel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel6.BackColor = Color.White;
            roundedPanel6.BorderColor = Color.White;
            roundedPanel6.Controls.Add(pictureBox1);
            roundedPanel6.Controls.Add(label6);
            roundedPanel6.Controls.Add(dataGridViewTodayCheckIns);
            roundedPanel6.Location = new Point(13, 303);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Radius = 2;
            roundedPanel6.Size = new Size(1211, 633);
            roundedPanel6.TabIndex = 21;
            roundedPanel6.Thickness = 5F;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1143, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 7, 45);
            label6.Location = new Point(11, 9);
            label6.Name = "label6";
            label6.Size = new Size(205, 23);
            label6.TabIndex = 14;
            label6.Text = "Upcoming Check-Ins";
            // 
            // dataGridViewTodayCheckIns
            // 
            dataGridViewTodayCheckIns.AllowUserToAddRows = false;
            dataGridViewTodayCheckIns.AllowUserToDeleteRows = false;
            dataGridViewTodayCheckIns.AllowUserToResizeRows = false;
            dataGridViewTodayCheckIns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTodayCheckIns.BackgroundColor = Color.White;
            dataGridViewTodayCheckIns.BorderStyle = BorderStyle.None;
            dataGridViewTodayCheckIns.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewTodayCheckIns.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTodayCheckIns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTodayCheckIns.ColumnHeadersHeight = 30;
            dataGridViewTodayCheckIns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTodayCheckIns.Columns.AddRange(new DataGridViewColumn[] { BookingID, Column1, Column2, Column3, Column5, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewTodayCheckIns.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTodayCheckIns.EnableHeadersVisualStyles = false;
            dataGridViewTodayCheckIns.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewTodayCheckIns.Location = new Point(16, 50);
            dataGridViewTodayCheckIns.Name = "dataGridViewTodayCheckIns";
            dataGridViewTodayCheckIns.ReadOnly = true;
            dataGridViewTodayCheckIns.RowHeadersVisible = false;
            dataGridViewTodayCheckIns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTodayCheckIns.Size = new Size(1179, 563);
            dataGridViewTodayCheckIns.TabIndex = 0;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "Booking ID";
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            BookingID.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Booking Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Guest Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Room Number";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Room Type";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle2;
            Column4.HeaderText = "Check-In Date";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // DashboardFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1489, 983);
            Controls.Add(panelDesktop);
            Controls.Add(roundedPanel2);
            Controls.Add(panelMenu);
            ForeColor = Color.Transparent;
            Name = "DashboardFrm";
            Padding = new Padding(4, 1, 1, 1);
            Text = "DashboardFrm";
            MouseDown += windowDashboard_MouseDown;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel9.ResumeLayout(false);
            roundedPanel9.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTodayCheckIns).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton Dashboard_Button;
        private Customs.RoundedPanel panelMenu;
        private FontAwesome.Sharp.IconButton Report_Button;
        private FontAwesome.Sharp.IconButton Invoices_Button;
        private FontAwesome.Sharp.IconButton Guests_Button;
        private FontAwesome.Sharp.IconButton Room_Button;
        private FontAwesome.Sharp.IconButton Booking_Button;
        private Customs.RoundedPanel roundedPanel2;
        private FontAwesome.Sharp.IconButton Minimized_Button;
        private FontAwesome.Sharp.IconButton Maximized_Button;
        private FontAwesome.Sharp.IconButton Exit_Button;
        private Label label1;
        private Customs.RoundedButtonVer2 roundedButtonVer21;
        private Customs.RoundedButtonVer2 roundedButtonVer22;
        private Customs.RoundedButtonVer2 roundedButtonVer24;
        private Customs.RoundedButtonVer2 roundedButtonVer23;
        private Customs.RoundedButtonVer2 roundedButtonVer26;
        private Label lblBooking;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Customs.RoundedPanel panelDesktop;
        private Customs.RoundedPanel roundedPanel6;
        private DataGridView dataGridViewTodayCheckIns;
        private PictureBox pictureBox1;
        private Label label6;
        private Customs.RoundedPanel roundedPanel9;
        private Customs.RoundedPanel roundedPanel8;
        private Customs.RoundedPanel roundedPanel3;
        private Label lblConfirmedBooking;
        private Customs.RoundedPanel roundedPanel11;
        private Customs.RoundedPanel roundedPanel1;
        private Label lblAvailableRooms;
        private Customs.RoundedPanel roundedPanel10;
        private Customs.RoundedPanel roundedPanel4;
        private Label lblCompletedBooking;
        private Label label12;
        private Customs.RoundedPanel roundedPanel12;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}