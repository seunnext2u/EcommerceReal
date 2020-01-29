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
    public class IndexModel : PageModel
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;

        public IndexModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SubCategory> SubCategory { get;set; }

        public async Task OnGetAsync()
        {
            SubCategory = await _context.SubCategories
                .Include(s => s.MainCategory).ToListAsync();
        }
    }
}
