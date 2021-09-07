using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class DeleteInvoice
    {
        private ApplicationDbContext _context;

        public DeleteInvoice(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Do(int id)
        {
            var invoice = _context.Invoices.FirstOrDefault(x => x.Id == id);
            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
