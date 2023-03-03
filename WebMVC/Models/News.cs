using System;
using System.Collections.Generic;

#nullable disable

namespace WebLamDep.Models
{
    public partial class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumb { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? AccountId { get; set; }
        public bool Active { get; set; }
    }
}
