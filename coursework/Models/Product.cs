using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appDevCoursework.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string address { get; set; }

    }
}
