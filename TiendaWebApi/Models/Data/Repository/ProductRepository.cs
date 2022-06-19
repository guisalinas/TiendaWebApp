using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaWebApi.Models.Data.Interfaces;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Models.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext pContext;

        public ProductRepository(DataContext r)
        {
            pContext = r;
        }


        public void Add<T>(T entity)
        {
            pContext.Add(entity);
        }

        public void Delete<T>(T entity)
        {
            pContext.Remove(entity);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await pContext.Products.FirstOrDefaultAsync(u => u.Id == id);
            return product;
        }

        public async Task<Product> GetProductByNameAsync(string name)
        {
            var products = await pContext.Products.FirstOrDefaultAsync(n => n.Name == name);
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await pContext.Products.ToListAsync();
            return products;
        }

        public async Task<bool> SaveAll()
        {
            return await pContext.SaveChangesAsync() > 0;
        }
    }
}
