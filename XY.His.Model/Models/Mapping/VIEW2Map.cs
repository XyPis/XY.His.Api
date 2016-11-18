using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VIEW2Map : EntityTypeConfiguration<VIEW2>
    {
        public VIEW2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.Expr1 });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Expr1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VIEW2");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.F2).HasColumnName("F2");
        }
    }
}
