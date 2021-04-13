﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appDevCoursework.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }

    }
}
