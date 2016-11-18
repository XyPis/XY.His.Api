using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkBldDonateMap : EntityTypeConfiguration<CkBldDonate>
    {
        public CkBldDonateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BloodGroup)
                .HasMaxLength(50);

            this.Property(t => t.RHD)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkBldDonate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.RHD).HasColumnName("RHD");
            this.Property(t => t.BloodTypeId).HasColumnName("BloodTypeId");
            this.Property(t => t.Vollume).HasColumnName("Vollume");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.CkBldDonates)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.CkBloodType)
                .WithMany(t => t.CkBldDonates)
                .HasForeignKey(d => d.BloodTypeId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.CkBldDonates)
                .HasForeignKey(d => d.HospId);

        }
    }
}
