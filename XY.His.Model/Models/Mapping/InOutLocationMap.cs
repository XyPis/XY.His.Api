using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InOutLocationMap : EntityTypeConfiguration<InOutLocation>
    {
        public InOutLocationMap()
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
            this.ToTable("InOutLocation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.OutLocId).HasColumnName("OutLocId");
            this.Property(t => t.OutOperTime).HasColumnName("OutOperTime");
            this.Property(t => t.OutOperId).HasColumnName("OutOperId");
            this.Property(t => t.isReceived).HasColumnName("isReceived");
            this.Property(t => t.InLocId).HasColumnName("InLocId");
            this.Property(t => t.InOperTime).HasColumnName("InOperTime");
            this.Property(t => t.InOperId).HasColumnName("InOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBed)
                .WithMany(t => t.InOutLocations)
                .HasForeignKey(d => d.BedId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InOutLocations)
                .HasForeignKey(d => d.OutLocId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.InOutLocations1)
                .HasForeignKey(d => d.InLocId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.InOutLocations)
                .HasForeignKey(d => d.OutOperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.InOutLocations1)
                .HasForeignKey(d => d.InOperId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InOutLocations)
                .HasForeignKey(d => d.HospId);

        }
    }
}
