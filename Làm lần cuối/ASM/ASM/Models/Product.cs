using System;
using System.Collections.Generic;

#nullable disable

namespace ASM.Models
{
    public partial class Product
    {
        public Product()
        {
            OderDetails = new HashSet<OderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public int? CateId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Modified { get; set; }
        public bool BestSellers { get; set; }
        public bool HomeFlag { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public int? SoLuongConLai { get; set; }

        public virtual Category Cate { get; set; }
        public virtual ICollection<OderDetail> OderDetails { get; set; }
    }
}
