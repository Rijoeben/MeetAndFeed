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
        public Product CreateProduct(string productName);
        public void DeleteProduct(long productId);
    }
}
