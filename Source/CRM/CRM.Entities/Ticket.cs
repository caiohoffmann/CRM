using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Entities
{
    public class Ticket
    {
        [Key]
        public int idTicket { get; set; }
        [Required]
        public string deTicket { get; set; }
        [Required]
        public DateTime dtOpening { get; set; }
        public DateTime dtClosing { get; set; }
        [Required]
        public DateTime dtDue { get; set; }
        public int idStaffAssignedTo { get; set; }
        [ForeignKey("idStaffAssignedTo")]
        public Staff staffAssignedTo { get; set; }
        public int idTicketStatus { get; set; }
        [ForeignKey("idTicketStatus")]
        public TicketStatus ticketStatus { get; set; }
    }
}
