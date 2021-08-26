using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Invoices;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    [Route("[controller]")]
    //[Authorize(Policy = "User")]
    public class InvoicesController : Controller
    {
        private ApplicationDbContext _ctx;
        //private IHttpContextAccessor _httpContextAccessor;

        /*public InvoicesController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }*/
        public InvoicesController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("{id}")]
        public IActionResult GetInvoice(int id) => Ok(new GetInvoice(_ctx).Do(id));
        //[HttpPost("")]
        //public async Task<IActionResult> CreateCustomer([FromBody] CreateInvoice.InvoiceViewModel invoiceViewModel) => Ok((await new CreateInvoice(_ctx, _httpContextAccessor).Do(invoiceViewModel)));
        [HttpPost("")]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateInvoice.InvoiceViewModel invoiceViewModel) => Ok((await new CreateInvoice(_ctx).Do(invoiceViewModel)));

    }
}
