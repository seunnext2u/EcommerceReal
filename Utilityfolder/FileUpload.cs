using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace EcommerceReal.Utilityfolder
{
    public static class FileUpload
    {
       public static async Task<string> UploadFile(IFormFile Formfile, string foldername)
        {
            var filename = DateTime.Now.Ticks.ToString() + Formfile.FileName;
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), $@"wwwroot\{foldername}", filename);
            await Formfile.CopyToAsync(new FileStream(filepath, FileMode.Create));
            return $"{foldername}\\{filename}";
        }
    }
}
