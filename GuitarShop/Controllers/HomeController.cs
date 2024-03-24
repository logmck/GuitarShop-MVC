using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }



        [Route("[action]")]
        //New action method for Contact us that
        public IActionResult ContactUs()
        {
            //creates a new dictionary and add the data below to then be displayed on the page
            Dictionary<string,string> contact = new Dictionary<string, string>
            {
                //dictionary data
                {"Phone", "111-222-3333"},
                {"Email", "info@info.com" }
            };
            //sends the new dictionary through to then be displayed
            return View(contact);
        }
    }
}
