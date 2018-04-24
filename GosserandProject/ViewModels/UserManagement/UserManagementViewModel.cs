using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GosserandProject.Model.UserManagementViewModels
{
	public class UserManagementViewModel
	{
		public string FirstName { get; set;}
		public string LastName	{ get; set;}
		public string Username { get; set; }
		public string PhoneNumber { get; set; }
		public string Postion { get; set; }
		public string Email { get; set; }

	}
}
