using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CategoryLogMap : EntityTypeConfiguration<CategoryLog>
    {
        public CategoryLogMap()
        {
            // Primary Key
            this.HasKey(t => t.CategoryLogID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CategoryLog");
            this.Property(t => t.CategoryLogID).HasColumnName("CategoryLogID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.LogID).HasColumnName("LogID");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.CategoryLogs)
                .HasForeignKey(d => d.CategoryID);
            this.HasRequired(t => t.Log)
                .WithMany(t => t.CategoryLogs)
                .HasForeignKey(d => d.LogID);

        }
    }
}
