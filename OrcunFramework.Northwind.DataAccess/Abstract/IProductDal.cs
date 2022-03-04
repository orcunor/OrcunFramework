using OrcunFramework.Core.DataAccess;
using OrcunFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcunFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // bu classa özgün metodlarım olabilir onları burada yazabilirim ama standart olarak base metodlarıma IEntityRepository üzerinden ulaşacağım.


        
    }
}
