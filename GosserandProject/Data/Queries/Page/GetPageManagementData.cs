using Dapper;
using GosserandProject.Data.DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GossserandProject.Data.Queries.Page
{
    public class GetPageManagementData
    {
        public static async Task<IEnumerable<PageDTO>> GetPagesData(string connectionString)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var query = @"
                        select 
                        PageTitle,
                        PageDescription,
                        PageLink,
                        PagePublished,
                        IsIndex
                        u.Username as AuthorUsername
                        from pages p
                        inner join AspNetUsers u on p.AuthorId = u.ID
                ";
                try
                {
                    return await db.QueryAsync<PageDTO>(query);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }
    }
}
