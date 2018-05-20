using GosserandProject.Data.DTO.UserInfo;
using GossserandProject.Data.Queries.Userinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Models.ViewModels.UserManagement
{
	public class UserManagementDetailViewModel
	{
		public UserInfoDetailDTO User { get; set; }

		public UserManagementDetailViewModel(string connString, Guid userGuid)
		{
			User = GetUserManagementData.UserInfoDetail(connString, userGuid);
		}
	}
}

