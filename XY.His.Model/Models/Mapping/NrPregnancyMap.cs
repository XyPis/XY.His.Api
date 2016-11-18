using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NrPregnancyMap : EntityTypeConfiguration<NrPregnancy>
    {
        public NrPregnancyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NrPregnancy");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ExpectDate).HasColumnName("ExpectDate");
            this.Property(t => t.PregnantWeek).HasColumnName("PregnantWeek");
            this.Property(t => t.PregnancyTime).HasColumnName("PregnancyTime");
            this.Property(t => t.DeliveryTimes).HasColumnName("DeliveryTimes");
            this.Property(t => t.UterusShrink).HasColumnName("UterusShrink");
            this.Property(t => t.UterusOpen).HasColumnName("UterusOpen");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.NrPregnancies)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.NrPregnancies)
                .HasForeignKey(d => d.HospId);

        }
    }
}
