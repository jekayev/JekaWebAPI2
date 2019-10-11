using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JekaWebAPI2.Poco
{
    [Table("camper")]
    public partial class Camper
    {
        [Column("camperId")]
        public int CamperId { get; set; }
        [Column("guardiansId")]
        public int? GuardiansId { get; set; }
        [Column("orderId")]
        public int? OrderId { get; set; }
        [Column("firstName")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column("lastName")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column("address1")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("country")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column("provinceState")]
        [StringLength(50)]
        public string ProvinceState { get; set; }
        [Column("postalCodeZip")]
        [StringLength(10)]
        public string PostalCodeZip { get; set; }
        [Column("camperGender")]
        [StringLength(6)]
        public string CamperGender { get; set; }
        [Column("grade")]
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("cabinMate")]
        [StringLength(100)]
        public string CabinMate { get; set; }
        [Column("birthdate", TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [Column("authorisedPerson")]
        [StringLength(100)]
        public string AuthorisedPerson { get; set; }
        [Column("emergencyPhone")]
        [StringLength(50)]
        public string EmergencyPhone { get; set; }
        [Column("advertismentSource")]
        [StringLength(255)]
        public string AdvertismentSource { get; set; }
        [Column("assurance")]
        [StringLength(50)]
        public string Assurance { get; set; }
        [Column("alergicToMedication")]
        [StringLength(500)]
        public string AlergicToMedication { get; set; }
        [Column("childTakingMedication")]
        [StringLength(500)]
        public string ChildTakingMedication { get; set; }
        [Column("otherIllness")]
        [StringLength(500)]
        public string OtherIllness { get; set; }
        [Column("alergies")]
        public long? Alergies { get; set; }
        [Column("allergiesDescription")]
        [StringLength(500)]
        public string AllergiesDescription { get; set; }
        [Column("subjectIllness")]
        [StringLength(500)]
        public string SubjectIllness { get; set; }
        [Column("illnessDescription")]
        [StringLength(500)]
        public string IllnessDescription { get; set; }
        [Column("specialCare")]
        [StringLength(500)]
        public string SpecialCare { get; set; }
        [Column("restrictActivities")]
        public long? RestrictActivities { get; set; }
        [Column("otherMedicalComments")]
        [StringLength(500)]
        public string OtherMedicalComments { get; set; }
        [Column("cabinId")]
        public int? CabinId { get; set; }
        [Column("checkIn")]
        public long? CheckIn { get; set; }
        [Column("checkInDateTime", TypeName = "datetime")]
        public DateTime? CheckInDateTime { get; set; }
        [Column("checkOutDateTime", TypeName = "datetime")]
        public DateTime? CheckOutDateTime { get; set; }
        [Column("tempCheckIn")]
        public long? TempCheckIn { get; set; }
        [Column("tempCheckInDateTime", TypeName = "datetime")]
        public DateTime? TempCheckInDateTime { get; set; }
        [Column("tempCheckOutDateTime", TypeName = "datetime")]
        public DateTime? TempCheckOutDateTime { get; set; }
    }
}