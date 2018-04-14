using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using GosserandProject.Data.DTO.FrontEnd;

namespace GosserandProject.Data.Queries.FrontEnd
{
    public class GetFrontEndData
    {
        public static PageDisplayDTO GetIndexPage(string connectionString)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var query = @"
                   select
                    PageTitle,
                    PageDescription,
                    PageLink,
                    PageBodyHtml,
                    PageHeadStyle
                    from 
	                    pages p
                    inner join page_display pd on p.ID = pd.PageId
                    where IsIndex = 1;";
                try
                {
                    return db.QuerySingleOrDefault<PageDisplayDTO>(query);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }
    }
}
