using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceDemo.Model.Entity
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Postcode { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
