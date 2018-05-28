using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Data.Commands;
using GosserandProject.Data.DTO.UserInfo;
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
		public IActionResult Edit(Guid userGuid)
		{
			var model = new UserManagementDetailViewModel(_configuration.GetConnectionString("DefaultConnection"), userGuid);
			return View(model);
		}

		[HttpPost]
		public IActionResult Detail([FromForm]UserManagementDetailViewModel model)
		{
			if (ModelState.IsValid)
			{
				ModifyUserData.UpdatePage(_configuration.GetConnectionString("DefaultConnection"), model.User);
				return View(model);
			}
			else
			{
				return View(model);
			}
		}
	}


}
