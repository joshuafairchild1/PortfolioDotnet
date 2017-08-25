using Microsoft.AspNetCore.Mvc;
using PortfolioDotnet.Models;
using System.Collections.Generic;

namespace PortfolioDotnet.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            List<Project> repos = Project.GetTopStarredRepos();

            return View(repos);
        }
    }
}
