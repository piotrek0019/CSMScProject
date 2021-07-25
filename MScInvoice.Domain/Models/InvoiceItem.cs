using System;
using System.Collections.Generic;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
