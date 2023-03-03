using System;
using System.Collections.Generic;

#nullable disable

namespace WebLamDep.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? TypeId { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int? Discount { get; set; }
        public string Thumb { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Tags { get; set; }
        public int? QuantityStock { get; set; }
        public bool Active { get; set; }

        public virtual Type Type { get; set; }
    }
}
