using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.PayMethods
{
    public class CreatePayMethod
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public CreatePayMethod(ApplicationDbContext context, 
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;


        }

        public async Task<Response> Do(Request request)
        {
            var userId = _httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier).Value;

            var payMethod = new PayMethod
            {
                Name = request.Name,
                MyUserId = userId
            };
            _context.PayMethods.Add(payMethod);

            await _context.SaveChangesAsync();

            return new Response
            {
                Id = payMethod.Id,
                Name = payMethod.Name,
                MyUserId = payMethod.MyUserId
            };
        }

        public class Request
        {
            public string Name { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string MyUserId { get; set; }
        }
    }
}
