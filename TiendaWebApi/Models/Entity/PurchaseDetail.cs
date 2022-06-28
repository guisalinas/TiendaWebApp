using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class PurchaseDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }= string.Empty;
        public int Total { get; set; }

        //Foreign Key
        public int PurchaseId { get; set; }

        [ForeignKey("PurchaseId")]
        public virtual Purchase Purchase { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<ProductInPurchaseDetail> PInPurchaseDetailList { get; set; }

    }
}
