using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class ProductDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public CategoryDTO category { get; set; }

    }
}
