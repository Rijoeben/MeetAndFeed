using System;
using System.Collections.Generic;
using System.Text;

namespace MAFDB
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }

        //public virtual ICollection<Post> Posts { get; set; }
    }
}
