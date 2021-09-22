using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MScInvoice.Database;
using MScInvoice.Domain.Models;

namespace MScInvoice.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            try 
            { 
                using (var scope = host.Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<MyUser>>();

                    context.Database.EnsureCreated();

                    if(!context.Users.Any())
                    {
                        var adminUser = new MyUser()
                        {
                            UserName = "Admin"
                        };
                        var testUser = new MyUser()
                        {
                            UserName = "Test"
                        };

                        userManager.CreateAsync(adminUser, "password").GetAwaiter().GetResult();
                        userManager.CreateAsync(testUser, "password").GetAwaiter().GetResult();

                        var adminClaim = new Claim("Role", "Admin");
                        var userClaim = new Claim("Role", "User");

                        userManager.AddClaimAsync(adminUser, adminClaim).GetAwaiter().GetResult();
                        userManager.AddClaimAsync(testUser, userClaim).GetAwaiter().GetResult();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
