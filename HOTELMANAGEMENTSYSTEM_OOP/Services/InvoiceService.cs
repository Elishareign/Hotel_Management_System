using System;
using System.Collections.Generic;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;

namespace HOTELMANAGEMENTSYSTEM_OOP.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository ?? throw new ArgumentNullException(nameof(invoiceRepository));
        }

        public void AddInvoice(Invoice invoice)
        {
            // You can perform additional validation or business logic here before adding the invoice
            _invoiceRepository.AddInvoice(invoice);
        }

        public List<InvoiceDisplayDTO> GetAllInvoices()
        {
            var invoiceDTOs = _invoiceRepository.GetAllInvoices();
            var invoices = new List<InvoiceDisplayDTO>();

            foreach (var dto in invoiceDTOs)
            {
                var invoice = new InvoiceDisplayDTO(
                    dto.InvoiceID,
                    dto.BookingID,
                    dto.InvoiceDate,
                    dto.TotalAmount,
                    dto.PaymentStatus,
                    dto.PaymentMethod,
                    dto.GuestFullName
                );

                invoices.Add(invoice);
            }

            return invoices;
        }

        public List<InvoiceModel> GetInvoices() 
        {
            return _invoiceRepository.GetInvoices();
        }

        public bool UpdatePaymentStatus(int bookingID, string status)
        {
            return _invoiceRepository.UpdatePaymentStatus(bookingID, status);
        }



        public void UpdateInvoice(Invoice invoice)
        {
            
            _invoiceRepository.UpdateInvoice(invoice);
        }

        public void DeleteInvoice(int invoiceId)
        {
            
            _invoiceRepository.DeleteInvoice(invoiceId);
        }

        public List<InvoiceSummaryDTO> GetInvoiceSummaries()
        {
            return _invoiceRepository.GetInvoiceSummaries();
        }
    }
}
