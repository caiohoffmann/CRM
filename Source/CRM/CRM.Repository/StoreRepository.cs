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
    public class StoreRepository : IRepository<Store>
    {
        private CRMContext _context;
        public async Task Delete(Store t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.Stores.Remove(t);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Store> Get(Expression<Func<Store, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                {

                    return await _context.Stores.Include(s => s.Address).Include(s => s.Country).FirstOrDefaultAsync(predicate);
                }
                else
                    return await _context.Stores.Include(s => s.Address).FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<IList<Store>> GetList(Expression<Func<Store, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                    return await _context.Stores.Where(predicate).Include(includeProperties).ToListAsync();
                else
                    return await _context.Stores.Include(s => s.Address).Where(predicate).ToListAsync();

            }
        }

        public async Task<Store> Save(Store t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.Stores.Add(t);
                await _context.SaveChangesAsync();
                return t;
            }
        }

        public async Task<Store> Update(Store t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                var Stores = await _context.Stores.FirstOrDefaultAsync(Store => Store.idStore == t.idStore);
                Stores = t;
                await _context.SaveChangesAsync();
                return t;
            }
        }
    }
}
