using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
  
    public class HomeController : Controller
    {

        [Route("Dashboard/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
