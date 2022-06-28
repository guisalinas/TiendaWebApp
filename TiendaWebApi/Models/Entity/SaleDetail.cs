using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class SaleDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        
        public int Quantity { get; set; }
        public int Discount { get; set; } 
        public int Total { get; set; }
        public int AmountDue { get; set; }


        // Foreign Keys
        [ForeignKey("SaleId")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<ProductInSaleDetail> PInSaleDetailList { get; set; }

    }
}
