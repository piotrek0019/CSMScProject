using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MScInvoice.Application.Invoices;
using MScInvoice.Database;

namespace MScInvoice.UI.Pages.Pdf
{
    public class InvoiceModel : PageModel
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public InvoiceModel(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public GetInvoice.InvoiceViewModel Invoice { get; set; }
        
        public  IActionResult OnGet(int id)
        {
            Invoice =  new GetInvoice(_context, _httpContextAccessor).Do(id);

            return Page();
        }
    }
}
