using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Customers
{
    public class GetCustomers
    {
        private ApplicationDbContext _ctx;
        private IHttpContextAccessor _httpContextAccessor;

        public GetCustomers(ApplicationDbContext ctx, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<CustomerViewModel> Do()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _ctx.Customers.Where(x => x.MyUserId == userId).ToList().Select(x => new CustomerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Address1 = x.Address1,
                Address2 = x.Address2,
                PostCode = x.PostCode,
                City = x.City,
                Number1 = x.Number1,
            });
        }
        public class CustomerViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string PostCode { get; set; }
            public string City { get; set; }
            public string Number1 { get; set; }
        }
    }
}
