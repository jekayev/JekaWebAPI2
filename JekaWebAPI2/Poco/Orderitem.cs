using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("orderitem")]
    public partial class Orderitem
    {
        [Column("itemId")]
        public int ItemId { get; set; }
        [Column("productId")]
        public int? ProductId { get; set; }
        [Column("orderId")]
        public int? OrderId { get; set; }
        [Column("camperId")]
        public int? CamperId { get; set; }
        [Column("orderItemStatus")]
        public int? OrderItemStatus { get; set; }
    }
}