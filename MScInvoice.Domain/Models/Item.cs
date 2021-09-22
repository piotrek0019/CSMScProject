using System;
using System.Collections.Generic;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public string MyUserId { get; set; }
        public MyUser MyUser { get; set; }
        public ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
