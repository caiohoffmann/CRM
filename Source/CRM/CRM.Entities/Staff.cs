using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Entities
{
    [Table ("Staff")]
    public class Staff
    {
        [Key]
        public int idStaff { get; set; }
        [MaxLength (150)]
        [Required]
        public string nameStaff { get; set; }
        public string nuPhone { get; set; }
        [Required]
        [EmailAddress]
        public string adEmail { get; set; }
        [EmailAddress]
        public string adEmailPersonal { get; set; }
        [Required]
        public DateTime dtRegistration { get; set; }
        [Required]
        public int idStore { get; set; }
        public int idAddress { get; set; }
        [ForeignKey("idAddress")]
        public Address Address { get; set; }
        [ForeignKey("idStore")]
        public Store Store { get; set; }
    }
}
