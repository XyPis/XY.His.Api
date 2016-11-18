using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yszlMap : EntityTypeConfiguration<Vw_yszl>
    {
        public Vw_yszlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.c_yisbh, t.c_yisxm });

            // Properties
            this.Property(t => t.c_yisbh)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.c_yisxm)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Vw_yszl");
            this.Property(t => t.c_yisbh).HasColumnName("c_yisbh");
            this.Property(t => t.c_yisxm).HasColumnName("c_yisxm");
        }
    }
}
