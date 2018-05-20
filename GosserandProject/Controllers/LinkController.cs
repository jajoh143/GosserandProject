using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Models.ViewModels.FrontEnd;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GosserandProject.Controllers
{
    public class LinkController : Controller
    {
        private readonly IConfiguration _configuration;

        public LinkController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Link/{routeName:string}")]
        public IActionResult RouteStaticPage(string routeName)
        {
            var model = new StaticPageViewModel(this._configuration.GetConnectionString("DefaultConnection"),routeName);
            return View(model);
        }
    }
}