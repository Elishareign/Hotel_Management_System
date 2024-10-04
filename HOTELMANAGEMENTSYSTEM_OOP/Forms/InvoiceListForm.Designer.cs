namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class InvoiceListForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListForm));
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridViewInvoices = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            InvoiceID = new DataGridViewTextBoxColumn();
            BookingID = new DataGridViewTextBoxColumn();
            GuestFullName = new DataGridViewTextBoxColumn();
            InvoiceDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            imageList1 = new ImageList(components);
            SearchTextBox = new Customs.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
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
            label1.Size = new Size(160, 40);
            label1.TabIndex = 10;
            label1.Text = "INVOICE";
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
            iconButton1.Location = new Point(1121, 19);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 25);
            iconButton1.TabIndex = 12;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.AllowUserToAddRows = false;
            dataGridViewInvoices.AllowUserToDeleteRows = false;
            dataGridViewInvoices.AllowUserToResizeRows = false;
            dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoices.BackgroundColor = Color.White;
            dataGridViewInvoices.BorderStyle = BorderStyle.None;
            dataGridViewInvoices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewInvoices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewInvoices.ColumnHeadersHeight = 40;
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewInvoices.Columns.AddRange(new DataGridViewColumn[] { Select, InvoiceID, BookingID, GuestFullName, InvoiceDate, TotalAmount, PaymentMethod, PaymentStatus });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(216, 225, 232);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewInvoices.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewInvoices.EnableHeadersVisualStyles = false;
            dataGridViewInvoices.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewInvoices.Location = new Point(13, 59);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.ReadOnly = true;
            dataGridViewInvoices.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Teal;
            dataGridViewInvoices.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoices.Size = new Size(1198, 805);
            dataGridViewInvoices.TabIndex = 18;
            dataGridViewInvoices.CellContentClick += dataGridViewInvoices_CellContentClick;
            // 
            // Select
            // 
            Select.HeaderText = "";
            Select.Name = "Select";
            Select.ReadOnly = true;
            // 
            // InvoiceID
            // 
            InvoiceID.HeaderText = "InvoiceID";
            InvoiceID.Name = "InvoiceID";
            InvoiceID.ReadOnly = true;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "Booking ID";
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            BookingID.Resizable = DataGridViewTriState.True;
            BookingID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GuestFullName
            // 
            GuestFullName.HeaderText = "Guest Name";
            GuestFullName.Name = "GuestFullName";
            GuestFullName.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            InvoiceDate.DefaultCellStyle = dataGridViewCellStyle7;
            InvoiceDate.HeaderText = "Invoice Date";
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle8;
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Payment Method";
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            PaymentStatus.HeaderText = "Payment Status";
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.ReadOnly = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "availableRoomStatus.png");
            imageList1.Images.SetKeyName(1, "RefundedIcon.png");
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
            SearchTextBox.Location = new Point(831, 13);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = false;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Padding = new Padding(10, 7, 10, 7);
            SearchTextBox.PasswordChar = false;
            SearchTextBox.PlaceholderColor = Color.Black;
            SearchTextBox.PlaceholderText = "Search an invoice here";
            SearchTextBox.Size = new Size(330, 36);
            SearchTextBox.TabIndex = 11;
            SearchTextBox.Texts = "";
            SearchTextBox.UnderlinedStyle = false;
            // 
            // InvoiceListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 938);
            Controls.Add(dataGridViewInvoices);
            Controls.Add(iconButton1);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            Name = "InvoiceListForm";
            Text = "InvoiceListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridViewInvoices;
        private ImageList imageList1;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn InvoiceID;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn GuestFullName;
        private DataGridViewTextBoxColumn InvoiceDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn PaymentStatus;
        private Customs.TextBox SearchTextBox;
    }
}