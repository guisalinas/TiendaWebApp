using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Customer 
    {
        public int Id { get; set; }

        // Foreign Keys
        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual IEnumerable<Sale> SalesList { get; set; }

        public virtual CustomerType CustomerType { get; set; }


    }
}
