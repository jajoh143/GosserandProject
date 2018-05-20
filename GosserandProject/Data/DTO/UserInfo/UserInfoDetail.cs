using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.DTO.UserInfo

{
	public class UserInfoDetailDTO : UserInfoDTO
	{
		public new string UserId { get; set; }
		[Display(Name = "Last Name")]
		public new string LastName { get; set; }
		[Display(Name = "First Name")]
		public new string FirstName { get; set; }
		[Display(Name = "E-mail")]
		public new string Email { get; set; }
		[Display(Name = " Phone Number ")]
		public new string PhoneNumber { get; set; }
		[Display(Name = "Position")]
		public new string Position { get; set; }
	}
}
