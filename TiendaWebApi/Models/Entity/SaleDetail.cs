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
        public double Discount { get; set; } 
        public double Total { get; set; }
        public double AmountDue { get; set; }


        // Foreign Keys
        [ForeignKey("SaleId")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }

        public virtual IEnumerable<ProductInSaleDetail> PInSaleDetailList { get; set; }

    }
}
