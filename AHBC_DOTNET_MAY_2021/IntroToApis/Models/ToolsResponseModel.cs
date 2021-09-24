using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToApis.Models
{
    public class ToolsResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quanity { get; set; }

        public double Price { get; set; }
    }
}
