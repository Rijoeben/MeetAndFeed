﻿using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BL
{
    public class ProductService : IProductService
    {
        private IProductsRepository _repo;

        public IEnumerable<Product> ListOfProducts()
        {
            return _repo.ReadProducts();
        }
        public Product AddProduct(string productName)
        {
            Product newProduct = new Product();

            newProduct.ProductName = productName;

            _repo.CreateProduct(newProduct);

            return newProduct;
        }

        public void DeleteProduct(string productID)
        {
            _repo.DeleteProduct(productID);
        }
    }
}