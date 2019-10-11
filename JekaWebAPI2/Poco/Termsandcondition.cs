using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("termsandconditions")]
    public partial class Termsandcondition
    {
        [Column("termOrConditionId")]
        public int TermOrConditionId { get; set; }
        [Column("termOrConditioName")]
        [StringLength(100)]
        public string TermOrConditioName { get; set; }
        [Column("termOrConditionDescription", TypeName = "text")]
        public string TermOrConditionDescription { get; set; }
    }
}