﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class GetInvoice
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

         public GetInvoice(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
         {
             _context = context;
             _httpContextAccessor = httpContextAccessor;
         }
       
        public class InvoiceSections
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public int InvoiceId { get; set; }
           
            public IEnumerable<InvoiceItem> InvoiceItem { get; set; }

        }
        public class InvoiceItem
        {
            public int Quantity { get; set; }
            public string ItemName { get; set; }
            public string ItemDescription { get; set; }
            public decimal ItemPrice { get; set; }
            public string ItemMyUserId { get; set; }
        }
        public class Items
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public string MyUserId { get; set; }
        }
        public class InvoiceViewModel
        {
            public int Id { get; set; }
            public string InvoiceNo { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public string MyUserId { get; set; }
            public int CustomerId { get; set; }
            public int PayMethodId { get; set; }
            public IEnumerable<InvoiceSections> InvoiceSections { get; set; }
            

        }

        public InvoiceViewModel Do(int id)
        {
            var invoice = _context.Invoices
                .Where(x => x.Id == id)
                .Include(x => x.InvoiceSection)
                .ThenInclude(x => x.InvoiceItem)
                .ThenInclude(x => x.Item)
                .Select(x => new InvoiceViewModel
                {
                    Id = x.Id,
                    InvoiceNo = x.InvoiceNo,
                    Date = x.Date,
                    Description = x.Description,
                    MyUserId = x.MyUserId,
                    CustomerId = x.CustomerId,
                    PayMethodId = x.PayMethodId,

                    InvoiceSections = x.InvoiceSection
                        .Select(y => new InvoiceSections
                        {
                            Id = y.Id,
                            Name = y.Name,
                            Date = y.Date,
                            InvoiceId = y.InvoiceId,

                            InvoiceItem = y.InvoiceItem
                                .Select(d => new InvoiceItem
                                {
                                    Quantity = d.Quantity,
                                    ItemName = d.Item.Name,
                                    ItemDescription = d.Item.Description,
                                    ItemPrice = d.Item.Price,
                                    ItemMyUserId = d.Item.MyUserId
                                })
                        })
                    //something ToList??
                }).FirstOrDefault();

            return invoice;
        }
    }
}
