using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsDrugFormUnitMap : EntityTypeConfiguration<BsDrugFormUnit>
    {
        public BsDrugFormUnitMap()
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
            this.ToTable("BsDrugFormUnit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsDrugForm)
                .WithMany(t => t.BsDrugFormUnits)
                .HasForeignKey(d => d.FormId);

        }
    }
}
