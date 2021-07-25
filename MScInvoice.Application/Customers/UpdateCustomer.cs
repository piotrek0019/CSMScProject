using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Customers
{
    public class UpdateCustomer
    {
        private ApplicationDbContext _context;

        public UpdateCustomer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == request.Id);

            customer.Name = request.Name;
            customer.Address1 = request.Address1;
            customer.Address2 = request.Address2;
            customer.PostCode = request.PostCode;
            customer.City = request.City;
            customer.Number1 = request.Number1;


            await _context.SaveChangesAsync();
            return new Response
            {
                Id = customer.Id,
                Name = customer.Name,
                Address1 = customer.Address1,
                Address2 = customer.Address2,
                PostCode = customer.PostCode,
                City = customer.City,
                Number1 = customer.Number1,
            };
        }

        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string PostCode { get; set; }
            public string City { get; set; }
            public string Number1 { get; set; }
        }

        public class Response
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
