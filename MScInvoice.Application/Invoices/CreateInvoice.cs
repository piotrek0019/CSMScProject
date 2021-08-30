using Microsoft.AspNetCore.Http;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.Invoices
{
    public class CreateInvoice
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

       public CreateInvoice(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
      
        public class Items
        {
            public int ItemId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        public class Request
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerAddress1 { get; set; }
            public string CustomerAddress2 { get; set; }
            public string CustomerCity { get; set; }
            public string CustomerPostCode { get; set; }
            public string CustomerNumber1 { get; set; }
            public int PayMethodId { get; set; }
            public List<Items> Items { get; set; }

        }
        public class Response
        {
            public int Id { get; set; }
            public string InvoiceNo { get; set; }
            public string Date { get; set; }
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
        }

        public async Task<Response> Do(Request request)
        {
            
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (request.CustomerId == 0)
            {
                var customer = new Customer
                {
                    Name = request.CustomerName,
                    Address1 = request.CustomerAddress1,
                    Address2 = request.CustomerAddress2,
                    PostCode = request.CustomerPostCode,
                    City = request.CustomerCity,
                    Number1 = request.CustomerNumber1,
                    MyUserId = userId
                };
                
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                request.CustomerId = customer.Id;
            }

            foreach(var item in request.Items)
            {
                if(item.ItemId == 0)
                {
                    var newItem = new Item
                    {
                        Name = item.Name,
                        Price = item.Price,
                        MyUserId = userId
                        
                    };

                    _context.Items.Add(newItem);
                    await _context.SaveChangesAsync();
                    item.ItemId = newItem.Id;
                }

                var itemDb = _context.Items.FirstOrDefault(x => x.Id == item.ItemId);

                if(itemDb.Name != item.Name || itemDb.Price !=item.Price)
                {
                    itemDb.Name = item.Name;
                    itemDb.Price = item.Price;

                    await _context.SaveChangesAsync();
                }
            }
            var invoice = new Invoice
            {
                InvoiceNo = "11111",
                CustomerId = request.CustomerId,
                Date = DateTime.Now,
                
                MyUserId = userId,
                PayMethodId = request.PayMethodId
            };

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            var invoiceSection = new InvoiceSection
            {
                Name = "blabla",
                Date = DateTime.Now,
                InvoiceId = invoice.Id
            };

            _context.InvoiceSections.Add(invoiceSection);
            await _context.SaveChangesAsync();

            var items = new List<InvoiceItem>();

            foreach(var item in request.Items)
            {
                items.Add(new InvoiceItem
                {
                    InvoiceSectionId = invoiceSection.Id,
                    ItemId = item.ItemId,
                    Quantity = item.Quantity
                });
            }
            _context.InvoiceItems.AddRange(items);

            await _context.SaveChangesAsync();

           
            


            return new Response
            { 
                Id = invoice.Id,
                InvoiceNo = invoice.InvoiceNo,
                Date = invoice.Date.ToString("dd/MM/yyyy"),
                CustomerId = invoice.CustomerId,
                CustomerName = request.CustomerName

           };

        }
      
      
        /*public class InvoiceViewModel2
        {
            public Invoice Invoice { get; set; }
            public InvoiceSection InvoiceSection { get; set; }
           
            public List<InvoiceItem> invoiceItem { get; set; }

        }*/

        
    }
}
