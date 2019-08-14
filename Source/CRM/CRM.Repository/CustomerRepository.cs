using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private CRMContext _context;
        public async Task Delete(Customer t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.Customers.Remove(t);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Customer> Get(Expression<Func<Customer, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                    return await _context.Customers.Include(includeProperties).FirstOrDefaultAsync(predicate);
                else
                    return await _context.Customers.Include(s => s.Address).FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<IList<Customer>> GetList(Expression<Func<Customer, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                    return await _context.Customers.Include(includeProperties).Where(predicate).ToListAsync();
                else
                    return await _context.Customers.Include(s => s.Address).Where(predicate).ToListAsync();
            }
        }

        public async Task<Customer> Save(Customer t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.Customers.Add(t);
                await _context.SaveChangesAsync();
                return t;
            }
        }

        public async Task<Customer> Update(Customer t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                var Customers = await _context.Customers.FirstOrDefaultAsync(Customer => Customer.idCustomer == t.idCustomer);
                Customers = t;
                await _context.SaveChangesAsync();
                return t;
            }
        }
    }
}
