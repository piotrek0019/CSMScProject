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
        private IHttpContextAccessor _httpContextAccessor;

        public InvoicesController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }
       
        [HttpGet("{id}")]
        public IActionResult GetInvoice(int id) => Ok(new GetInvoice(_ctx, _httpContextAccessor).Do(id));
        [HttpPost("")]
        public async Task<IActionResult> CreateInvoice([FromBody] CreateInvoice.Request request) => Ok((await new CreateInvoice(_ctx, _httpContextAccessor).Do(request)));
        //[HttpPost("sections")]
        //public async Task<IActionResult> CreateSection([FromBody] CreateSection.Request request) => Ok((await new CreateSection(_ctx, _httpContextAccessor).Do(request)));
        //[HttpPost("")]
        //public async Task<IActionResult> CreateSection([FromBody] CreateSection.Request request) => Ok((await new CreateSection(_ctx).Do(request)));

        [HttpGet("")]
        public IActionResult GetInvoices() => Ok(new GetInvoices(_ctx, _httpContextAccessor).Do());
        [HttpPut("")]
        public async Task<IActionResult> UpdateInvoice([FromBody] UpdateInvoice.Request request) => Ok((await new UpdateInvoice(_ctx, _httpContextAccessor).Do(request)));
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id) => Ok((await new DeleteInvoice(_ctx).Do(id)));
    }
}
