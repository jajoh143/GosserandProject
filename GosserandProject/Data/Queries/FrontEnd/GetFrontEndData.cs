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

        public static IEnumerable<PageLinkDTO> GetPageLinks(string connectionString)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var query = @"
                  select
                        Id PageId,
	                    PageTitle,
	                    PageLink,
	                    PageParentId
                    from
	                    pages
                    where PagePublished = 1;";
                try
                {
                    return db.Query<PageLinkDTO>(query);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }

        public static PageDisplayDTO GetStaticPage(string connString, string routeName)
        {
            using (IDbConnection db = new SqlConnection(connString))
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
                    where PageLink = @PageId;";

                try
                {
                    return db.QuerySingleOrDefault<PageDisplayDTO>(query, 
                        new { PageLink = routeName });
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
