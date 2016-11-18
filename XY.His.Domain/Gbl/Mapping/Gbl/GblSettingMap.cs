using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.Gbl.Mapping
{
    public class GblSettingMap : EntityTypeConfiguration<GblSetting>
    {
        public GblSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.KeyNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SetValue)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblSetting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.KeyNum).HasColumnName("KeyNum");
            this.Property(t => t.SetValue).HasColumnName("SetValue");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
