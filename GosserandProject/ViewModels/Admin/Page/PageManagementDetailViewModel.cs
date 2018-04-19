using GosserandProject.Data.DTO.Admin;
using GossserandProject.Data.Queries.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.ViewModels.Admin.Page
{
    public class PageManagementDetailViewModel
    {
        public PageDetailDTO Page { get; set;}
        
        public PageManagementDetailViewModel(string connString, int id)
        {
            Page = GetPageManagementData.GetPageDetail(connString, id);
        }
    }
}
