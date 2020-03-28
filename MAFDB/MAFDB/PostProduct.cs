using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class PostProduct
    {
        [Key]
        public int PostId { get; set; }

        public Post Post { get; set; }
        public int ProductId { get; set; }
        public Product ProductName { get; set; }
    }
}
