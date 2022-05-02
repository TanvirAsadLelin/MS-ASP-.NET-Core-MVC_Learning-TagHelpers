using Microsoft.AspNetCore.Mvc;

namespace BenefitTagHelper_Demo.Controllers
{   [Route("Lelin/[controller]")]
    public class HomeController : Controller
    {    
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}
