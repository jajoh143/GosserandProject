using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GosserandProject.Data.DTO.Admin
{
    public class PageDetailDTO : PageDTO
    {
        [Display(Name = "Page Body Html")]
        public string PageBodyHtml { get; set;}
        [Display(Name = "Header Style")]
        public string PageHeadStyle { get; set; }

    }
}
