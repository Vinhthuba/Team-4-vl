using Microsoft.AspNetCore.Mvc;

namespace Team_4.Controllers
{
    public class ShoppingcartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
