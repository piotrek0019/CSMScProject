using System;
using System.Collections.Generic;
using System.Text;

namespace MScInvoice.Domain.Models
{
    public class PayMethod
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public string MyUserId { get; set; }
        public MyUser MyUser { get; set; }
    }
}
