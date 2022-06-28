using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class ProductInSaleDetail
    {
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int SaleDetailId { get; set; }

        [ForeignKey("SaleDetailId")]
        public virtual SaleDetail SaleDetail { get; set; }
    }
}
