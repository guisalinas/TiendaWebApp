using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class ProductInPurchaseDetail
    {
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int PurchaseDetailId { get; set; }

        [ForeignKey("PurchaseDetailId")]
        public virtual PurchaseDetail PurchaseDetail { get; set; }

    }
}
