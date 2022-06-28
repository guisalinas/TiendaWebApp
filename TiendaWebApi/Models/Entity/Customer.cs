using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Customer : Person
    {
        //public int Id { get; set; }

        // Foreign Keys

        /*public int PersonId { get; set; }
        public Person Person { get; set; }*/
        public virtual IEnumerable<Sale> SalesList { get; set; }

        public int CustomerTypeId { get; set; }

        [ForeignKey("CustomerTypeId")]
        public virtual CustomerType CustomerType { get; set; }




    }
}
