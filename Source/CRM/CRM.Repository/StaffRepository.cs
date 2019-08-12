using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Repository
{
    public class StaffRepository : IRepository<Staff>
    {
        public void Delete(Staff t)
        {
            throw new NotImplementedException();
        }

        public Staff Get(Func<Staff, bool> predicate)
        {
            return null;
        }

        public IList<Staff> GetList(Func<Staff, bool> predicate)
        {
            return null;

        }

        public Staff Save(Staff t)
        {
            return null;
        }

        public Staff Update(Staff t)
        {
            throw new NotImplementedException();
        }
    }
}
