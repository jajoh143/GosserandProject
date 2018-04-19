using Dapper;
using GosserandProject.Data.DTO.Admin;
using Microsoft.Extensions.Configuration;
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
        
        public static IEnumerable<PageDTO> GetPagesData(string connString)
        {
            using (IDbConnection db = new SqlConnection(connString))
            {
                var query = @"
                          select 
						p.Id,
                        PageTitle,
                        PageDescription,
                        PageLink,
                        PagePublished,
                        IsIndex,
                        u.Username as AuthorUsername,
						p.ModifiedDate
                        from pages p
                        inner join AspNetUsers u on p.AuthorId = u.ID";
                try
                {
                    return db.Query<PageDTO>(query);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }
    }
}
