using GosserandProject.Data.DTO.UserInfo;
using GossserandProject.Data.Queries.Userinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Models.ViewModels.UserManagement
{
    public class UserManagementViewModel
    {
		public IEnumerable<UserInfoDTO> Users { get; set; }

			public UserManagementViewModel(string connectionString)
			{
				Users = UserManagementData.UserData(connectionString);
			}

	}
}

