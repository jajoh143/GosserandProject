using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.DTO.FrontEnd
{
    public class PageLinkDTO
    {
        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public string PageLink { get; set; }
        public int? PageParentId { get; set; }
    }
}
