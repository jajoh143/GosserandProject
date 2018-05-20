using Dapper;
using GosserandProject.Data.DTO.UserInfo;
using GossserandProject.Data.Models.User;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GossserandProject.Data.Queries.Userinfo
{
	public class GetUserManagementData
	{

		public static IEnumerable<UserInfoDTO> UserData(string connString)
		{
			using (IDbConnection db = new SqlConnection(connString))
			{
				var query = @"
                          select 
						id UserId,
                        LastName,
						FirstName,
                        PhoneNumber,
                        Email,
                        Position
                        from aspnetusers;";

				try
				{
					return db.Query<UserInfoDTO>(query);
				}
				catch (Exception e)
				{
					throw e;
				}
			}
		}

		public static UserInfoDetailDTO UserInfoDetail(string connString, Guid userGuid)

		{
			using (IDbConnection db = new SqlConnection(connString))
			{
				var query = @"select
							id UserId,
							LastName,
							PhoneNumber,
							Email,
							Position,
							from AspNetUsers
							where
							id = @UserId; "; 
				

				try
				{
					return db.QueryFirstOrDefault<UserInfoDetailDTO>(query, new
					{
						UserId = userGuid
					
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
