using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MScInvoice.Application.Items
{
    public class GetItem
    {
        private ApplicationDbContext _ctx;

        public GetItem(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public ItemViewModel Do(int id) =>
            _ctx.Items.Where(x => x.Id == id).Select(x => new ItemViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Tax = x.Tax
            })
            .FirstOrDefault();
        public class ItemViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Tax { get; set; }
        }
    }
}
