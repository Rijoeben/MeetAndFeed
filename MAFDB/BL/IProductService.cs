using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;

namespace BL
{
    public interface IProductService
    {
        IEnumerable<Product> ListOfProducts();

        public Product AddProduct(string productID, string productName);
        public void DeleteProduct(string productID, string productName);
        public void ReadProducts(string productID, string productName);
        IEnumerable<Product> ReadProducts();
    }
}
