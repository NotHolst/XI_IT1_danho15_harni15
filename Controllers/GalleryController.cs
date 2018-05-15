using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Route("galleryimages")]
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

    }
}
