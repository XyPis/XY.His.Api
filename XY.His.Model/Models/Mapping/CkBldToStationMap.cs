using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkBldToStationMap : EntityTypeConfiguration<CkBldToStation>
    {
        public CkBldToStationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecNo)
                .HasMaxLength(12);

            this.Property(t => t.BackReason)
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkBldToStation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.BloodId).HasColumnName("BloodId");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.BackOperId).HasColumnName("BackOperId");
            this.Property(t => t.BackReason).HasColumnName("BackReason");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CkBdBank)
                .WithMany(t => t.CkBldToStations)
                .HasForeignKey(d => d.BloodId);

        }
    }
}
