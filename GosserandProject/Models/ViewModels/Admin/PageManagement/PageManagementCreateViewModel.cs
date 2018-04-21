using GosserandProject.Data.DTO.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Models.ViewModels.Admin.PageManagement
{
    public class PageManagementCreateViewModel
    {
        public PageDetailDTO Page { get; set; }

        public PageManagementCreateViewModel()
        {
            Page = new PageDetailDTO();
        }
    }
}
