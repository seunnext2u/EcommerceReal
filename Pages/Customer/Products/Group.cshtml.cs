using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Website.Data;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Website.Pages.Customer.Products
{
    public class GroupModel : PageModel
    {
        private readonly Ecommerce_Website.Data.ApplicationDbContext _context;

        public SubCategory SubCategory { get; set; }

        public GroupModel(Ecommerce_Website.Data.ApplicationDbContext context)
        { 
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? subgroupId)
        {
            if (subgroupId != null)
            {
                //get the sub category that has the id
                SubCategory = await _context
                    .SubCategories
                    .Include(m => m.products)
                    .ThenInclude(l => l.Images)
                    .FirstOrDefaultAsync(n => n.Id == subgroupId.Value);
                return Page();
            }
            else
            {

                return NotFound();
            }
           
        }
    }
}