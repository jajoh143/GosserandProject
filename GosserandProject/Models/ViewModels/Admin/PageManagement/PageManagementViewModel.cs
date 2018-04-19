using GosserandProject.Data.DTO.Admin;
using GossserandProject.Data.Queries.Page;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Models.ViewModels.Admin.PageManagement
{
    public class PageManagementViewModel
    {
        public IEnumerable<PageDTO> Pages { get; set; }
       
        public PageManagementViewModel(string connString)
        {
            Pages = GetPageManagementData.GetPagesData(connString);
         
        }
    }
}
