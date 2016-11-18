using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_xxk_ryrsbcsMap : EntityTypeConfiguration<Vw_xxk_ryrsbcs>
    {
        public Vw_xxk_ryrsbcsMap()
        {
            // Primary Key
            this.HasKey(t => t.科室);

            // Properties
            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_xxk_ryrsbcs");
            this.Property(t => t.床位数).HasColumnName("床位数");
            this.Property(t => t.入院人数).HasColumnName("入院人数");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.日期).HasColumnName("日期");
        }
    }
}
