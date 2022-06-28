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
            modelBuilder.Entity<ProductInPurchaseDetail>().HasKey(pp => new { pp.ProductId, pp.PurchaseDetailId }); // prevent repetitions

            modelBuilder.Entity<ProductInPurchaseDetail>()
                .HasOne(p => p.Product)
                .WithMany(p => p.PInPurchaseDetailList)
                .HasForeignKey(p => p.ProductId);
           
            modelBuilder.Entity<ProductInPurchaseDetail>()
              .HasOne(pd => pd.PurchaseDetail)
              .WithMany(pd => pd.PInPurchaseDetailList)
              .HasForeignKey(pd => pd.PurchaseDetailId);


            modelBuilder.Entity<ProductInSaleDetail>().HasKey(ps => new { ps.ProductId, ps.SaleDetailId });
            
            modelBuilder.Entity<ProductInSaleDetail>()
                .HasOne(s => s.Product)
                .WithMany(s => s.PInSaleDetailList)
                .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<ProductInSaleDetail>()
                .HasOne(sd => sd.SaleDetail)
                .WithMany(sd => sd.PInSaleDetailList)
                .HasForeignKey(sd => sd.SaleDetailId);

        }

    }
}
