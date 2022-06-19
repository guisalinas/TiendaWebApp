using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Models.Data.Interfaces
{
    public interface IProductRepository : IApiRepository
    {

        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> GetProductByNameAsync(string name);

    }
}
