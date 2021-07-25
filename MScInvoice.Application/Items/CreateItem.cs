using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Items
{
    public class CreateItem
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public CreateItem(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Response> Do(Request request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var item = new Item
            {
                Name = request.Name,
                Price = request.Price,
                MyUserId = userId
                
            };
            _context.Items.Add(item);

            await _context.SaveChangesAsync();

            return new Response
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price
            };
        }

        public class Request
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string MyUserId { get; set; }

        }

    }
}
