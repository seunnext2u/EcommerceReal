using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReal.Data
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        public int ProductId { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey("Colour")]
        public int SelectedColourId { get; set; }
        public Enumerations.CartState CartState { get; set; } 
        [ForeignKey ("Address")]
        public int SelectedAddressId { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Colour Colour { get; set; }
        public Address Address { get; set; }
    }
     
}
