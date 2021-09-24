using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIExample.Models
{
    public class Tool
    {
        //Attribute
        //[Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quanity { get; set; }

        public double Price { get; set; }
    }
}
