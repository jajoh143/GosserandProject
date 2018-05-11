using Dapper;
using GosserandProject.Data.DTO.UserInfo;
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
	public class UserManagementData
	{

		public static IEnumerable<UserInfoDTO> UserData(string connString)
		{
			using (IDbConnection db = new SqlConnection(connString))
			{
				var query = @"
                          select 
						UserId,
                        LastName,
                        PhoneNumber,
                        Email,
                        Position,
                        IsIndex";
                                                
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
		
	public static UserInfoDTO UserInfoDetail(string connString, int id)

		{
			using (IDbConnection db = new SqlConnection(connString))
			{
				var query = @"select
							UserId,
							LastName,
							PhoneNumber,
							Email,
							Postion,
							IsIndex
							from UserInfo";
				try
				{
					return db.QueryFirstOrDefault<UserInfoDetailDTO>(query, new
					{
						UserId = id
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
