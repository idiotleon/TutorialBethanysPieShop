using Microsoft.AspNetCore.Mvc;

namespace TutorialBethanysPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
