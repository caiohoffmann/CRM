using CRM.Entities;
using CRM.Repository;
using CRM.Util.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public interface ITicketBusiness
    {
        Task<IList<Ticket>> GetTickets();
        Task<Ticket> getTicketById(int id);
        Task saveTicket(Ticket ticket, Staff staff);
        Task updateTicket(Ticket ticket, Staff staff);
        Task DeleteByTicket(Ticket ticket);
        Task<bool> TicketExists(int id);
    }
    public class TicketBusiness : ITicketBusiness
    {

        TicketRepository ticketRepository;
        IRepository<TicketHistory> historyRepository;

        public TicketBusiness()
        {
            this.ticketRepository = new TicketRepository();
            this.historyRepository = new TicketHistoryRepository();
        }
        public async Task DeleteByTicket(Ticket ticket)
        {
            await ticketRepository.Delete(ticket);
        }

        public async Task<IList<Ticket>> GetTickets()
        {
            return await ticketRepository.GetList(t => true);
        }

        public async Task<Ticket> getTicketById(int id)
        {
            return await ticketRepository.Get(t => t.idTicket == id);
        }

        public async Task saveTicket(Ticket ticket, Staff staff)
        {
            ticket.dtOpening = DateTime.Now;
            ticket.dtClosing = null;
            ticket.dtDue = DateTime.Now.AddDays(3);
            ticket.idTicketStatus = (int)TicketStatusEnum.OPEN;
            ticket = await ticketRepository.Save(ticket,staff);
            
        }

        public async Task<bool> TicketExists(int id)
        {
            Ticket ticket = await ticketRepository.Get(t => t.idTicket == id);
            return ticket != null || ticket.idTicket > 0;
        }

        public async Task updateTicket(Ticket ticket,Staff staff)
        {
            Ticket t = await getTicketById(ticket.idTicket);
            ticket.dtOpening = t.dtOpening;
            ticket.dtDue = t.dtDue;
            ticket.dtClosing = t.dtClosing;
            
            await ticketRepository.Update(ticket,staff);
        }
    }
}
