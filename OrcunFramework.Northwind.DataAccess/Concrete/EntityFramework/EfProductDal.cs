using OrcunFramework.Core.DataAccess.EntityFramework;
using OrcunFramework.Northwind.DataAccess.Abstract;
using OrcunFramework.Northwind.Entities.Concrete;

namespace OrcunFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext> , IProductDal
    {
       
    }
}
