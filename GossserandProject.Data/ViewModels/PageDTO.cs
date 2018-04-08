using System;
using System.Collections.Generic;
using System.Text;

namespace GossserandProject.Data.ViewModels
{
    public class PageDTO
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AutherUsername { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
