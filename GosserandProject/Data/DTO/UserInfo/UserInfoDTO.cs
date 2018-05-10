using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.DTO.UserInfo
{
	public class UserInfoDTO
	{

		public Guid UserId { get; set; }
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Display(Name = "E-mail")]
		public string Email { get; set; }
		[Display(Name = " Phone Number ")]
		public int PhoneNumber { get; set; }
		[Display(Name = "Position")]
		public string Position { get; set; }
		

	}	
	
}
