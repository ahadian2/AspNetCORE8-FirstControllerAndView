using Microsoft.AspNetCore.Mvc;

namespace FirstControllerAndView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
