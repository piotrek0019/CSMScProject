using System;
using System.Collections.Generic;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceSectionId { get; set; }
        public InvoiceSection InvoiceSection { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
