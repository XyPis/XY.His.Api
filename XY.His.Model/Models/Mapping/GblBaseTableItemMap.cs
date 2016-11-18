using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblBaseTableItemMap : EntityTypeConfiguration<GblBaseTableItem>
    {
        public GblBaseTableItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BaseTable)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BLLClassName)
                .HasMaxLength(50);

            this.Property(t => t.ModelClassName)
                .HasMaxLength(50);

            this.Property(t => t.ConfigType)
                .HasMaxLength(50);

            this.Property(t => t.OrderField)
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
            this.ToTable("GblBaseTableItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.BaseTable).HasColumnName("BaseTable");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BLLClassName).HasColumnName("BLLClassName");
            this.Property(t => t.ModelClassName).HasColumnName("ModelClassName");
            this.Property(t => t.ConfigType).HasColumnName("ConfigType");
            this.Property(t => t.IsTable).HasColumnName("IsTable");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.OrderField).HasColumnName("OrderField");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsToWmr).HasColumnName("IsToWmr");

            // Relationships
            this.HasOptional(t => t.GblRole)
                .WithMany(t => t.GblBaseTableItems)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
