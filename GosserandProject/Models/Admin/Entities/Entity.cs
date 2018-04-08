using System;
using System.Collections.Generic;
using System.Text;

namespace GossserandProject.Data.Models.Entities
{
    public class Entity
    {
        public Guid Uuid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
