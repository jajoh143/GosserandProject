using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Web.Models.Page;
using Microsoft.AspNetCore.Mvc;

namespace GosserandProject.Web.Controllers
{
    [Route("admin/page")]
    public class PageManagementController : Controller
    {
        public IActionResult Index()
        {
            var model = new PageManagementViewModel();
            return View(model);
        }
    }
}