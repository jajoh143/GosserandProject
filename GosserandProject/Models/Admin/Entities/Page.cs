using GossserandProject.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GossserandProject.Data.Models
{
    public class Page
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public Guid AuthorUuid { get; set; }

    }
}
