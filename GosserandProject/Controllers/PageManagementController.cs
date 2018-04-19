using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Web.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GosserandProject.Web.Controllers
{
   
    public class PageManagementController : Controller
    {
        private readonly IConfiguration _configuration;

        public PageManagementController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = new PageManagementViewModel(_configuration.GetConnectionString("DefaultConnection"));
            return View(model);
        }
    }
}