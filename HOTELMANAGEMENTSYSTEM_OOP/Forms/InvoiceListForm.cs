using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using HOTELMANAGEMENTSYSTEM_OOP.Services;
using QuestPDF.Fluent;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class InvoiceListForm : Form
    {
        private InvoiceService invoiceService;
        private BindingList<InvoiceDisplayDTO> invoices = new BindingList<InvoiceDisplayDTO>();

        public InvoiceListForm()
        {
            InitializeComponent();
            invoiceService = new InvoiceService(new SQLiteInvoiceRepository());

            SearchTextBox.TextChanged += SearchTextBox_TextChanged;

            LoadInvoices();

            dataGridViewInvoices.CellContentClick += dataGridViewInvoices_CellContentClick;

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            LoadInvoices(searchTerm);
        }


        private void LoadInvoices(string searchTerm = "")
        {
            try
            {
                invoices.Clear();
                List<InvoiceDisplayDTO> invoiceList = invoiceService.GetAllInvoices();

                // Filter invoices based on the search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    invoiceList = invoiceList.FindAll(i =>
                        i.GuestFullName.ToLower().Contains(searchTerm) ||
                        i.InvoiceID.ToString().Contains(searchTerm) ||
                        i.PaymentStatus.ToString().ToLower().Contains(searchTerm)
                    );
                }

                foreach (var invoice in invoiceList)
                {
                    // Add row to DataGridView
                    dataGridViewInvoices.Rows.Add(
                        false,
                        invoice.InvoiceID,
                        invoice.BookingID,
                        invoice.GuestFullName,
                        invoice.InvoiceDate.ToShortDateString(),
                        invoice.TotalAmount,
                        invoice.PaymentMethod,
                        invoice.PaymentStatus
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}");
            }
        }


        private void dataGridViewInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the checkbox column
            if (e.ColumnIndex == dataGridViewInvoices.Columns["Select"].Index && e.RowIndex >= 0)
            {
                // Get the current checkbox cell
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridViewInvoices.Rows[e.RowIndex].Cells["Select"];

                // Toggle the checkbox value
                checkBoxCell.Value = !(checkBoxCell.Value is bool && (bool)checkBoxCell.Value);

                // Commit the edit to ensure the change is reflected immediately
                dataGridViewInvoices.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }


        private void PrintInvoiceButton_Click(object sender, EventArgs e)
        {
           
        }


        private void DeleteInvoiceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
