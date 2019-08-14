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
    public class TicketHistoryRepository : IRepository<TicketHistory>
    {
        private CRMContext _context;
        public async Task Delete(TicketHistory t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.TicketHistories.Remove(t);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TicketHistory> Get(Expression<Func<TicketHistory, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                    return await _context.TicketHistories.Include(includeProperties).FirstOrDefaultAsync(predicate);
                else
                    return await _context.TicketHistories.FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<IList<TicketHistory>> GetList(Expression<Func<TicketHistory, bool>> predicate, string includeProperties = null)
        {
            using (_context = CRMContextFactory.getContext())
            {
                if (includeProperties != null)
                    return await _context.TicketHistories.Include(includeProperties).Where(predicate).ToListAsync();
                else
                    return await _context.TicketHistories.Where(predicate).ToListAsync();
            }
        }

        public async Task<TicketHistory> Save(TicketHistory t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                _context.TicketHistories.Add(t);
                await _context.SaveChangesAsync();
                return t;
            }
        }

        public async Task<TicketHistory> Update(TicketHistory t)
        {
            using (_context = CRMContextFactory.getContext())
            {
                var TicketHistoryes = await _context.TicketHistories.FirstOrDefaultAsync(TicketHistory => TicketHistory.idTicketHistory == t.idTicketHistory);
                TicketHistoryes = t;
                await _context.SaveChangesAsync();
                return t;
            }
        }
    }
}
