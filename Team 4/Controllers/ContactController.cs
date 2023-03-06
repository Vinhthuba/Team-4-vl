using Microsoft.AspNetCore.Mvc;

namespace Team_4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
