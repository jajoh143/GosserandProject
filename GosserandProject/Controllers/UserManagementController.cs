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

		}
	}
 