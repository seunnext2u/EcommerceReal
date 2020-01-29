using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EcommerceReal.Data
{
    public class Customer: IdentityUser
    {
        public List<Address> Addresses { get; set; }
    }
}
