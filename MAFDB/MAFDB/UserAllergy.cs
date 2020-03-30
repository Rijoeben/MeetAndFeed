﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class UserAllergy
    {
        [Key]
        public int UserId { get; set; }
        public int AllergyId { get; set; }

        public Allergy Allergy { get; set; }
        public User User { get; set; }
    }
}
