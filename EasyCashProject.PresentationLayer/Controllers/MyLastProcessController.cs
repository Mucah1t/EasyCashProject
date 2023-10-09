using Microsoft.AspNetCore.Mvc;

namespace EasyCashProject.PresentationLayer.Controllers
{
    public class MyLastProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
