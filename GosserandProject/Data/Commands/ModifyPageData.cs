using Dapper;
using GosserandProject.Data.DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.Commands
{
    public class ModifyPageData
    {
        public static int UpdatePage(string connString, PageDetailDTO page)
        {
            using (IDbConnection db = new SqlConnection(connString))
            {
                var update_pages_query = @"
                                        update pages
                                        set PageTitle = @PageTitle,
	                                        PageDescription = @PageDescription,
	                                        PageLink = @PageLink,
	                                        PagePublished = @PagePublished,
                                        where
	                                        PageId = @PageId;";

                var update_page_display_query = @"          
                                        update page_display 
                                        set PageBodyHtml = @PageBodyHtml,
	                                        PageHeadStyle = @PageHeadStyle
                                        where PageId = @PageId;";
                try
                {
                    db.Execute(update_pages_query, new
                    {
                        PageTitle = page.PageTitle,
                        PageDescription = page.PageDescription,
                        PageLink = page.PageLink,
                        PagePublished = page.PagePublished,
                        PageId = page.PageId
                    });
                }
                catch(Exception e)
                {
                    throw e;
                }

                try
                {
                    return db.Execute(update_page_display_query, new
                    {
                        PageBodyHtml = page.PageBodyHtml,
                        PageHeadStyle = page.PageHeadStyle,
                        PageId = page.PageId
                    });
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
