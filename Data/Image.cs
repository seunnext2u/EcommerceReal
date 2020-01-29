using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Link { get; set; }
    }
}
