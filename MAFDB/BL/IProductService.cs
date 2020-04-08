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
        public Product AddProduct(string productName);
        public void DeleteProduct(long productID);
    }
}
