using Microsoft.AspNetCore.Mvc;

namespace vcart.UI.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
