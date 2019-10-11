using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JekaWebAPI2.Poco
{
    public partial class CampregistrationContext : DbContext
    {
        public CampregistrationContext()
        {
        }

        public CampregistrationContext(DbContextOptions<CampregistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Camper> Campers { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Guardian> Guardians { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderitem> Orderitems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Termsandcondition> Termsandconditions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Camper>(entity =>
            {
                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.AdvertismentSource).IsUnicode(false);

                entity.Property(e => e.AlergicToMedication).IsUnicode(false);

                entity.Property(e => e.AllergiesDescription).IsUnicode(false);

                entity.Property(e => e.Assurance).IsUnicode(false);

                entity.Property(e => e.AuthorisedPerson).IsUnicode(false);

                entity.Property(e => e.CabinMate).IsUnicode(false);

                entity.Property(e => e.CamperGender).IsUnicode(false);

                entity.Property(e => e.ChildTakingMedication).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmergencyPhone).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Grade).IsUnicode(false);

                entity.Property(e => e.IllnessDescription).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.OtherIllness).IsUnicode(false);

                entity.Property(e => e.OtherMedicalComments).IsUnicode(false);

                entity.Property(e => e.PostalCodeZip).IsUnicode(false);

                entity.Property(e => e.ProvinceState).IsUnicode(false);

                entity.Property(e => e.SpecialCare).IsUnicode(false);

                entity.Property(e => e.SubjectIllness).IsUnicode(false);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.Amount).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Guardian>(entity =>
            {
                entity.HasKey(e => e.GuardiansId)
                    .HasName("PK__guardian__ADD27857FD14A69A");

                entity.Property(e => e.FemaleFirstName).IsUnicode(false);

                entity.Property(e => e.FemaleLastName).IsUnicode(false);

                entity.Property(e => e.FemaleOtherPhoneNumber).IsUnicode(false);

                entity.Property(e => e.FemalePhoneNumber).IsUnicode(false);

                entity.Property(e => e.MaleFirstName).IsUnicode(false);

                entity.Property(e => e.MaleLastName).IsUnicode(false);

                entity.Property(e => e.MaleOtherPhoneNumber).IsUnicode(false);

                entity.Property(e => e.MalePhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__orderite__56A128AAD20F5163");

                entity.Property(e => e.OrderItemStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Price).IsUnicode(false);
            });

            modelBuilder.Entity<Termsandcondition>(entity =>
            {
                entity.HasKey(e => e.TermOrConditionId)
                    .HasName("PK__termsand__41858B6E0801FA5C");

                entity.Property(e => e.TermOrConditioName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}