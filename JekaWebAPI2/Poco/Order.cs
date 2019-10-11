using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("orders")]
    public partial class Order
    {
        [Column("orderId")]
        public int OrderId { get; set; }
        [Column("couponId")]
        public int? CouponId { get; set; }
        [Column("paymentId")]
        public int PaymentId { get; set; }
    }
}