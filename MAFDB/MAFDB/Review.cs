﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class Review
    {
        [Key]
        public long ReviewId { get; set; }

        public long UserId { get; set; }
        public string Content { get; set; }
        public float Score { get; set; }
    }
}
