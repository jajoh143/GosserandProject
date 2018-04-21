using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.ViewModels.FrontEnd;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GosserandProject.Controllers
{
    public class FrontEndController : Controller
    {
        private readonly IConfiguration _configuration;

        public FrontEndController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new IndexPageViewModel(_configuration.GetConnectionString("DefaultConnection"));
            return View(model);
        }
    }
}
