using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;

namespace DAL
{
    public class ProductRepository : IProductsRepository
    {
        private readonly MeetAndFeedDbContext ctx;

        public IEnumerable<Product> ReadProducts()
        {
            return ctx.Products.AsEnumerable();
        }
        public Product CreateProduct(Product product)
        {
            ctx.Add(product);
            ctx.SaveChanges();
            return product;
        }

        public void DeleteProduct(Product product)
        {
            ctx.Products.Remove(product);
            ctx.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            ctx.Products.Update(product);
            ctx.SaveChanges();
        }
        public Product GetProduct(string productid)
        {
            return ctx.Products.Find(productid);
        }
    }
}
