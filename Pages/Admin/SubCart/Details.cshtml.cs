using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcommerceReal.Data;

namespace EcommerceReal.Pages.Admin.SubCart
{
    public class DetailsModel : PageModel
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;

        public DetailsModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SubCategory SubCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubCategory = await _context.SubCategories
                .Include(s => s.MainCategory).FirstOrDefaultAsync(m => m.Id == id);

            if (SubCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
