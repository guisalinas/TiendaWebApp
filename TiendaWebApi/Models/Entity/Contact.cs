using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        public string Description { get; set; }  = string.Empty; // Contact Name, contact work position, contact schedule, etc. 

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;

        [StringLength(30)]
        public string Phone { get; set; } = string.Empty;

        // Foreign Keys
        public virtual IEnumerable<Address> AddressesList { get; set; }

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

    }
}
