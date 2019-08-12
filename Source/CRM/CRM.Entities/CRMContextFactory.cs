using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class CRMContextFactory
    {
        public static CRMContext getContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CRMContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=crm;User=crm-sys;Password=test1234;");
            return new CRMContext(optionsBuilder.Options);                 
        }
    }
}
