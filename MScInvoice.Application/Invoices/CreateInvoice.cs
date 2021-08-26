using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class CreateInvoice
    {
        private ApplicationDbContext _context;
        //private IHttpContextAccessor _httpContextAccessor;

       /* public CreateInvoice(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }*/
        public CreateInvoice(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public class Items
        {
            public int ItemId { get; set; }
        }

        public class InvoiceViewModel
        {
            public int CustomerId { get; set; }
            public int PayMethodId { get; set; }
            public List<Items> Items { get; set; }

        }

        public async Task<bool> Do(InvoiceViewModel invoiceViewModel)
        {
            //static userId just for postman
            var userId = "49d882f8-9a19-4701-a7be-45a697e8da90";
            //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var invoice = new Invoice
            {
                InvoiceNo = "11111",
                CustomerId = invoiceViewModel.CustomerId,
                Date = DateTime.Now,
                
                MyUserId = userId,
                PayMethodId = invoiceViewModel.PayMethodId
            };

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            var invoiceSection = new InvoiceSection
            {
                Name = "blabla",
                Date = DateTime.Now,
                InvoiceId = invoice.Id
            };

            _context.InvoiceSections.Add(invoiceSection);
            await _context.SaveChangesAsync();

            var items = new List<InvoiceItem>();

            foreach(var item in invoiceViewModel.Items)
            {
                items.Add(new InvoiceItem
                {
                    InvoiceSectionId = invoiceSection.Id,
                    ItemId = item.ItemId,
                    Quantity = 2
                });
            }
            _context.InvoiceItems.AddRange(items);

            await _context.SaveChangesAsync();
            return true;

        }
      
      
        /*public class InvoiceViewModel2
        {
            public Invoice Invoice { get; set; }
            public InvoiceSection InvoiceSection { get; set; }
           
            public List<InvoiceItem> invoiceItem { get; set; }

        }*/

        
    }
}
