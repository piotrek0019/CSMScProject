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
    public class UpdateInvoice
    {
        private ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public UpdateInvoice(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
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

        public class Sections
        {
            public string Name { get; set; }

            public DateTime Date { get; set; }
            public List<Items> Items { get; set; }
        }

        public class Request
        {
            public int InvoiceId { get; set; }
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerAddress1 { get; set; }
            public string CustomerAddress2 { get; set; }
            public string CustomerCity { get; set; }
            public string CustomerPostCode { get; set; }
            public string CustomerNumber1 { get; set; }
            public int PayMethodId { get; set; }
            public List<Sections> Sections { get; set; }

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

            if (request.CustomerId != 0)
            {
                var customer = _context.Customers.FirstOrDefault(x => x.Id == request.CustomerId);

                customer.Name = request.CustomerName;
                customer.Address1 = request.CustomerAddress1;
                customer.Address2 = request.CustomerAddress2;
                customer.PostCode = request.CustomerPostCode;
                customer.City = request.CustomerCity;
                customer.Number1 = request.CustomerNumber1;
                

                await _context.SaveChangesAsync();
            }
            
            var deleteSections = _context.InvoiceSections.Where(x => x.InvoiceId == request.InvoiceId);

           

           _context.InvoiceSections.RemoveRange(deleteSections);
            await _context.SaveChangesAsync();

            foreach (var section in request.Sections)
            {
                foreach (var item in section.Items)
                {
                    if (item.ItemId == 0)
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

                    if (itemDb.Name != item.Name || itemDb.Price != item.Price)
                    {
                        itemDb.Name = item.Name;
                        itemDb.Price = item.Price;

                        await _context.SaveChangesAsync();
                    }
                }
            }

            
            var sections = new InvoiceSection();
            var items = new List<InvoiceItem>();
            foreach (var section in request.Sections)
            {
                string sectionDate = section.Date.ToString();
                sections.InvoiceId = request.InvoiceId;
               if(DateTime.Equals(section.Date, new DateTime(1, 1, 1, 0, 0, 0)))
               {
                    sections.Date = DateTime.Now;
               }
               else
               {
                    sections.Date = section.Date;
               }
                sections.Name = section.Name;

                _context.InvoiceSections.Add(sections);
                await _context.SaveChangesAsync();

                foreach (var item in section.Items)
                {
                    items.Add(new InvoiceItem
                    {
                        InvoiceSectionId = sections.Id,
                        ItemId = item.ItemId,
                        Quantity = item.Quantity
                    });
                }
                _context.InvoiceItems.AddRange(items);
                await _context.SaveChangesAsync();

                items.Clear();
                sections = null;
                sections = new InvoiceSection();
            }

            var invoice = _context.Invoices.FirstOrDefault(x => x.Id == request.InvoiceId);


            return new Response
            {
                Id = invoice.Id,
                InvoiceNo = invoice.InvoiceNo,
                Date = invoice.Date.ToString("dd/MM/yyyy"),
                CustomerId = invoice.CustomerId,
                CustomerName = request.CustomerName

            };
        }


    }
}
