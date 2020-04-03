using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ProductService : IProductService
    {
        private IProductService _repo;

        public Product AddProduct(int productID, string productName)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(int productID, string productName)
        {
            throw new NotImplementedException();
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

        public 
    }
}
