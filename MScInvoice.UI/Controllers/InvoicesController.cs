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
    //[Route("[controller]")]
    //[Authorize(Policy = "User")]
    public class InvoicesController : Controller
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public InvoicesController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }
       
        [HttpGet("invoices/{id}")]
        public IActionResult GetInvoice(int id) => Ok(new GetInvoice(_ctx, _httpContextAccessor).Do(id));
        [HttpPost("invoices")]
        public async Task<IActionResult> CreateInvoice([FromBody] CreateInvoice.Request request) => Ok((await new CreateInvoice(_ctx, _httpContextAccessor).Do(request)));
        //[HttpPost("sections")]
        //public async Task<IActionResult> CreateSection([FromBody] CreateSection.Request request) => Ok((await new CreateSection(_ctx, _httpContextAccessor).Do(request)));
        [HttpPost("sections")]
        public async Task<IActionResult> CreateSection([FromBody] CreateSection.Request request) => Ok((await new CreateSection(_ctx).Do(request)));

        [HttpGet("invoices")]
        public IActionResult GetInvoices() => Ok(new GetInvoices(_ctx, _httpContextAccessor).Do());
    }
}
