using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Languagy_project.Models;
using Languagy_project.Resources;
using System.Diagnostics;

namespace Languagy_project.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<ShairedResource> _localizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<ShairedResource> SharedLocalizer)
        {
            _logger = logger;
            _localizer = SharedLocalizer;
        }
       
        public IActionResult Index()
        {
            return View();
        }
          //public IActionResult Sadoka()
          //   {
          //  return View();
          //       }
    public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}