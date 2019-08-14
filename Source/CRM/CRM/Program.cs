using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CRM.Entities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CRM
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            CreateWebHostBuilder(args).Build().Run();

            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
