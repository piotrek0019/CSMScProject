using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Domain.Models
{
    public class InvoiceSection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
