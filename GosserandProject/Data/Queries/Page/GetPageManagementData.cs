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
						p.Id PageId,
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

        public static PageDetailDTO GetPageDetail(string connString, int id)
        {
            using (IDbConnection db = new SqlConnection(connString))
            {
                var query = @"
                        select 
                            p.Id PageId,
                            p.PageTitle,
                            p.PageDescription,
                            p.PageLink,
                            p.PagePublished,
                            pd.PageBodyHtml,
                            pd.PageHeadStyle,
                            anu.UserName AuthorUsername,
                            anu.FirstName AuthorFirstName,
                            anu.LastName AuthorLastName
                        from pages p
                        left outer join AspNetUsers anu on p.AuthorID = anu.ID
                        left outer join page_display pd on p.id = pd.PageId
                        where p.Id = @PageId";

                 try
                {
                    return db.QueryFirstOrDefault<PageDetailDTO>(query, new
                    {
                        PageId = id
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
