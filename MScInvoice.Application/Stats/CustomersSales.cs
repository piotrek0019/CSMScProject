using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Stats
{
    public class GetCustomersSales
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;


        public GetCustomersSales(ApplicationDbContext context, 
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public class CustomerSalesVM
        {
            public string CustomerName { get; set; }
            public decimal SalesValue { get; set; }

        }
        public class InvoiceVM
        {
            public int InvoiceId { get; set; }
            public IEnumerable<InvoiceSections> InvoiceSections { get; set; }
        }

        public class InvoiceSections
        {
            public int SectionId { get; set; }

            public IEnumerable<InvoiceItem> InvoiceItems { get; set; }

        }
        public class InvoiceItem
        {
            public int ItemId { get; set; }
            public decimal Price { get; set; }
        }

        public List<CustomerSalesVM> Do()
        {
            var userId = _httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier).Value;

            var customers = _context.Customers
                    .Where(x => x.MyUserId == userId)
                    .Include(x => x.Invoice)
                    .ThenInclude(x => x.InvoiceSection)
                    .ThenInclude(x => x.InvoiceItem)
                    .Select(x => new CustomerSalesVM
                    {
                        CustomerName = x.Name,
                        SalesValue = x.Invoice
                        .SelectMany(i => i.InvoiceSection)
                        .SelectMany(d => d.InvoiceItem)
                        .Sum(y => y.Price * y.Quantity)
                    }).ToList();

            return customers;
        }


    }
}
