using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class ProductColor
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColourId { get; set; }
        public Product Product{ get; set; }
        public Colour Colour { get; set; }
    }
}
