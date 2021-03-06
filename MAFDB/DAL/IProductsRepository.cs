﻿using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IProductsRepository
    {
        IEnumerable<Product> ReadProducts();

        Product CreateProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
