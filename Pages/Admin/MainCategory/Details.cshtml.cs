﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcommerceReal.Data;

namespace EcommerceReal.Pages.Admin.MainCategory
{
    public class DetailsModel : PageModel
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;

        public DetailsModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Data.MainCategory MainCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MainCategory = await _context.mainCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (MainCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
