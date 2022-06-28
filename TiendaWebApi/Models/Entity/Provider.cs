using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Provider : Person
    {
        //[Key]
       // public int Id { get; set; }

        // Foreign Keys

       /* public int PersonId { get; set; }
        public Person Person { get; set; }*/

        public virtual IEnumerable<Purchase> PurchasesList { get; set; }

    }
}
