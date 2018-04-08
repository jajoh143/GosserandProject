using Dapper;
using GossserandProject.Data.ViewModels;
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
