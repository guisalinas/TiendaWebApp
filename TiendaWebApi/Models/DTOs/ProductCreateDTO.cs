using System;

namespace TiendaWebApi.Models.DTOs
{
    public class ProductCreateDTO
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public DateTime DischargeDate { get; set; }
       
        public ProductCreateDTO()
        {
            DischargeDate = DateTime.Now;
        }
    }
}
