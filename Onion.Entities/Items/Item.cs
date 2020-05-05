using Onion.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Entities.Items
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
       public decimal SalePrice { get; set; }
        public bool IsDeleted { get; set; }
        public bool Published { get; set; }
        public DateTime PublishedOnUtc { get; set; }
    }
}
