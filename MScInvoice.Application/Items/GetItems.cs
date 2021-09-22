using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace MScInvoice.Application.Items
{
    public class GetItems
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public GetItems(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<ItemViewModel> Do()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _ctx.Items.ToList().Where(x => x.MyUserId == userId).Select(x => new ItemViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Tax = x.Tax
            });
        }
        public class ItemViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Tax { get; set; }
        }
    }
}
