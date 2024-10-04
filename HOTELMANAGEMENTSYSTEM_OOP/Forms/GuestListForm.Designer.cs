namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class GuestListForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SearchTextBox = new Customs.TextBox();
            dataGridViewGuestList = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            GuestName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            CheckInDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            EmailAddress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuestList).BeginInit();
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
            label1.Size = new Size(118, 40);
            label1.TabIndex = 10;
            label1.Text = "GUEST";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(1096, 19);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 25);
            iconButton1.TabIndex = 12;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.White;
            SearchTextBox.BorderColor = Color.FromArgb(0, 7, 45);
            SearchTextBox.BorderFocusColor = Color.FromArgb(58, 166, 185);
            SearchTextBox.BorderRadius = 5;
            SearchTextBox.BorderSize = 1;
            SearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            SearchTextBox.Location = new Point(737, 13);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = false;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Padding = new Padding(10, 7, 10, 7);
            SearchTextBox.PasswordChar = false;
            SearchTextBox.PlaceholderColor = Color.Black;
            SearchTextBox.PlaceholderText = "Search a guest here";
            SearchTextBox.Size = new Size(401, 36);
            SearchTextBox.TabIndex = 11;
            SearchTextBox.Texts = "";
            SearchTextBox.UnderlinedStyle = false;
            // 
            // dataGridViewGuestList
            // 
            dataGridViewGuestList.AllowUserToAddRows = false;
            dataGridViewGuestList.AllowUserToDeleteRows = false;
            dataGridViewGuestList.AllowUserToResizeRows = false;
            dataGridViewGuestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGuestList.BackgroundColor = Color.White;
            dataGridViewGuestList.BorderStyle = BorderStyle.None;
            dataGridViewGuestList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGuestList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewGuestList.ColumnHeadersHeight = 40;
            dataGridViewGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewGuestList.Columns.AddRange(new DataGridViewColumn[] { Column1, GuestID, GuestName, ContactNo, RoomType, RoomNumber, CheckInDate, CheckOutDate, EmailAddress });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(216, 225, 232);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewGuestList.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewGuestList.EnableHeadersVisualStyles = false;
            dataGridViewGuestList.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewGuestList.Location = new Point(12, 65);
            dataGridViewGuestList.Name = "dataGridViewGuestList";
            dataGridViewGuestList.ReadOnly = true;
            dataGridViewGuestList.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewGuestList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewGuestList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGuestList.Size = new Size(1198, 820);
            dataGridViewGuestList.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "GuestID";
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Visible = false;
            // 
            // GuestName
            // 
            GuestName.HeaderText = "Guest Name";
            GuestName.Name = "GuestName";
            GuestName.ReadOnly = true;
            // 
            // ContactNo
            // 
            ContactNo.HeaderText = "Contact No.";
            ContactNo.Name = "ContactNo";
            ContactNo.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.HeaderText = "Room Type";
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "RoomNumber";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // CheckInDate
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            CheckInDate.DefaultCellStyle = dataGridViewCellStyle7;
            CheckInDate.HeaderText = "CheckInDate";
            CheckInDate.Name = "CheckInDate";
            CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            CheckOutDate.DefaultCellStyle = dataGridViewCellStyle8;
            CheckOutDate.HeaderText = "Check Out Date";
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.ReadOnly = true;
            // 
            // EmailAddress
            // 
            EmailAddress.HeaderText = "EmailAddress";
            EmailAddress.Name = "EmailAddress";
            EmailAddress.ReadOnly = true;
            // 
            // GuestListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 946);
            Controls.Add(dataGridViewGuestList);
            Controls.Add(iconButton1);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            Name = "GuestListForm";
            Text = "GuestListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuestList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Customs.TextBox SearchTextBox;
        private DataGridView dataGridViewGuestList;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn GuestName;
        private DataGridViewTextBoxColumn ContactNo;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn CheckInDate;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn EmailAddress;
    }
}