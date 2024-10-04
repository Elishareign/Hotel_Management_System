namespace HOTELMANAGEMENTSYSTEM_OOP
{
    partial class EditBooking
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            label12 = new Label();
            dtpEndDate = new Customs.CustomDatePicker();
            dtpStartDate = new Customs.CustomDatePicker();
            txtNumberOfGuests = new Customs.TextBox();
            roundedPanel1 = new Customs.RoundedPanel();
            lblTotalAmount = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblGuestName = new Label();
            GuestName = new Label();
            label5 = new Label();
            lblNumberOfBeds = new Label();
            label55 = new Label();
            lblTotalAmenities = new Label();
            lblTotalRoomRate = new Label();
            lblVAT = new Label();
            lblPricePerNight = new Label();
            lblAmenities = new Label();
            lblGuestCapacity = new Label();
            lblFloorNumber = new Label();
            lblRoomNumber = new Label();
            lblRoomTypeName = new Label();
            lblStayDuration = new Label();
            lblCheckOutDate = new Label();
            lblCheckInDate = new Label();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            panel2 = new Panel();
            label30 = new Label();
            label14 = new Label();
            comboBoxFloorNumber = new Customs.CustomComboBox();
            comboBoxRoomType = new Customs.CustomComboBox();
            label15 = new Label();
            label17 = new Label();
            label19 = new Label();
            label3 = new Label();
            roundedButtonVer22 = new Customs.RoundedButtonVer2();
            UpdateBookingButton = new Customs.RoundedButtonVer2();
            comboBoxAvailableRooms = new ComboBox();
            SaveUpdateButton = new Customs.RoundedButtonVer2();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 45);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(461, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 36);
            label2.TabIndex = 1;
            label2.Text = "Edit Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(690, 97);
            label13.Name = "label13";
            label13.Size = new Size(114, 19);
            label13.TabIndex = 150;
            label13.Text = "Select a date:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 7, 45);
            label12.Location = new Point(824, 119);
            label12.Name = "label12";
            label12.Size = new Size(31, 40);
            label12.TabIndex = 149;
            label12.Text = "-";
            // 
            // dtpEndDate
            // 
            dtpEndDate.BorderColor = Color.Black;
            dtpEndDate.BorderSize = 1;
            dtpEndDate.CalendarForeColor = Color.FromArgb(22, 121, 171);
            dtpEndDate.CalendarMonthBackground = Color.FromArgb(22, 121, 171);
            dtpEndDate.CalendarTitleBackColor = Color.FromArgb(22, 121, 171);
            dtpEndDate.CalendarTitleForeColor = Color.FromArgb(22, 121, 171);
            dtpEndDate.CustomFormat = "yyyy-MM-dd";
            dtpEndDate.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(861, 150);
            dtpEndDate.MinimumSize = new Size(0, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(232, 35);
            dtpEndDate.SkinColor = Color.FromArgb(0, 7, 45);
            dtpEndDate.TabIndex = 148;
            dtpEndDate.TextColor = Color.White;
            // 
            // dtpStartDate
            // 
            dtpStartDate.BorderColor = Color.Black;
            dtpStartDate.BorderSize = 1;
            dtpStartDate.CalendarForeColor = Color.FromArgb(22, 121, 171);
            dtpStartDate.CalendarMonthBackground = Color.FromArgb(22, 121, 171);
            dtpStartDate.CalendarTitleBackColor = Color.FromArgb(22, 121, 171);
            dtpStartDate.CalendarTitleForeColor = Color.FromArgb(22, 121, 171);
            dtpStartDate.CustomFormat = "yyyy-MM-dd";
            dtpStartDate.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(861, 97);
            dtpStartDate.MinimumSize = new Size(0, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(232, 35);
            dtpStartDate.SkinColor = Color.FromArgb(0, 7, 45);
            dtpStartDate.TabIndex = 147;
            dtpStartDate.TextColor = Color.White;
            // 
            // txtNumberOfGuests
            // 
            txtNumberOfGuests.BackColor = Color.White;
            txtNumberOfGuests.BorderColor = Color.Silver;
            txtNumberOfGuests.BorderFocusColor = Color.FromArgb(0, 7, 45);
            txtNumberOfGuests.BorderRadius = 3;
            txtNumberOfGuests.BorderSize = 1;
            txtNumberOfGuests.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfGuests.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumberOfGuests.Location = new Point(743, 586);
            txtNumberOfGuests.Margin = new Padding(4);
            txtNumberOfGuests.Multiline = false;
            txtNumberOfGuests.Name = "txtNumberOfGuests";
            txtNumberOfGuests.Padding = new Padding(15, 7, 10, 7);
            txtNumberOfGuests.PasswordChar = false;
            txtNumberOfGuests.PlaceholderColor = Color.DimGray;
            txtNumberOfGuests.PlaceholderText = "Number Of Guests";
            txtNumberOfGuests.Size = new Size(350, 38);
            txtNumberOfGuests.TabIndex = 152;
            txtNumberOfGuests.Texts = "";
            txtNumberOfGuests.UnderlinedStyle = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = SystemColors.Control;
            roundedPanel1.Controls.Add(lblTotalAmount);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(panel3);
            roundedPanel1.Controls.Add(lblGuestName);
            roundedPanel1.Controls.Add(GuestName);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(lblNumberOfBeds);
            roundedPanel1.Controls.Add(label55);
            roundedPanel1.Controls.Add(lblTotalAmenities);
            roundedPanel1.Controls.Add(lblTotalRoomRate);
            roundedPanel1.Controls.Add(lblVAT);
            roundedPanel1.Controls.Add(lblPricePerNight);
            roundedPanel1.Controls.Add(lblAmenities);
            roundedPanel1.Controls.Add(lblGuestCapacity);
            roundedPanel1.Controls.Add(lblFloorNumber);
            roundedPanel1.Controls.Add(lblRoomNumber);
            roundedPanel1.Controls.Add(lblRoomTypeName);
            roundedPanel1.Controls.Add(lblStayDuration);
            roundedPanel1.Controls.Add(lblCheckOutDate);
            roundedPanel1.Controls.Add(lblCheckInDate);
            roundedPanel1.Controls.Add(label42);
            roundedPanel1.Controls.Add(label41);
            roundedPanel1.Controls.Add(label40);
            roundedPanel1.Controls.Add(label39);
            roundedPanel1.Controls.Add(label38);
            roundedPanel1.Controls.Add(label37);
            roundedPanel1.Controls.Add(label36);
            roundedPanel1.Controls.Add(label35);
            roundedPanel1.Controls.Add(label34);
            roundedPanel1.Controls.Add(label33);
            roundedPanel1.Controls.Add(label32);
            roundedPanel1.Controls.Add(label31);
            roundedPanel1.Controls.Add(panel2);
            roundedPanel1.Controls.Add(label30);
            roundedPanel1.Controls.Add(label14);
            roundedPanel1.Location = new Point(26, 72);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 20;
            roundedPanel1.Size = new Size(593, 733);
            roundedPanel1.TabIndex = 155;
            roundedPanel1.Thickness = 5F;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(295, 686);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(115, 19);
            lblTotalAmount.TabIndex = 61;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(35, 686);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 60;
            label6.Text = "Total Amount:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(15, 549);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 3);
            panel3.TabIndex = 32;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblGuestName.Location = new Point(304, 165);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(105, 19);
            lblGuestName.TabIndex = 59;
            lblGuestName.Text = "Guest Name";
            // 
            // GuestName
            // 
            GuestName.AutoSize = true;
            GuestName.Font = new Font("Century Gothic", 12F);
            GuestName.ForeColor = Color.DimGray;
            GuestName.Location = new Point(35, 163);
            GuestName.Name = "GuestName";
            GuestName.Size = new Size(113, 21);
            GuestName.TabIndex = 58;
            GuestName.Text = "Guest Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(203, 112);
            label5.Name = "label5";
            label5.Size = new Size(182, 26);
            label5.TabIndex = 57;
            label5.Text = "Booking Details:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfBeds
            // 
            lblNumberOfBeds.AutoSize = true;
            lblNumberOfBeds.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblNumberOfBeds.Location = new Point(306, 375);
            lblNumberOfBeds.Name = "lblNumberOfBeds";
            lblNumberOfBeds.Size = new Size(134, 19);
            lblNumberOfBeds.TabIndex = 56;
            lblNumberOfBeds.Text = "Number Of Beds";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("Century Gothic", 12F);
            label55.ForeColor = Color.DimGray;
            label55.Location = new Point(35, 374);
            label55.Name = "label55";
            label55.Size = new Size(140, 21);
            label55.TabIndex = 55;
            label55.Text = "Number Of Beds:";
            // 
            // lblTotalAmenities
            // 
            lblTotalAmenities.AutoSize = true;
            lblTotalAmenities.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotalAmenities.Location = new Point(295, 656);
            lblTotalAmenities.Name = "lblTotalAmenities";
            lblTotalAmenities.Size = new Size(125, 19);
            lblTotalAmenities.TabIndex = 54;
            lblTotalAmenities.Text = "Total Amenities";
            // 
            // lblTotalRoomRate
            // 
            lblTotalRoomRate.AutoSize = true;
            lblTotalRoomRate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotalRoomRate.Location = new Point(295, 600);
            lblTotalRoomRate.Name = "lblTotalRoomRate";
            lblTotalRoomRate.Size = new Size(132, 19);
            lblTotalRoomRate.TabIndex = 53;
            lblTotalRoomRate.Text = "Total Room Rate";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblVAT.Location = new Point(295, 628);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(39, 19);
            lblVAT.TabIndex = 52;
            lblVAT.Text = "VAT";
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblPricePerNight.Location = new Point(296, 572);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(92, 19);
            lblPricePerNight.TabIndex = 51;
            lblPricePerNight.Text = "Room Rate";
            // 
            // lblAmenities
            // 
            lblAmenities.AutoSize = true;
            lblAmenities.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmenities.Location = new Point(307, 405);
            lblAmenities.Name = "lblAmenities";
            lblAmenities.Size = new Size(159, 19);
            lblAmenities.TabIndex = 50;
            lblAmenities.Text = "Included Amenities";
            // 
            // lblGuestCapacity
            // 
            lblGuestCapacity.AutoSize = true;
            lblGuestCapacity.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblGuestCapacity.Location = new Point(304, 348);
            lblGuestCapacity.Name = "lblGuestCapacity";
            lblGuestCapacity.Size = new Size(128, 19);
            lblGuestCapacity.TabIndex = 49;
            lblGuestCapacity.Text = "Guest Capacity";
            // 
            // lblFloorNumber
            // 
            lblFloorNumber.AutoSize = true;
            lblFloorNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblFloorNumber.Location = new Point(304, 322);
            lblFloorNumber.Name = "lblFloorNumber";
            lblFloorNumber.Size = new Size(114, 19);
            lblFloorNumber.TabIndex = 48;
            lblFloorNumber.Text = "Floor Number";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblRoomNumber.Location = new Point(304, 297);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(122, 19);
            lblRoomNumber.TabIndex = 47;
            lblRoomNumber.Text = "Room Number";
            // 
            // lblRoomTypeName
            // 
            lblRoomTypeName.AutoSize = true;
            lblRoomTypeName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblRoomTypeName.Location = new Point(304, 270);
            lblRoomTypeName.Name = "lblRoomTypeName";
            lblRoomTypeName.Size = new Size(95, 19);
            lblRoomTypeName.TabIndex = 46;
            lblRoomTypeName.Text = "Room Type";
            // 
            // lblStayDuration
            // 
            lblStayDuration.AutoSize = true;
            lblStayDuration.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblStayDuration.Location = new Point(304, 245);
            lblStayDuration.Name = "lblStayDuration";
            lblStayDuration.Size = new Size(110, 19);
            lblStayDuration.TabIndex = 45;
            lblStayDuration.Text = "Stay Duration";
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblCheckOutDate.Location = new Point(304, 218);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(175, 19);
            lblCheckOutDate.TabIndex = 44;
            lblCheckOutDate.Text = "Check-Out Date Time";
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblCheckInDate.Location = new Point(304, 191);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(162, 19);
            lblCheckInDate.TabIndex = 43;
            lblCheckInDate.Text = "Check-In Date Time";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Century Gothic", 12F);
            label42.ForeColor = Color.DimGray;
            label42.Location = new Point(35, 321);
            label42.Name = "label42";
            label42.Size = new Size(117, 21);
            label42.TabIndex = 42;
            label42.Text = "Floor Number:";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Century Gothic", 12F);
            label41.ForeColor = Color.DimGray;
            label41.Location = new Point(35, 243);
            label41.Name = "label41";
            label41.Size = new Size(116, 21);
            label41.TabIndex = 41;
            label41.Text = "Stay Duration";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Century Gothic", 12F);
            label40.ForeColor = Color.DimGray;
            label40.Location = new Point(36, 656);
            label40.Name = "label40";
            label40.Size = new Size(134, 21);
            label40.TabIndex = 40;
            label40.Text = "Total Amenities:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Century Gothic", 12F);
            label39.ForeColor = Color.DimGray;
            label39.Location = new Point(36, 627);
            label39.Name = "label39";
            label39.Size = new Size(80, 21);
            label39.TabIndex = 39;
            label39.Text = "VAT 12%:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Century Gothic", 12F);
            label38.ForeColor = Color.DimGray;
            label38.Location = new Point(34, 599);
            label38.Name = "label38";
            label38.Size = new Size(144, 21);
            label38.TabIndex = 38;
            label38.Text = "Total Room Rate:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Century Gothic", 12F);
            label37.ForeColor = Color.DimGray;
            label37.Location = new Point(36, 570);
            label37.Name = "label37";
            label37.Size = new Size(101, 21);
            label37.TabIndex = 37;
            label37.Text = "Room Rate:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.DimGray;
            label36.Location = new Point(35, 403);
            label36.Name = "label36";
            label36.Size = new Size(83, 20);
            label36.TabIndex = 36;
            label36.Text = "Amenities:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Century Gothic", 12F);
            label35.ForeColor = Color.DimGray;
            label35.Location = new Point(35, 347);
            label35.Name = "label35";
            label35.Size = new Size(139, 21);
            label35.TabIndex = 35;
            label35.Text = "Guest Capacity:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 12F);
            label34.ForeColor = Color.DimGray;
            label34.Location = new Point(35, 295);
            label34.Name = "label34";
            label34.Size = new Size(126, 21);
            label34.TabIndex = 34;
            label34.Text = "Room Number:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Century Gothic", 12F);
            label33.ForeColor = Color.DimGray;
            label33.Location = new Point(35, 269);
            label33.Name = "label33";
            label33.Size = new Size(100, 21);
            label33.TabIndex = 33;
            label33.Text = "Room Type:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Century Gothic", 12F);
            label32.ForeColor = Color.DimGray;
            label32.Location = new Point(35, 217);
            label32.Name = "label32";
            label32.Size = new Size(185, 21);
            label32.TabIndex = 32;
            label32.Text = "Check-Out Date Time:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 12F);
            label31.ForeColor = Color.DimGray;
            label31.Location = new Point(35, 191);
            label31.Name = "label31";
            label31.Size = new Size(169, 21);
            label31.TabIndex = 22;
            label31.Text = "Check-In Date Time:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(15, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 3);
            panel2.TabIndex = 31;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.DimGray;
            label30.Location = new Point(220, 58);
            label30.Name = "label30";
            label30.Size = new Size(165, 15);
            label30.TabIndex = 30;
            label30.Text = "Commonwealth, Quezon City";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(166, 15);
            label14.Name = "label14";
            label14.Size = new Size(260, 32);
            label14.TabIndex = 29;
            label14.Text = "The Cerulean Hotel";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFloorNumber
            // 
            comboBoxFloorNumber.BackColor = Color.White;
            comboBoxFloorNumber.BorderColor = Color.Silver;
            comboBoxFloorNumber.BorderSize = 1;
            comboBoxFloorNumber.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFloorNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFloorNumber.ForeColor = Color.DimGray;
            comboBoxFloorNumber.IconColor = Color.Silver;
            comboBoxFloorNumber.Items.AddRange(new object[] { "Cash", "CreditCard", "DebitCard", "GCash" });
            comboBoxFloorNumber.ListBackColor = Color.Silver;
            comboBoxFloorNumber.ListTextColor = Color.FromArgb(0, 7, 45);
            comboBoxFloorNumber.Location = new Point(743, 378);
            comboBoxFloorNumber.MinimumSize = new Size(200, 30);
            comboBoxFloorNumber.Name = "comboBoxFloorNumber";
            comboBoxFloorNumber.Padding = new Padding(1);
            comboBoxFloorNumber.Size = new Size(350, 47);
            comboBoxFloorNumber.TabIndex = 156;
            comboBoxFloorNumber.Texts = "Select Floor Number";
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.BackColor = Color.White;
            comboBoxRoomType.BorderColor = Color.Silver;
            comboBoxRoomType.BorderSize = 1;
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxRoomType.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomType.ForeColor = Color.DimGray;
            comboBoxRoomType.IconColor = Color.Silver;
            comboBoxRoomType.Items.AddRange(new object[] { "Cash", "CreditCard", "DebitCard", "GCash" });
            comboBoxRoomType.ListBackColor = Color.Silver;
            comboBoxRoomType.ListTextColor = Color.FromArgb(0, 7, 45);
            comboBoxRoomType.Location = new Point(743, 262);
            comboBoxRoomType.MinimumSize = new Size(200, 30);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Padding = new Padding(1);
            comboBoxRoomType.Size = new Size(350, 47);
            comboBoxRoomType.TabIndex = 157;
            comboBoxRoomType.Texts = "Select Room Type";
            comboBoxRoomType.OnSelectedIndexChanged += ComboBoxRoomType_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(681, 230);
            label15.Name = "label15";
            label15.Size = new Size(159, 20);
            label15.TabIndex = 160;
            label15.Text = "Select a room type";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(681, 338);
            label17.Name = "label17";
            label17.Size = new Size(226, 20);
            label17.TabIndex = 162;
            label17.Text = "Select a room floor number";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(681, 457);
            label19.Name = "label19";
            label19.Size = new Size(180, 20);
            label19.TabIndex = 165;
            label19.Text = "Select available room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(681, 548);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 166;
            label3.Text = "Number of guests";
            // 
            // roundedButtonVer22
            // 
            roundedButtonVer22.BackColor = Color.FromArgb(52, 100, 244);
            roundedButtonVer22.BackgroundColor = Color.FromArgb(52, 100, 244);
            roundedButtonVer22.BorderColor = Color.FromArgb(0, 7, 45);
            roundedButtonVer22.BorderRadius = 15;
            roundedButtonVer22.BorderSize = 0;
            roundedButtonVer22.FlatAppearance.BorderSize = 0;
            roundedButtonVer22.FlatStyle = FlatStyle.Flat;
            roundedButtonVer22.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonVer22.ForeColor = Color.White;
            roundedButtonVer22.Location = new Point(824, 758);
            roundedButtonVer22.Name = "roundedButtonVer22";
            roundedButtonVer22.Size = new Size(156, 47);
            roundedButtonVer22.TabIndex = 168;
            roundedButtonVer22.Text = "Back";
            roundedButtonVer22.TextColor = Color.White;
            roundedButtonVer22.UseVisualStyleBackColor = false;
            // 
            // UpdateBookingButton
            // 
            UpdateBookingButton.BackColor = Color.FromArgb(0, 7, 45);
            UpdateBookingButton.BackgroundColor = Color.FromArgb(0, 7, 45);
            UpdateBookingButton.BorderColor = Color.PaleVioletRed;
            UpdateBookingButton.BorderRadius = 15;
            UpdateBookingButton.BorderSize = 0;
            UpdateBookingButton.FlatAppearance.BorderSize = 0;
            UpdateBookingButton.FlatStyle = FlatStyle.Flat;
            UpdateBookingButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBookingButton.ForeColor = Color.White;
            UpdateBookingButton.Location = new Point(1051, 636);
            UpdateBookingButton.Name = "UpdateBookingButton";
            UpdateBookingButton.Size = new Size(119, 33);
            UpdateBookingButton.TabIndex = 167;
            UpdateBookingButton.Text = "Review";
            UpdateBookingButton.TextColor = Color.White;
            UpdateBookingButton.UseVisualStyleBackColor = false;
            UpdateBookingButton.Click += UpdateBookingButton_Click;
            // 
            // comboBoxAvailableRooms
            // 
            comboBoxAvailableRooms.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAvailableRooms.FormattingEnabled = true;
            comboBoxAvailableRooms.ItemHeight = 22;
            comboBoxAvailableRooms.Location = new Point(743, 494);
            comboBoxAvailableRooms.Name = "comboBoxAvailableRooms";
            comboBoxAvailableRooms.Size = new Size(341, 30);
            comboBoxAvailableRooms.TabIndex = 169;
            comboBoxAvailableRooms.Text = "Select a room";
            // 
            // SaveUpdateButton
            // 
            SaveUpdateButton.BackColor = Color.FromArgb(0, 7, 45);
            SaveUpdateButton.BackgroundColor = Color.FromArgb(0, 7, 45);
            SaveUpdateButton.BorderColor = Color.FromArgb(0, 7, 45);
            SaveUpdateButton.BorderRadius = 15;
            SaveUpdateButton.BorderSize = 0;
            SaveUpdateButton.FlatAppearance.BorderSize = 0;
            SaveUpdateButton.FlatStyle = FlatStyle.Flat;
            SaveUpdateButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveUpdateButton.ForeColor = Color.White;
            SaveUpdateButton.Location = new Point(997, 756);
            SaveUpdateButton.Name = "SaveUpdateButton";
            SaveUpdateButton.Size = new Size(156, 47);
            SaveUpdateButton.TabIndex = 170;
            SaveUpdateButton.Text = "Update";
            SaveUpdateButton.TextColor = Color.White;
            SaveUpdateButton.UseVisualStyleBackColor = false;
            SaveUpdateButton.Click += SaveUpdateButton_Click;
            // 
            // EditBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 823);
            Controls.Add(SaveUpdateButton);
            Controls.Add(comboBoxAvailableRooms);
            Controls.Add(roundedButtonVer22);
            Controls.Add(UpdateBookingButton);
            Controls.Add(roundedPanel1);
            Controls.Add(label3);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(comboBoxRoomType);
            Controls.Add(comboBoxFloorNumber);
            Controls.Add(txtNumberOfGuests);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(panel1);
            Name = "EditBooking";
            Text = "EditBooking";
            Load += EditBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Customs.RoundedButtonVer2 btnCheckAvailability;
        private Label label13;
        private Label label12;
        private Customs.CustomDatePicker dtpEndDate;
        private Customs.CustomDatePicker dtpStartDate;
        private Customs.TextBox txtNumberOfGuests;
        private Customs.RoundedPanel roundedPanel1;
        private Label lblNumberOfBeds;
        private Label label55;
        private Label lblTotalAmenities;
        private Label lblTotalRoomRate;
        private Label lblVAT;
        private Label lblPricePerNight;
        private Label lblAmenities;
        private Label lblGuestCapacity;
        private Label lblFloorNumber;
        private Label lblRoomNumber;
        private Label lblRoomTypeName;
        private Label lblStayDuration;
        private Label lblCheckOutDate;
        private Label lblCheckInDate;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Panel panel2;
        private Label label30;
        private Label label14;
        private Label label5;
        private Panel panel3;
        private Label lblGuestName;
        private Label GuestName;
        private Label lblTotalAmount;
        private Label label6;
        private Customs.CustomComboBox comboBoxFloorNumber;
        private Customs.CustomComboBox comboBoxRoomType;
        private Label label15;
        private Label label17;
        private Label label19;
        private Label label3;
        private Customs.RoundedButtonVer2 roundedButtonVer22;
        private Customs.RoundedButtonVer2 UpdateBookingButton;
        private ComboBox comboBoxAvailableRooms;
        private Customs.RoundedButtonVer2 SaveUpdateButton;
    }
}