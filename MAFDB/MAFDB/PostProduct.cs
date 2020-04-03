using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class PostProduct
    {
        public string PostId { get; set; }
        public Post Post { get; set; }
        public string ProductId { get; set; }
        public Product ProductName { get; set; }
    }
}
