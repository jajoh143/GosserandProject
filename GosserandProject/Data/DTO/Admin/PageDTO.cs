using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GosserandProject.Data.DTO.Admin
{
    public class PageDTO
    {
        public int PageId { get; set; }
        [Display(Name = "Page Title")]
        public string PageTitle { get; set; }
        [Display(Name = "Page Link")]
        public string PageLink { get; set; }
        [Display(Name = "Is Page Published?")]
        public bool PagePublished { get; set; }
        [Display(Name = "Page Description")]
        public string PageDescription { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorUsername { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
