using Microsoft.AspNetCore.Mvc;

namespace MessengerApp.Controllers
{
    public class MySqlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
