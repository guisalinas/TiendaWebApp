using AutoMapper;
using TiendaWebApi.Models.DTOs;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Mapper
{
    public class MapperProfile : Profile
    {
      
        public MapperProfile()
        {
            //Create
            CreateMap<ProductCreateDTO, Product>();
            //Update
            CreateMap<ProductUpdateDTO, Product>();
            //ToList
            CreateMap<Product, ProductToListDTO>();


        }
    }
}
