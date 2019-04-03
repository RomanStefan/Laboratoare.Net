using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();

        ProductRepository()
        {
            _products.Add(Product.Create("Watch", "Apple watch", DateTime.Now.AddDays(-5), DateTime.Now, 100, 20));
            _products.Add(Product.Create("Bmw", "Car bmw", DateTime.Now.AddDays(-5), DateTime.Now, 2500, 19));
            _products.Add(Product.Create("bracelet", "men accesory", DateTime.Now.AddDays(-5), DateTime.Now, 15, 5));
            _products.Add(Product.Create("Nimic", "Nu s-a gasit nimic", DateTime.Now, DateTime.Now, 0, 0));
        }

        //public Product GetProductbyName(string productName)
        //{
        //    foreach (var product in _products)
        //    {
        //        if (string.Compare(product.Name, productName) != 0)
        //            return product;
        //    }
        //    return _products[3]; ???? return _products[3]???
        //}

        public Product GetProductbyName(string productName)
        {
            return _products.Find(prod => prod.Name == productName);
        }
        public IEnumerable<Product> FindAllProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product GetProductByPosition(int position)
        {
            return _products.ElementAt(position);
        }

        public void RemoveProductByName(string productName)
        {
            //_products.Remove(GetProductbyName(productName));
            var productToRemove = GetProductbyName(productName);
            _products.Remove(productToRemove);
        }

    }
}
