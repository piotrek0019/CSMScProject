using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Customers;
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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public CustomersController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }



        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id) => Ok(new GetCustomer(_ctx).Do(id));
        [HttpGet("")]
        public IActionResult GetCustomers() => Ok(new GetCustomers(_ctx, _httpContextAccessor).Do());
        [HttpPost("")]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomer.Request request) => Ok((await new CreateCustomer(_ctx, _httpContextAccessor).Do(request)));
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id) => Ok((await new DeleteCustomer(_ctx).Do(id)));
        [HttpPut("")]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomer.Request request) => Ok((await new UpdateCustomer(_ctx).Do(request)));
    }
}
