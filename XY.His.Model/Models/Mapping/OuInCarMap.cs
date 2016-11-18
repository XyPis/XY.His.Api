using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuInCarMap : EntityTypeConfiguration<OuInCar>
    {
        public OuInCarMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CarNumber)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuInCar");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.NurseOperId).HasColumnName("NurseOperId");
            this.Property(t => t.DriverOperId).HasColumnName("DriverOperId");
            this.Property(t => t.CarNumber).HasColumnName("CarNumber");
            this.Property(t => t.CarTime).HasColumnName("CarTime");
            this.Property(t => t.Distance).HasColumnName("Distance");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.OuInCars)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OuInCars)
                .HasForeignKey(d => d.NurseOperId);
            this.HasRequired(t => t.BsUser1)
                .WithMany(t => t.OuInCars1)
                .HasForeignKey(d => d.DriverOperId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.OuInCars)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.OuInCars)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
