using System;

namespace HOTELMANAGEMENTSYSTEM_OOP.Model
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal VAT { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal Payment { get; set; } 
        public static decimal VATPercentage = 0.12m; 

        public Invoice(int bookingID, int roomID, DateTime invoiceDate, decimal totalAmount, PaymentStatus paymentStatus, PaymentMethod paymentMethod, decimal payment)
        {
            this.BookingID = bookingID;
            this.RoomID = roomID; 
            this.InvoiceDate = invoiceDate;
            this.TotalAmount = totalAmount;
            this.PaymentStatus = paymentStatus;
            this.PaymentMethod = paymentMethod;
            this.Payment = payment;
        }
    }

    public enum PaymentStatus
    {
        Paid,
        Refunded
    }


    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        GCash
    }

    public class InvoiceDisplayDTO
    {
        public int InvoiceID { get; set; }
        public int BookingID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string GuestFullName { get; set; }

        public InvoiceDisplayDTO(int invoiceID, int bookingID, DateTime invoiceDate, decimal totalAmount,
                                 PaymentStatus paymentStatus, PaymentMethod paymentMethod,
                                 string guestFullName)
        {
            InvoiceID = invoiceID;
            BookingID = bookingID;
            InvoiceDate = invoiceDate;
            TotalAmount = totalAmount;
            PaymentStatus = paymentStatus;
            PaymentMethod = paymentMethod;
            GuestFullName = guestFullName;
        }

    }
    public class InvoiceSummaryDTO
    {
        public string Period { get; set; }
        public decimal Total { get; set; }
    }



    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        public string GuestFullName { get; set; }
        public int ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalAmount { get; set; }
        public List<string> Amenities { get; set; }
        public List<decimal> AmenityPrices { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public InvoiceModel(int invoiceID, string guestFullName, int contactNo, string emailAddress,
                            DateTime checkInDate, DateTime checkOutDate, int roomNumber, string roomTypeName,
                            decimal pricePerNight, decimal totalAmount, List<string> amenities, List<decimal> amenityPrices,
                            PaymentMethod paymentMethod)
        {
            InvoiceID = invoiceID;
            GuestFullName = guestFullName;
            ContactNo = contactNo;
            EmailAddress = emailAddress;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomNumber = roomNumber;
            RoomTypeName = roomTypeName;
            PricePerNight = pricePerNight;
            TotalAmount = totalAmount;
            Amenities = amenities;
            AmenityPrices = amenityPrices;
            PaymentMethod = paymentMethod;
        }
    }

}
