using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceReal.Data;
using Microsoft.AspNetCore.Http;
using EcommerceReal.Utilityfolder;

namespace EcommerceReal.Pages.Admin.ProductTB
{
    public class CreateModel : PageModel
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;
        [BindProperty]
        public List<IFormFile> ProductImages { get; set; }
        public CreateModel(EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SubCategoryList"] = new SelectList(_context.SubCategories, "Id", "name");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            var proid = Product.Id;
            var images = new List<Image>();
            foreach( var img in ProductImages)
            {
                if (img != null && img.Length > 0)
                {
                    var filePath = await FileUpload.UploadFile(img, "productimages");
                    images.Add(new Image { Link = filePath, ProductId = proid });
                }
            }
            _context.Images.AddRange(images);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}