using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BL
{
    public class ProductService : IProductService
    {
        private IProductService _repo;

        public Product AddProduct(string productID, string productName)
        {
            Product newProduct = new Product();

            newProduct.ProductId = productID;
            newProduct.ProductName = productName;

            _repo.CreateProduct(newProduct)
        }
        public void DeleteProduct(int productID, string productName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ListOfProducts()
        {
            return _repo.ReadProducts();
        }

        public void ReadProducts(int productID, string productName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadProducts()
        {
            return _repo.ReadProducts();
        }

        public 
    }
}
