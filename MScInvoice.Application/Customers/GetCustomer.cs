using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Customers
{
    public class GetCustomer
    {
        private ApplicationDbContext _ctx;

        public GetCustomer(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public CustomerViewModel Do(int id) =>
            _ctx.Customers.Where(x => x.Id == id).Select(x => new CustomerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Address1 = x.Address1,
                Address2 = x.Address2,
                PostCode = x.PostCode,
                City = x.City,
                Number1 = x.Number1,
            })
            .FirstOrDefault();
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
