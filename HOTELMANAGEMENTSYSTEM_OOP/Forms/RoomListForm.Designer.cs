namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class RoomListForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomListForm));
            dataGridViewRooms = new DataGridView();
            CheckListRoom = new DataGridViewCheckBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            NumberOfBeds = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            ImageStatus = new DataGridViewImageColumn();
            RoomStatus = new DataGridViewTextBoxColumn();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textSearch = new Customs.TextBox();
            imageList1 = new ImageList(components);
            UnderMaintenance = new Customs.RoundedButtonVer2();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.AllowUserToResizeRows = false;
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.White;
            dataGridViewRooms.BorderStyle = BorderStyle.None;
            dataGridViewRooms.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(48, 70, 116);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRooms.ColumnHeadersHeight = 40;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRooms.Columns.AddRange(new DataGridViewColumn[] { CheckListRoom, RoomNumber, RoomType, FloorNumber, Capacity, NumberOfBeds, TotalPrice, ImageStatus, RoomStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(216, 225, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewRooms.Location = new Point(15, 64);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewRooms.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(152, 186, 213);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewRooms.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRooms.RowTemplate.Height = 35;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRooms.Size = new Size(1198, 795);
            dataGridViewRooms.TabIndex = 8;
            // 
            // CheckListRoom
            // 
            CheckListRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CheckListRoom.HeaderText = "";
            CheckListRoom.Name = "CheckListRoom";
            CheckListRoom.ReadOnly = true;
            CheckListRoom.Width = 81;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomNumber.FillWeight = 120F;
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomType.FillWeight = 150F;
            RoomType.HeaderText = "Room Type";
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FloorNumber.HeaderText = "Floor Number";
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Capacity.HeaderText = "Capacity";
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            // 
            // NumberOfBeds
            // 
            NumberOfBeds.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumberOfBeds.FillWeight = 120F;
            NumberOfBeds.HeaderText = "Number Of Beds";
            NumberOfBeds.Name = "NumberOfBeds";
            NumberOfBeds.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            TotalPrice.DefaultCellStyle = dataGridViewCellStyle2;
            TotalPrice.FillWeight = 150F;
            TotalPrice.HeaderText = "Total Price Per Night";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 188;
            // 
            // ImageStatus
            // 
            ImageStatus.FillWeight = 70F;
            ImageStatus.HeaderText = "";
            ImageStatus.Name = "ImageStatus";
            ImageStatus.ReadOnly = true;
            // 
            // RoomStatus
            // 
            RoomStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomStatus.HeaderText = "Room Status";
            RoomStatus.Name = "RoomStatus";
            RoomStatus.ReadOnly = true;
            RoomStatus.Resizable = DataGridViewTriState.True;
            RoomStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 9;
            label1.Text = "ROOM";
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
            iconButton1.Location = new Point(1147, 19);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 25);
            iconButton1.TabIndex = 11;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            textSearch.BackColor = Color.White;
            textSearch.BorderColor = Color.FromArgb(0, 7, 45);
            textSearch.BorderFocusColor = Color.FromArgb(58, 166, 185);
            textSearch.BorderRadius = 5;
            textSearch.BorderSize = 1;
            textSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.ForeColor = Color.FromArgb(64, 64, 64);
            textSearch.Location = new Point(856, 13);
            textSearch.Margin = new Padding(4);
            textSearch.Multiline = false;
            textSearch.Name = "textSearch";
            textSearch.Padding = new Padding(10, 7, 10, 7);
            textSearch.PasswordChar = false;
            textSearch.PlaceholderColor = Color.Black;
            textSearch.PlaceholderText = "Search a room here";
            textSearch.Size = new Size(330, 36);
            textSearch.TabIndex = 10;
            textSearch.Texts = "";
            textSearch.UnderlinedStyle = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "availableRoomStatus.png");
            imageList1.Images.SetKeyName(1, "occupiedRoomStatus.png");
            imageList1.Images.SetKeyName(2, "underMaintenanceStatus.png");
            // 
            // UnderMaintenance
            // 
            UnderMaintenance.BackColor = Color.DarkOrange;
            UnderMaintenance.BackgroundColor = Color.DarkOrange;
            UnderMaintenance.BorderColor = Color.FromArgb(0, 7, 45);
            UnderMaintenance.BorderRadius = 10;
            UnderMaintenance.BorderSize = 0;
            UnderMaintenance.FlatAppearance.BorderSize = 0;
            UnderMaintenance.FlatStyle = FlatStyle.Flat;
            UnderMaintenance.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnderMaintenance.ForeColor = Color.White;
            UnderMaintenance.Location = new Point(959, 868);
            UnderMaintenance.Name = "UnderMaintenance";
            UnderMaintenance.Size = new Size(184, 43);
            UnderMaintenance.TabIndex = 17;
            UnderMaintenance.Text = "Under Maintenance";
            UnderMaintenance.TextColor = Color.White;
            UnderMaintenance.UseVisualStyleBackColor = false;
            UnderMaintenance.Click += UnderMaintenance_Click;
            // 
            // RoomListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 946);
            Controls.Add(UnderMaintenance);
            Controls.Add(iconButton1);
            Controls.Add(textSearch);
            Controls.Add(label1);
            Controls.Add(dataGridViewRooms);
            Name = "RoomListForm";
            Text = "RoomListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRooms;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Customs.TextBox textSearch;
        private ImageList imageList1;
        private DataGridViewCheckBoxColumn CheckListRoom;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn NumberOfBeds;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewImageColumn ImageStatus;
        private DataGridViewTextBoxColumn RoomStatus;
        private Customs.RoundedButtonVer2 UnderMaintenance;
    }
}