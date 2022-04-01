using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
