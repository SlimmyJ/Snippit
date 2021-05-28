namespace Snippit.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    using Snippit.Models.ViewModels;
    using Snippit.Service;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ISnippitService _service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                });
        }

        public async Task<ActionResult> About()
        {
            return View();
        }
    }
}