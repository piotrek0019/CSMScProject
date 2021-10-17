using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Stats;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    [Route("[controller]")]
    public class StatsController : Controller
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public StatsController(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult GetCustomersSales() => Ok(new GetCustomersSales(_ctx, _httpContextAccessor).Do());
    }
}
