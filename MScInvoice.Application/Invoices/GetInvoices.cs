using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class GetInvoices
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;


        public GetInvoices(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
         {
             _context = context;
             _httpContextAccessor = httpContextAccessor;
         }
        
        public class InvoiceViewModel
        {
            public int Id { get; set; }
            public string InvoiceNo { get; set; }
            public string Date { get; set; }
            public int CustomerId { get; set; }

            public string CustomerName { get; set; }

        }

        public IEnumerable<InvoiceViewModel> Do()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var invoices = _context.Invoices
                .Where(x => x.MyUserId == userId)
                .Include(x => x.Customer)
                .Select(x => new InvoiceViewModel
                { 
                    Id = x.Id,
                    InvoiceNo = x.InvoiceNo,
                    Date = x.Date.ToString("dd/MM/yyyy"),
                    CustomerName = x.Customer.Name
                }).ToList();

            return invoices;
        }
    }
}
