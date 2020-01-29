using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public int  SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public IList<Colour> Colours { get; set; }
        public IList<Image> image { get; set; }
    }
}
