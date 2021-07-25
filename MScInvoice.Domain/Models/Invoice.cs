using System;
using System.Collections.Generic;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string MyUserId { get; set; }
        public MyUser MyUser { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PayMethodId { get; set; }
        public PayMethod PayMethod { get; set; }
        public ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
