using System;
using System.Collections.Generic;

#nullable disable

namespace WebLamDep.Models
{
    public partial class Type
    {
        public Type()
        {
            Products = new HashSet<Product>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
