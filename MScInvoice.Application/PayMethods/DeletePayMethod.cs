using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.PayMethods
{
    public class DeletePayMethod
    {
        private ApplicationDbContext _context;

        public DeletePayMethod(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Do(int id)
        {
            var payMethod = _context.PayMethods.FirstOrDefault(x => x.Id == id);
            _context.PayMethods.Remove(payMethod);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
