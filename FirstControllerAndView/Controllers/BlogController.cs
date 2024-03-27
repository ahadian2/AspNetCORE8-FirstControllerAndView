using Microsoft.AspNetCore.Mvc;

namespace FirstControllerAndView.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Post() { 
        
        return View("Category");
        }

        public IActionResult Category()
        {
            return View("Post");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
