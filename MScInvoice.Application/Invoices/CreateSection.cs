using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class CreateSection
    {

        private ApplicationDbContext _context;
       /* private IHttpContextAccessor _httpContextAccessor;
        public CreateSection(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }*/
        public CreateSection(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public class Request
        {
            public int InvoiceId { get; set; }
            public List<Items> Items { get; set; }

        }
        public class Items
        {
            public int ItemId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            var invoiceSection = new InvoiceSection
            {
                Name = "section2",
                Date = DateTime.Now,
                InvoiceId = request.InvoiceId
            };

            _context.InvoiceSections.Add(invoiceSection);
            await _context.SaveChangesAsync();

            var items = new List<InvoiceItem>();

            foreach (var item in request.Items)
            {
                items.Add(new InvoiceItem
                {
                    InvoiceSectionId = invoiceSection.Id,
                    ItemId = item.ItemId,
                    Quantity = item.Quantity
                });
            }
            _context.InvoiceItems.AddRange(items);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
