using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class ContactController : Controller
    {
        
        public IActionResult Index()
        {
            var model = new ContactFormViewModel();
            return View(model); 
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult ContactForm(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
               
                return View("Index", model);
            }

            
            ViewData["Message"] = "შენი მესიჯი წარმატებით გაიგზავნა!";

            
            return RedirectToAction("Index");
        }
    }
}
