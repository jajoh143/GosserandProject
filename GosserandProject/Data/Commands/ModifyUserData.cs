using Dapper;
using GosserandProject.Data.DTO.UserInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.Commands
{
	public class ModifyUserData
	{
		public static int UpdateUser(string connString, UserInfoDetailDTO user)
		{
			using (IDbConnection db = new SqlConnection(connString))
			{
				var update_users_query = @"
                                      update users
                                      set	LastName = @LastName,
											FirstName = @FirstName,
											Email = @Email,
											PhoneNumber= @PhoneNumber
											Position= @Position
									  where
											id = @UserId; ";


				try
				{
					return db.Execute(update_users_query, new
					{
						LastName = user.LastName,
						FirstName = user.FirstName,
						Email = user.Email,
						PhoneNumber = user.PhoneNumber,
						Position = user.Position
						
					});
				}
				catch (Exception e)
				{
				throw e;
				}
			}
		}
	} 
}


