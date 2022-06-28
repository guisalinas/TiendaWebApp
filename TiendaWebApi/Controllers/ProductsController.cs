using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TiendaWebApi.Models.Data.Interfaces;
using TiendaWebApi.Models.DTOs;
using TiendaWebApi.Models.Entity;
using TiendaWebApi.Utils;

namespace TiendaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository pRepository;

        private readonly IMapper mapper;

        public ProductsController(IProductRepository _pRepository, IMapper _mapper)
        {
            pRepository = _pRepository;
            mapper = _mapper;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await pRepository.GetProductsAsync();
            return Ok(products);
        }

   
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await pRepository.GetProductByIdAsync(id);
            
            if (product == null)
            {
                return NotFound(Message.ProductNotFound);
            }
            
            return Ok(product);
        }

        [HttpGet("Name/{name}")] //Elimina ambiguedad
        public async Task<IActionResult> Get(string name)
        {
            var product = await pRepository.GetProductByNameAsync(name);

            if (product == null)
            {
                return NotFound(Message.ProductNotFound);
            }

            return Ok(product);
        }

        [HttpPost]

        public async Task<IActionResult> Post(ProductCreateDTO cProductDTO)
        {
           /* var productToCreate = new Product();
            productToCreate.Name = productDTO.Name;
            productToCreate.Price= productDTO.Price;
            productToCreate.Size = productDTO.Size;
            productToCreate.Description = productDTO.Description;*/

            var productToCreate = mapper.Map<Product>(cProductDTO);

            pRepository.Add(productToCreate);

            if (!await pRepository.SaveAll()) //validation
            {
                return BadRequest(Message.SaveFailed);
            }

            return Ok(Message.SaveSuccessful);

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, ProductUpdateDTO productDTO)
        {

            if (id != productDTO.Id)
            {
                return BadRequest(Message.IdNotMatch);
            }

            var pToUpdate = await pRepository.GetProductByIdAsync(productDTO.Id);

            if (pToUpdate == null)
            {
                return BadRequest(Message.ProductNotFound);
            }

            /* pToUpdate.Name = productDTO.Name;
             pToUpdate.Price = productDTO.Price;*/

            mapper.Map(productDTO, pToUpdate);

            if(!await pRepository.SaveAll())
            {
                return BadRequest(Message.SaveFailed);
            }

            return Ok(pToUpdate);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var pToDelete = await pRepository.GetProductByIdAsync(id);

            if(pToDelete == null)
            {
               return NotFound(Message.ProductNotFound);
            }

            pRepository.Delete(pToDelete);

            if(!await pRepository.SaveAll())
            {
                return BadRequest(Message.SaveFailed);
            }

            return Ok(Message.ProductDeleted);
        }

   

    }
}
