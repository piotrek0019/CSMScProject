using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public ICollection<InvoiceSection> InvoiceSection { get; set; }
    }
}
