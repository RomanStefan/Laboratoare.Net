using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void Give_tralala_when_tralala_then()
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
