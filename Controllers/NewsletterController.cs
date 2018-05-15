using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Route("news")]
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(){
            string email = Request.Form["email"];

            using (TextWriter writer = new StreamWriter("storage/newslettersubscribers", true))
            {
                writer.WriteLine(email);
                writer.Close();
            }
            return Ok();
        }

    }
}
