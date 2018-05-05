using GosserandProject.Data.DTO.FrontEnd;
using GosserandProject.Data.Queries.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.ViewModels.FrontEnd
{
    public class BaseFrontEndViewModel
    {
        public IEnumerable<PageLinkDTO> Links { get; set; }

        public BaseFrontEndViewModel(string connString)
        {
            Links = GetFrontEndData.GetPageLinks(connString);
        }

    }
}
