using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgIllCompareMap : EntityTypeConfiguration<DgIllCompare>
    {
        public DgIllCompareMap()
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
            this.ToTable("DgIllCompare");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IcdId1).HasColumnName("IcdId1");
            this.Property(t => t.IcdId2).HasColumnName("IcdId2");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.DgIllCompares)
                .HasForeignKey(d => d.IcdId1);
            this.HasOptional(t => t.BsIllness1)
                .WithMany(t => t.DgIllCompares1)
                .HasForeignKey(d => d.IcdId2);

        }
    }
}
