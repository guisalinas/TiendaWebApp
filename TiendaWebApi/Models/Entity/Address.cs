using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string StreetName { get; set; } = string.Empty;

        public int StreetNumber { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        // Foreign Keys
        public int ContactId { get; set; }

        [ForeignKey("ContactId")]
        public virtual Contact Contact { get; set; }

    }
}
