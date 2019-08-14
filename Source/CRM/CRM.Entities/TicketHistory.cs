using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Entities
{
    public class TicketHistory
    {
        [Key]
        public int idTicketHistory { get; set; }
        [Required]
        public int idTicket { get; set; }
        public int? idStaffAssigned { get; set; }
        [Required]
        public int idTicketStatus { get; set; }
        [Required]
        public int idStaffAssigns { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
        public DateTime? dtAssigned { get; set; }
        [ForeignKey("idTicket")]
        public Ticket Ticket { get; set; }
        [ForeignKey("idTicketStatus")]
        public TicketStatus TicketStatus { get; set; }
        [ForeignKey("idStaffAssigns")]
        public Staff StaffAssigns { get; set; }       
        [ForeignKey("idStaffAssigned")]
        public Staff StaffAssigned { get; set; }
        
    }
}
