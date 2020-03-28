using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class UserPost
    {
        [Key]
        public int UserId { get; set; }

        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
