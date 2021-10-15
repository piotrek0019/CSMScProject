using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using MScInvoice.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using System.Linq;
using static MScInvoice.Application.Items.GetItems;

namespace UnitTest
{
    public class ItemsControllerTests
    {
        //private IHttpContextAccessor _httpContextAccessor;
        [Fact]
        public void ItemsController_LastItemFromDatabase()
        {

            //change for static user ID in GetItems
            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase(MethodBase.GetCurrentMethod().Name);
            using (ApplicationDbContext ctx = new ApplicationDbContext(optionsBuilder.Options, null))
            {
                ctx.Add(new Item() { Name = "Foo", MyUserId = "1ea7e2ca-5310-414d-9cb4-8d4e61eb72e8" });
                ctx.SaveChanges();
            }
            IActionResult result;
            using (ApplicationDbContext ctx = new ApplicationDbContext(optionsBuilder.Options, null))
            {
                result = new ItemsController(ctx, null).GetItems();
            }

            var okResult = Assert.IsType<OkObjectResult>(result);
            var items = Assert.IsType<List<ItemViewModel>>(okResult.Value);
            var item = Assert.Single(items);
            Assert.NotNull(item);
            Assert.Equal(1, item.Id);
            Assert.Equal("Foo", item.Name);
        }
    }
}
