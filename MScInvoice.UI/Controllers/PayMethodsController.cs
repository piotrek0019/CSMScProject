using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.PayMethods;
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
    public class PayMethodsController : Controller
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public PayMethodsController(ApplicationDbContext ctx, 
            IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("{id}")]
        public IActionResult GetPayMethod(int id) => 
            Ok(new GetPayMethod(_ctx).Do(id));

        [HttpGet("")]
        public IActionResult GetPayMethods() => 
            Ok(new GetPayMethods(_ctx, _httpContextAccessor).Do());

        [HttpPost("")]
        public async Task<IActionResult> 
            CreatePayMethod([FromBody] CreatePayMethod.Request request) => 
            Ok((await new CreatePayMethod(_ctx, _httpContextAccessor)
                .Do(request)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayMethod(int id) => 
            Ok((await new DeletePayMethod(_ctx).Do(id)));

        [HttpPut("")]
        public async Task<IActionResult> 
            UpdatePayMethod([FromBody] UpdatePayMethod.Request request) => 
            Ok((await new UpdatePayMethod(_ctx).Do(request)));
    }
}
