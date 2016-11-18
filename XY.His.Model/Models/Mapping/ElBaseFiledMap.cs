using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElBaseFiledMap : EntityTypeConfiguration<ElBaseFiled>
    {
        public ElBaseFiledMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditMask)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.ToolTips)
                .HasMaxLength(100);

            this.Property(t => t.ErrorTips)
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
            this.ToTable("ElBaseFiled");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LsDataType).HasColumnName("LsDataType");
            this.Property(t => t.Lengh).HasColumnName("Lengh");
            this.Property(t => t.EditMask).HasColumnName("EditMask");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ToolTips).HasColumnName("ToolTips");
            this.Property(t => t.ErrorTips).HasColumnName("ErrorTips");
            this.Property(t => t.IsHasChild).HasColumnName("IsHasChild");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsEncrypt).HasColumnName("IsEncrypt");
            this.Property(t => t.IsLog).HasColumnName("IsLog");
        }
    }
}
