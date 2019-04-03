using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Products.Test
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            var product = Product.Create("Watch", "Apple watch", DateTime.Now.AddDays(-5), DateTime.Now, 100, 20);
            // Act
            var result = product.ComputeVAT();
            //Assert
            Assert.IsTrue(result == 20);
        }
    }
}
