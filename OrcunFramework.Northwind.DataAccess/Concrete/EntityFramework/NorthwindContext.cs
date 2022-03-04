
using OrcunFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using OrcunFramework.Northwind.Entities.Concrete;
using System.Data.Entity;

namespace OrcunFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        // diğer nesneleri oluşturabilirsiniz..


        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        protected  override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            // diğerlerini de eklemek gerekir...
        }         

    }
}
