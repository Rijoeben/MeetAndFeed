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

        public Product AddProduct(int productID, string productName);
        public void CreateProduct(int productID, string productName);
        public void DeleteProduct(int productID, string productName);
        public void ReadProducts(int productID, string productName);


    }
}
