using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EcommerceReal.Data;

namespace EcommerceReal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<MainCategory> mainCategories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EcommerceReal.Data.Product> Product { get; set; }
    }
}
