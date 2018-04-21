using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.DTO.FrontEnd
{
    public class PageDisplayDTO
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageBodyHtml { get; set; }
        public string PageHeadStyle { get; set; }
        public string PageLink { get; set; }
    }
}
