using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgIllXdRpMap : EntityTypeConfiguration<DgIllXdRp>
    {
        public DgIllXdRpMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DgIllXdRp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IllId).HasColumnName("IllId");
            this.Property(t => t.XdRpId).HasColumnName("XdRpId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.DgIllXdRps)
                .HasForeignKey(d => d.IllId);
            this.HasRequired(t => t.BsXdRp)
                .WithMany(t => t.DgIllXdRps)
                .HasForeignKey(d => d.XdRpId);

        }
    }
}
