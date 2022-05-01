using Microsoft.AspNetCore.Mvc;

namespace TagHelper_Demo_HyperlinksImplements.Controllers
{   
    [Route("[controller]")]
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

        [Route("[action]/{id}")]
        public int Details(int id)
        {
            return id;
        }
    }
}
