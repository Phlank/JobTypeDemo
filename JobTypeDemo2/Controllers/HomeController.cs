using JobTypeDemo2.Interfaces;
using JobTypeDemo2.Models;
using JobTypeDemo2.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobFactory _jobFactory;

        public HomeController(ILogger<HomeController> logger, IJobFactory jobFactory)
        {
            _logger = logger;
            _jobFactory = jobFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Submit(SubmitViewModel model)
        {
            var job = _jobFactory.GetJob(model.Url, model.JobType);
            job.Run();
            return View();
        }
    }
}
