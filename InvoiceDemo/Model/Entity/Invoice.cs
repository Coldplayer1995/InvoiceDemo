using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceDemo.Model.Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public bool IsPaid { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }

        public virtual Customers Customers { get; set; }
    }
}
