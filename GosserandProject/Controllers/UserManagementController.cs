using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Model.UserManagementViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GosserandProject.Controllers
{
	[Route("[controller]/[action]")]
	public class UserManagementController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
			var model = new UserManagementViewModel;
            return View(model);
        }
    }
}
