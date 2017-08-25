using Microsoft.AspNetCore.Mvc;

namespace PortfolioDotnet.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
