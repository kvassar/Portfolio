using Microsoft.AspNetCore.Mvc;

namespace KalPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();  
        }
    }
}
