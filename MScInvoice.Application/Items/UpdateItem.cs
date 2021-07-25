using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Items
{
    public class UpdateItem
    {
        private ApplicationDbContext _context;

        public UpdateItem(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var item = _context.Items.FirstOrDefault(x => x.Id == request.Id);

            item.Name = request.Name;
            item.Price = request.Price;

            await _context.SaveChangesAsync();
            return new Response
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price
            };
        }

        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

    }
}
