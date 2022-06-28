using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWebApi.Models.Entity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Size { get; set; }
       
        [StringLength(50)]
        public string Description { get; set; } = string.Empty ;
        public int Stock { get; set; }
        public DateTime DischargeDate { get; set; }

        // Foreign Keys
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public virtual ProductType ProductType { get; set; }

        public virtual IEnumerable<ProductInPurchaseDetail> PInPurchaseDetailList { get; set; }
        public virtual IEnumerable<ProductInSaleDetail> PInSaleDetailList { get; set; }
    }
}
