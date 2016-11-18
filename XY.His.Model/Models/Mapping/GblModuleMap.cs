using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblModuleMap : EntityTypeConfiguration<GblModule>
    {
        public GblModuleMap()
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
            this.ToTable("GblModule");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FunctionID).HasColumnName("FunctionID");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.GblSystemFunction)
                .WithMany(t => t.GblModules)
                .HasForeignKey(d => d.FunctionID);
            this.HasOptional(t => t.GblSystemMenu)
                .WithMany(t => t.GblModules)
                .HasForeignKey(d => d.MenuId);

        }
    }
}
