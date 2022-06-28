using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }

        // Foreign Keys
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public int PayModeId { get; set; }

        [ForeignKey("PayModeId")]
        public virtual PayMode PayMode { get; set; }

        public int SaleDetailId { get; set; }

        [ForeignKey("SaleDetailId")]
        public virtual SaleDetail SaleDetail { get; set; }
    }
}
