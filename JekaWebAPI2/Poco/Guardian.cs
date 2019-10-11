using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("guardians")]
    public partial class Guardian
    {
        [Column("guardiansId")]
        public int GuardiansId { get; set; }
        [Column("maleFirstName")]
        [StringLength(100)]
        public string MaleFirstName { get; set; }
        [Column("maleLastName")]
        [StringLength(100)]
        public string MaleLastName { get; set; }
        [Column("malePhoneNumber")]
        [StringLength(50)]
        public string MalePhoneNumber { get; set; }
        [Column("maleOtherPhoneNumber")]
        [StringLength(50)]
        public string MaleOtherPhoneNumber { get; set; }
        [Column("femaleFirstName")]
        [StringLength(100)]
        public string FemaleFirstName { get; set; }
        [Column("femaleLastName")]
        [StringLength(100)]
        public string FemaleLastName { get; set; }
        [Column("femalePhoneNumber")]
        [StringLength(50)]
        public string FemalePhoneNumber { get; set; }
        [Column("femaleOtherPhoneNumber")]
        [StringLength(50)]
        public string FemaleOtherPhoneNumber { get; set; }
    }
}