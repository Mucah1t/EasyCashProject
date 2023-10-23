using Microsoft.AspNetCore.Mvc;

namespace EasyCashProject.PresentationLayer.Controllers
{
    public class AccountListForCopyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
