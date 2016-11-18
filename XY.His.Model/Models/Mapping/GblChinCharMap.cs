using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblChinCharMap : EntityTypeConfiguration<GblChinChar>
    {
        public GblChinCharMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PyChar)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.WbChar)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblChinChar");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.PyChar).HasColumnName("PyChar");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.WbChar).HasColumnName("WbChar");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
