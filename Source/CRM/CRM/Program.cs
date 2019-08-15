using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CRM.Entities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CRM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    var roleManager = services.GetService<RoleManager<IdentityRole>>();
            //    if (!roleManager.RoleExistsAsync("Admin").ConfigureAwait(true).GetAwaiter().GetResult())
            //    {
            //        roleManager.CreateAsync(new IdentityRole("Admin")).ConfigureAwait(true).GetAwaiter().GetResult();
            //    }
            //    if (!roleManager.RoleExistsAsync("Employee").ConfigureAwait(true).GetAwaiter().GetResult())
            //    {
            //        roleManager.CreateAsync(new IdentityRole("Employee")).ConfigureAwait(true).GetAwaiter().GetResult();
            //    }
            //}
            
            //using (var context = CRMContextFactory.getContext())
            //{
            //    context.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser()
            //    {
            //        Email = "test@crm.com",
            //        UserName = "test@crm.com",
            //        Id = "1",
            //        EmailConfirmed = true,
            //        PhoneNumberConfirmed = true,
            //        LockoutEnabled = false,
            //        AccessFailedCount = 0,
            //        TwoFactorEnabled = false
            //    });
            //    try
            //    {
            //        context.SaveChanges();
            //    }
            //    catch { }
            //}
            host.Run();


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
