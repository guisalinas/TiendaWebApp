using Microsoft.EntityFrameworkCore;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Person> Persons { get; set;}

    }
}
