using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.PayMethods
{
    public class UpdatePayMethod
    {
        private ApplicationDbContext _context;

        public UpdatePayMethod(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var payMethod = _context.PayMethods
                .FirstOrDefault(x => x.Id == request.Id);

            payMethod.Name = request.Name;
            


            await _context.SaveChangesAsync();
            return new Response
            {
                Id = payMethod.Id,
                Name = payMethod.Name,
                MyUserId = payMethod.MyUserId,
            };
        }

        public class Request
        {
            public int Id { get; set; }
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
