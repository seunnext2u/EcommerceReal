using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using EcommerceReal.Data;

namespace EcommerceReal.Pages.Customer.Products
{
    public class GroupsModel : PageModel

    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;
        public GroupsModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SubCategory SubCategory { get; set; }
        public async Task<IActionResult> OnGetAsync(int ? subgrpid)
        {
            // GET THE SUB CATEGORY THAT HA STHE ID INTO THE PROPERTY
            SubCategory = await _context.SubCategories.Include(m => m.Products).ThenInclude(x => x.image).FirstOrDefaultAsync(m => m.Id == subgrpid.Value);

      

            return Page();
            
        }
    }
}