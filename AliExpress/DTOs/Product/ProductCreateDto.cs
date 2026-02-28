using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.DTOs.Product
{
    public class ProductCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountedPercentage { get; set; }
        public string ImageUrl { get; set; }
        public double DisCountedPrice { get; internal set; }
    }
}
