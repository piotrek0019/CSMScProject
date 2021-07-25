using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.PayMethods
{
    public class GetPayMethods
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public GetPayMethods(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<PayMethodViewModel> Do()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _ctx.PayMethods.Where(x => x.MyUserId == userId).ToList().Select(x => new PayMethodViewModel
            {
                Id = x.Id,
                Name = x.Name,
            });
        }
        public class PayMethodViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }    
        }
    }
}
