using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BaseTableRoleMap : EntityTypeConfiguration<BaseTableRole>
    {
        public BaseTableRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BaseTableRole");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BaseTableId).HasColumnName("BaseTableId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");

            // Relationships
            this.HasOptional(t => t.GblBaseTableItem)
                .WithMany(t => t.BaseTableRoles)
                .HasForeignKey(d => d.BaseTableId);
            this.HasOptional(t => t.GblRole)
                .WithMany(t => t.BaseTableRoles)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
