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
        public DbSet<Address> Addresses { get; set;}
        public DbSet<Contact> Contacts { get; set;}
        public DbSet<Customer> Customers { get; set;}
        public DbSet<CustomerType> CustomerTypes { get; set;} 
        public DbSet<ProductType> ProductTypes { get; set;}
        public DbSet<PayMode> PayModes { get; set;}
        public DbSet<ProductInPurchaseDetail> ProductInPurchaseDetails { get; set;}
        public DbSet<ProductInSaleDetail> ProductInSaleDetails { get; set;}
        public DbSet<Provider> Providers { get; set;}
        public DbSet<Purchase> Purchases { get; set;}
        public DbSet<PurchaseDetail> PurchaseDetails { get; set;}
        public DbSet<Sale> Sales { get; set;}
        public DbSet<SaleDetail> SaleDetails { get; set;}

        // Api Fluent
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // many to many
            modelBuilder.Entity<ProductInPurchaseDetail>().HasKey(pp => new { pp.ProductId, pp.PurchaseDetailId }); // prevent repetitions

            modelBuilder.Entity<ProductInPurchaseDetail>()
                .HasOne(p => p.Product)
                .WithMany(p => p.PInPurchaseDetailList)
                .HasForeignKey(p => p.ProductId);
           
            modelBuilder.Entity<ProductInPurchaseDetail>()
              .HasOne(p => p.PurchaseDetail)
              .WithMany(p => p.PInPurchaseDetailList)
              .HasForeignKey(p => p.PurchaseDetailId);

            modelBuilder.Entity<ProductInSaleDetail>().HasKey(ps => new { ps.ProductId, ps.SaleDetailId });
            
            modelBuilder.Entity<ProductInSaleDetail>()
                .HasOne(p => p.Product)
                .WithMany(p => p.PInSaleDetailList)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<ProductInSaleDetail>()
                .HasOne(p => p.SaleDetail)
                .WithMany(p => p.PInSaleDetailList)
                .HasForeignKey(p => p.SaleDetailId);


            // one to one

            modelBuilder.Entity<Person>()
               .HasOne(b => b.Customer)
               .WithOne(i => i.Person)
               .HasForeignKey<Customer>(b => b.PersonId);

            modelBuilder.Entity<Person>()
               .HasOne(b => b.Provider)
               .WithOne(i => i.Person)
               .HasForeignKey<Provider>(b => b.PersonId);
            
        }

    }
}
