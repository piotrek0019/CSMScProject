using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Items;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "User")]
    public class ItemsController : Controller
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public ItemsController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("")]
        public IActionResult GetItems() => Ok(new GetItems(_ctx, _httpContextAccessor).Do());

        [HttpGet("{id}")]
        public IActionResult GetItem(int id) => Ok(new GetItem(_ctx).Do(id));

        [HttpPost("")]
        public async Task<IActionResult> CreateItem([FromBody] CreateItem.Request request) => Ok((await new CreateItem(_ctx, _httpContextAccessor).Do(request)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItems(int id) => Ok((await new DeleteItem(_ctx).Do(id)));

        [HttpPut("")]
        public async Task<IActionResult> UptadeItem([FromBody] UpdateItem.Request request) => Ok((await new UpdateItem(_ctx).Do(request)));
    }
}
