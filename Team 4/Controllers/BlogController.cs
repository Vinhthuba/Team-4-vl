using Microsoft.AspNetCore.Mvc;

namespace Team_4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
