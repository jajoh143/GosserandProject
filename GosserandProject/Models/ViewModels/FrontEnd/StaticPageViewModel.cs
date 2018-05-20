using GosserandProject.Data.DTO.FrontEnd;
using GosserandProject.ViewModels.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Models.ViewModels.FrontEnd
{
    public class StaticPageViewModel : BaseFrontEndViewModel
    {
        public PageDisplayDTO PageDisplay { get; set; }

        public StaticPageViewModel(string connString, string routeName) : base(connString)
        {
            PageDisplay = GetFrontEndData.GetStaticPage(routeName);
        }
    }
}
