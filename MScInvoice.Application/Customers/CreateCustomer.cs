using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace MScInvoice.Application.Customers
{
    public class CreateCustomer
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public CreateCustomer(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;


        }

        public async Task<Response> Do(Request request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var customer = new Customer
            {
                Name = request.Name,
                Address1 = request.Address1,
                Address2 = request.Address2,
                PostCode = request.PostCode,
                City = request.City,
                Number1 = request.Number1,
                MyUserId = userId
            };
            _context.Customers.Add(customer);

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
                MyUserId = customer.MyUserId
            };
        }

        public class Request
        {
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
            public string MyUserId { get; set; }
        }
    }
}
