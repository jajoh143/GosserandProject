using GosserandProject.Models.ViewModels.UserManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GosserandProject.Web.Controllers
{
	[Route("[controller]/[action]")]
	public class UserManagementController : Controller
	{
		private readonly IConfiguration _configuration;

		public UserManagementController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public IActionResult Index()
		{
			var model = new UserManagementViewModel(_configuration.GetConnectionString("DefaultConnection"));
			return View(model);
		}
		//public IActionResult Detail(int Id)
		//{
		//	var model = new UserManagementViewModel(_configuration.GetConnectionString("DefaultConnection"), Id);
		//	return View(model);
		//}

		//public IActionResult Create();
		//{
		//	var model = new UserManagementViewModel();
		//	return View(model);
		//}


}
}