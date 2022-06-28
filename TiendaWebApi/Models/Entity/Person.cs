using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string BusinessName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Identifier { get; set; }= string.Empty; // Dni, Cuit, Cuil, LC, etc.

        public DateTime DateBirth { get; set; }

        public DateTime DischargeDate { get; set; }     

        // Foreign Keys

        //public int CustomerId { get; set; }
        /*public Customer Customer{ get; set; }


        //public int ProviderId { get; set; }
        public Provider Provider { get; set; }*/

        public virtual IEnumerable<Contact> ContactsList { get; set; }
    }
}
