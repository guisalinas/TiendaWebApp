using System;
using System.ComponentModel.DataAnnotations;

namespace TiendaWebApi.Models.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Size { get; set; }
       
        [StringLength(20)]
        public string Color { get; set; } = string.Empty ;
       // public int Stock { get; set; }

        //public DateTime DischargeDate { get; set; }

    }
}
