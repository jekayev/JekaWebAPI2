using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("cabin")]
    public partial class Cabin
    {
        [Column("cabinId")]
        public int CabinId { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("capacity")]
        public int? Capacity { get; set; }
    }
}