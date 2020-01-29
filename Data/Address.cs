using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class Address
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public String State { get; set; }
        public String ActualAddress { get; set; }

        public String CustormerId { get; set; }
    }
}
