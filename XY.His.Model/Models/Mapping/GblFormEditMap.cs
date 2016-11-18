using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblFormEditMap : EntityTypeConfiguration<GblFormEdit>
    {
        public GblFormEditMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.FiledName)
                .HasMaxLength(50);

            this.Property(t => t.ToolTip)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblFormEdit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.FiledName).HasColumnName("FiledName");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.ToolTip).HasColumnName("ToolTip");
            this.Property(t => t.IsExcept).HasColumnName("IsExcept");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
