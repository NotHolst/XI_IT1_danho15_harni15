using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Route("aboutcontent")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            string daniel = ReadFileString("storage/danielContent");
            string harald = ReadFileString("storage/haraldContent");

            string[] result = new string[]{daniel, harald};

            return Json(result);
        }

        public static string ReadFileString(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
