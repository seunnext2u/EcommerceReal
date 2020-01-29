using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string BannerImage { get; set; }
        public int MainCategoryId { get; set; }
     
        public MainCategory MainCategory { get; set; }
        public List<Product> Products { get; set; }
      
    }
}

