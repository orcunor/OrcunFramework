using NUnit.Framework;
using OrcunFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace OrcunFramework.Northwind.DataAccess.Tests
{
    public class EntityFrameworkTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetAll();

            Assert.AreEqual(77, result.Count);   

            Assert.Pass();
        }
    }
}