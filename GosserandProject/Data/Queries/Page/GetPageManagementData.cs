using Dapper;
using GosserandProject.Data.DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GossserandProject.Data.Queries.Page
{
    public class GetPageManagementData
    {
        public static async Task<IEnumerable<PageDTO>> GetPages(string connectionString)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var query = @"
                    
                ";
                try
                {
                    return await db.QueryAsync<PageDTO>(query);
                }
                catch(Exception e)
                {
                    throw e;
                }
                
            }
        }
    }
}
