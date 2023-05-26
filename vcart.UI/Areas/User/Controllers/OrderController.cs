using Microsoft.AspNetCore.Mvc;

namespace vcart.UI.Areas.User.Controllers
{
    public class OrderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
