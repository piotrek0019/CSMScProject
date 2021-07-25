using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Domain.Models
{
    public class MyUser : IdentityUser
    {
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<PayMethod> PayMethod { get; set; }
    }
}
