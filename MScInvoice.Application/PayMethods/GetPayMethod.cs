using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.PayMethods
{
    public class GetPayMethod
    {
        private ApplicationDbContext _ctx;

        public GetPayMethod(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public PayMethodViewModel Do(int id) =>
            _ctx.PayMethods.Where(x => x.Id == id).Select(x => new PayMethodViewModel
            {
                Id = x.Id,
                Name = x.Name,
            })
            .FirstOrDefault();
        public class PayMethodViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
