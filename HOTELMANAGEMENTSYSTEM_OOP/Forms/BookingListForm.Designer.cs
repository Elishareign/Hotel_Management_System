namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class BookingListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new Customs.TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridViewBookings = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            BookingID = new DataGridViewTextBoxColumn();
            RoomID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            GuestName = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            CheckInDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            addBookingButton = new Customs.RoundedButtonVer2();
            editBookingButton = new Customs.RoundedButtonVer2();
            DeleteButton = new Customs.RoundedButtonVer2();
            CheckOutButton = new Customs.RoundedButtonVer2();
            CheckInButton = new Customs.RoundedButtonVer2();
            CancelBooking = new Customs.RoundedButtonVer2();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(180, 40);
            label1.TabIndex = 2;
            label1.Text = "BOOKING";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BackColor = Color.White;
            SearchTextBox.BorderColor = Color.FromArgb(0, 7, 45);
            SearchTextBox.BorderFocusColor = Color.FromArgb(58, 166, 185);
            SearchTextBox.BorderRadius = 5;
            SearchTextBox.BorderSize = 1;
            SearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            SearchTextBox.Location = new Point(706, 10);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = false;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Padding = new Padding(10, 7, 10, 7);
            SearchTextBox.PasswordChar = false;
            SearchTextBox.PlaceholderColor = Color.Black;
            SearchTextBox.PlaceholderText = "Search a booking here";
            SearchTextBox.Size = new Size(461, 36);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.Texts = "";
            SearchTextBox.UnderlinedStyle = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(1126, 16);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 25);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewBookings
            // 
            dataGridViewBookings.AllowUserToAddRows = false;
            dataGridViewBookings.AllowUserToDeleteRows = false;
            dataGridViewBookings.AllowUserToResizeRows = false;
            dataGridViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookings.BackgroundColor = Color.White;
            dataGridViewBookings.BorderStyle = BorderStyle.None;
            dataGridViewBookings.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBookings.ColumnHeadersHeight = 40;
            dataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBookings.Columns.AddRange(new DataGridViewColumn[] { Column1, BookingID, RoomID, Column2, GuestName, Column9, CheckInDate, CheckOutDate, Column6, Column7, Column8, GuestID });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(216, 225, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewBookings.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBookings.EnableHeadersVisualStyles = false;
            dataGridViewBookings.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewBookings.Location = new Point(12, 63);
            dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewBookings.ReadOnly = true;
            dataGridViewBookings.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewBookings.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookings.Size = new Size(1214, 793);
            dataGridViewBookings.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.FillWeight = 50F;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "Booking ID";
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            BookingID.Visible = false;
            // 
            // RoomID
            // 
            RoomID.HeaderText = "Room ID";
            RoomID.Name = "RoomID";
            RoomID.ReadOnly = true;
            RoomID.Visible = false;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "False";
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Booking Date";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GuestName
            // 
            GuestName.HeaderText = "Guest Name";
            GuestName.Name = "GuestName";
            GuestName.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Number Of Guest";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // CheckInDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            CheckInDate.DefaultCellStyle = dataGridViewCellStyle3;
            CheckInDate.HeaderText = "Check-In Date";
            CheckInDate.Name = "CheckInDate";
            CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            CheckOutDate.DefaultCellStyle = dataGridViewCellStyle4;
            CheckOutDate.HeaderText = "Check-Out Date";
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Room Number";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Room Type";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Booking Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "GuestID";
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Visible = false;
            // 
            // addBookingButton
            // 
            addBookingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBookingButton.BackColor = Color.FromArgb(0, 7, 45);
            addBookingButton.BackgroundColor = Color.FromArgb(0, 7, 45);
            addBookingButton.BorderColor = Color.FromArgb(0, 7, 45);
            addBookingButton.BorderRadius = 10;
            addBookingButton.BorderSize = 0;
            addBookingButton.FlatAppearance.BorderSize = 0;
            addBookingButton.FlatStyle = FlatStyle.Flat;
            addBookingButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBookingButton.ForeColor = Color.White;
            addBookingButton.Location = new Point(635, 875);
            addBookingButton.Name = "addBookingButton";
            addBookingButton.Size = new Size(138, 43);
            addBookingButton.TabIndex = 8;
            addBookingButton.Text = "Add Booking";
            addBookingButton.TextColor = Color.White;
            addBookingButton.UseVisualStyleBackColor = false;
            // 
            // editBookingButton
            // 
            editBookingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editBookingButton.BackColor = Color.FromArgb(52, 100, 244);
            editBookingButton.BackgroundColor = Color.FromArgb(52, 100, 244);
            editBookingButton.BorderColor = Color.FromArgb(0, 7, 45);
            editBookingButton.BorderRadius = 10;
            editBookingButton.BorderSize = 0;
            editBookingButton.FlatAppearance.BorderSize = 0;
            editBookingButton.FlatStyle = FlatStyle.Flat;
            editBookingButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBookingButton.ForeColor = Color.White;
            editBookingButton.Location = new Point(927, 875);
            editBookingButton.Name = "editBookingButton";
            editBookingButton.Size = new Size(138, 43);
            editBookingButton.TabIndex = 9;
            editBookingButton.Text = "Edit Booking";
            editBookingButton.TextColor = Color.White;
            editBookingButton.UseVisualStyleBackColor = false;
            editBookingButton.Click += editBookingButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(200, 0, 54);
            DeleteButton.BackgroundColor = Color.FromArgb(200, 0, 54);
            DeleteButton.BorderColor = Color.FromArgb(0, 7, 45);
            DeleteButton.BorderRadius = 10;
            DeleteButton.BorderSize = 0;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(1071, 875);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(138, 43);
            DeleteButton.TabIndex = 21;
            DeleteButton.Text = "Delete Booking";
            DeleteButton.TextColor = Color.White;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CheckOutButton
            // 
            CheckOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CheckOutButton.BackColor = Color.FromArgb(0, 7, 45);
            CheckOutButton.BackgroundColor = Color.FromArgb(0, 7, 45);
            CheckOutButton.BorderColor = Color.FromArgb(0, 7, 45);
            CheckOutButton.BorderRadius = 10;
            CheckOutButton.BorderSize = 0;
            CheckOutButton.FlatAppearance.BorderSize = 0;
            CheckOutButton.FlatStyle = FlatStyle.Flat;
            CheckOutButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutButton.ForeColor = Color.White;
            CheckOutButton.Location = new Point(491, 875);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(138, 43);
            CheckOutButton.TabIndex = 22;
            CheckOutButton.Text = "Check-Out";
            CheckOutButton.TextColor = Color.White;
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // CheckInButton
            // 
            CheckInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CheckInButton.BackColor = Color.FromArgb(0, 7, 45);
            CheckInButton.BackgroundColor = Color.FromArgb(0, 7, 45);
            CheckInButton.BorderColor = Color.FromArgb(0, 7, 45);
            CheckInButton.BorderRadius = 10;
            CheckInButton.BorderSize = 0;
            CheckInButton.FlatAppearance.BorderSize = 0;
            CheckInButton.FlatStyle = FlatStyle.Flat;
            CheckInButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInButton.ForeColor = Color.White;
            CheckInButton.Location = new Point(347, 875);
            CheckInButton.Name = "CheckInButton";
            CheckInButton.Size = new Size(138, 43);
            CheckInButton.TabIndex = 23;
            CheckInButton.Text = "Check-In";
            CheckInButton.TextColor = Color.White;
            CheckInButton.UseVisualStyleBackColor = false;
            CheckInButton.Click += CheckInButton_Click;
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBooking.BackColor = Color.FromArgb(0, 7, 45);
            CancelBooking.BackgroundColor = Color.FromArgb(0, 7, 45);
            CancelBooking.BorderColor = Color.FromArgb(0, 7, 45);
            CancelBooking.BorderRadius = 10;
            CancelBooking.BorderSize = 0;
            CancelBooking.FlatAppearance.BorderSize = 0;
            CancelBooking.FlatStyle = FlatStyle.Flat;
            CancelBooking.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBooking.ForeColor = Color.White;
            CancelBooking.Location = new Point(779, 875);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.Size = new Size(138, 43);
            CancelBooking.TabIndex = 24;
            CancelBooking.Text = "Cancel Booking";
            CancelBooking.TextColor = Color.White;
            CancelBooking.UseVisualStyleBackColor = false;
            CancelBooking.Click += CancelBooking_Click;
            // 
            // BookingListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 930);
            Controls.Add(CancelBooking);
            Controls.Add(CheckInButton);
            Controls.Add(CheckOutButton);
            Controls.Add(DeleteButton);
            Controls.Add(editBookingButton);
            Controls.Add(addBookingButton);
            Controls.Add(dataGridViewBookings);
            Controls.Add(iconButton1);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            Name = "BookingListForm";
            Text = "BookingListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Customs.TextBox SearchTextBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridViewBookings;
        private Customs.RoundedButtonVer2 addBookingButton;
        private Customs.RoundedButtonVer2 editBookingButton;
        private Customs.RoundedButtonVer2 DeleteButton;
        private Customs.RoundedButtonVer2 CheckOutButton;
        private Customs.RoundedButtonVer2 CheckInButton;
        private Customs.RoundedButtonVer2 CancelBooking;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn GuestName;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn CheckInDate;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn GuestID;
    }
}