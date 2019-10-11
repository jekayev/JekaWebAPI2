using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("product")]
    public partial class Product
    {
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("productIndex")]
        public int? ProductIndex { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }
        [Column("session")]
        public int? Session { get; set; }
        [Column("price")]
        [StringLength(25)]
        public string Price { get; set; }
        [Column("fromDate", TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column("toDate", TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [Column("location")]
        [StringLength(50)]
        public string Location { get; set; }
    }
}