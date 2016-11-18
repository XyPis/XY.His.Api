using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsLabSourceItemMap : EntityTypeConfiguration<BsLabSourceItem>
    {
        public BsLabSourceItemMap()
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
            this.ToTable("BsLabSourceItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.TubeTypeId).HasColumnName("TubeTypeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.LsUseArea).HasColumnName("LsUseArea");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLabSource)
                .WithMany(t => t.BsLabSourceItems)
                .HasForeignKey(d => d.SourceId);
            this.HasOptional(t => t.BsTubeType)
                .WithMany(t => t.BsLabSourceItems)
                .HasForeignKey(d => d.TubeTypeId);

        }
    }
}
