using HOTELMANAGEMENTSYSTEM_OOP.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class ReportForm : Form
    {
        private readonly InvoiceService invoiceService;

        public ReportForm(InvoiceService invoiceService)
        {
            InitializeComponent();
            this.invoiceService = invoiceService;
            this.Load += new EventHandler(ReportForm_Load);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (dataGridViewReport.Columns.Count == 0)
            {
                dataGridViewReport.Columns.Add("Period", "Period");
                dataGridViewReport.Columns.Add("Total", "Total");
            }

            LoadInvoiceSummaries();
        }

        private void LoadInvoiceSummaries()
        {
            try
            {
                var invoiceSummaries = invoiceService.GetInvoiceSummaries();
                dataGridViewReport.Rows.Clear();
                if (invoiceSummaries == null || invoiceSummaries.Count == 0)
                {
                    MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var summary in invoiceSummaries)
                {
                    dataGridViewReport.Rows.Add(summary.Period, summary.Total);
                }

                MessageBox.Show("Data loaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading invoice summaries: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
