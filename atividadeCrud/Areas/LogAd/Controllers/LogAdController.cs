using Microsoft.AspNetCore.Mvc;
namespace Produtos_Com_Admin.Areas.Admin.Controllers
{
    public class LogAdController : Controller
    {
        [Area("LogAd")]
        public IActionResult Index()
        {
            return View();
        }
    }
}