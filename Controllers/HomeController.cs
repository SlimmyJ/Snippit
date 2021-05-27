namespace Snippit.Controllers
{
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    using Snippit.Data;
    using Snippit.Models;
    using Snippit.Models.SnippitViewModels;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SnippitContext _context;

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
            List<Moderator> moderators = new List<Moderator>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    string
                            query =
                                    "SELECT * FROM"; // TODO: Write select query for moderators/index page ref HomeController.cs CU-FINAL
                    command.CommandText = query;
                    DbDataReader reader = await command.ExecuteReaderAsync();

                    //if (reader.HasRows)
                    //{
                    //    while (await reader.ReadAsync())
                    //    {
                    //        var row = new EnrollmentDateGroup
                    //                  {
                    //                      EnrollmentDate = reader.GetDateTime(0),
                    //                      StudentCount = reader.GetInt32(1)
                    //                  };
                    //        groups.Add(row);
                    //    }
                    //}

                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }

            return View();
        }
    }
}