using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Produces("application/json")]
    [Route("/api/Gallery")]
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            List<string> images = new List<string>();
            
            var results = Directory.GetFiles("wwwroot/gallery/");
            foreach (var image in results)
            {
                images.Add(image.Replace("wwwroot", ""));
            }

            return Json(images);
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage()
        {
            IFormFile imageFile = Request.Form.Files[0];
            if (imageFile.Length > 0)
            {
                using (var fileStream = new FileStream(Path.Combine("wwwroot/gallery", imageFile.FileName), FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                }
            }
            return Redirect("/Gallery");
        }

    }
}
