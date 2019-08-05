using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Entities
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }
        [Required]
        [MaxLength(150)]
        public string nmCustomer { get; set; }
        [Required]
        [MaxLength(20)]
        public string nuPhone { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string adEmail { get; set; }
        [Required]
        public int nuCustomer { get; set; }
        [Required]
        public int idAddress { get; set; }
        [ForeignKey("idAddress")]
        public Address Address { get; set; }
    }
}
