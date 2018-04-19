using System;
using System.Collections.Generic;
using System.Text;

namespace GosserandProject.Data.DTO.Admin
{
    public class PageDTO
    {
        public string PageTitle { get; set; }
        public string PageLink { get; set; }
        public bool PagePublished { get; set; }
        public string PageDescription { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AutherUsername { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
