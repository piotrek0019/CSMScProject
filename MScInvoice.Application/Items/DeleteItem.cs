using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Items
{
    public class DeleteItem
    {
        private ApplicationDbContext _context;

        public DeleteItem(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Do(int id)
        {
            var Item = _context.Items.FirstOrDefault(x => x.Id == id);
            _context.Items.Remove(Item);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
