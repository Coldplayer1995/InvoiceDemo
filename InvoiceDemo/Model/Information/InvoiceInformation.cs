using System;

namespace InvoiceDemo.Model.Information
{
    public class InvoiceInformation
    {
        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public bool IsPaid { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    }
}
