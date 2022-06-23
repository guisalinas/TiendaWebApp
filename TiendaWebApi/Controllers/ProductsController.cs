using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TiendaWebApi.Models.Data.Interfaces;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository pRepository;

        public ProductsController(IProductRepository _pRepository)
        {
                pRepository = _pRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await pRepository.GetProductsAsync();
            return Ok(products);
        }

        [HttpPost]

        public async Task<IActionResult> Post(Product product)
        {
            //product.DischargeDate = System.DateTime.Now;
            
            pRepository.Add(product);
            if (await pRepository.SaveAll()) //validation
            {
                return Ok(product);
            }
            
            return BadRequest();
        }



    }
}
