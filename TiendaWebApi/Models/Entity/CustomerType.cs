using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class CustomerType    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; } = string.Empty;

        // Foreign Keys

        public virtual IEnumerable<Customer> CustomersList { get; set; }

    }
}
