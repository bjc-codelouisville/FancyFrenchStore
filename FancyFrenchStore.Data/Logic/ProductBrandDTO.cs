using Microsoft.EntityFrameworkCore;


namespace FancyFrenchStore
{

    public class ProductBrandDTO
    {
        public Guid Id { get; set; }
        public string? SKU { get; set; }
        public string? UPC { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }

    public class ProductBrandDTOContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=FancyFrenchStoreData");
        }

        public List<ProductBrandDTO> GetProductsWithBrands()
        {
            var sqlQuery = @"
                SELECT
                    Products.Id,
                    Products.SKU,
                    Products.UPC,
                    Brands.Name AS Brand,
                    Products.Name,
                    Products.Price
                FROM
                    Products INNER JOIN
                    Brands ON Products.BrandID = Brands.Id";
            return Set<ProductBrandDTO>().FromSqlRaw(sqlQuery).ToList();
        }
    }
}