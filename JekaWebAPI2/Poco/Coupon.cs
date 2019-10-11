using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("coupons")]
    public partial class Coupon
    {
        [Column("couponId")]
        public int CouponId { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("amount")]
        [StringLength(10)]
        public string Amount { get; set; }
        [Column("limitation")]
        public int? Limitation { get; set; }
        [Column("count")]
        public int? Count { get; set; }
    }
}