using GosserandProject.Data.DTO.FrontEnd;
using GosserandProject.Data.Queries.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.ViewModels.FrontEnd
{
    public class IndexPageViewModel
    {
        public PageDisplayDTO IndexPageDisplay { get; set; }

        public IndexPageViewModel(string connectionString)
        {
            IndexPageDisplay = GetFrontEndData.GetIndexPage(connectionString);
        }
    }
}
