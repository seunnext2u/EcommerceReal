using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceReal.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EcommerceReal
{
    public class CreateModel : PageModel
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;
        public IFormFile BannerImage { get; set; }
        public string mesaage { get; set; }
        public string error { get; set; }
        public CreateModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
           ViewData["MainCategoryList"] = new SelectList(_context.mainCategories, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public SubCategory SubCategory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(BannerImage != null && BannerImage.Length >0)
            {
                var filename = DateTime.Now.Ticks.ToString()+BannerImage.FileName;
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\productimages", filename);
               await BannerImage.CopyToAsync(new FileStream(filepath,FileMode.Create ));
                SubCategory.BannerImage = filename;
                _context.SubCategories.Add(SubCategory);
                await _context.SaveChangesAsync();
                mesaage = " Image uploaded successfully ";
            }
            else
            {
                error = $" please upload an image";
            }
        

            return RedirectToPage("./Index");
        }
    }
}