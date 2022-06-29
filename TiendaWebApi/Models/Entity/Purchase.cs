using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Foreign Keys

        public int ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        public virtual Provider Provider { get; set; }
        
        public virtual PurchaseDetail PurchaseDetail { get; set; }

    }
}
