using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OUT_V_PACS_ZBMap : EntityTypeConfiguration<OUT_V_PACS_ZB>
    {
        public OUT_V_PACS_ZBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JYJCDH, t.XH, t.XMMC, t.DJ, t.SL, t.XMLX });

            // Properties
            this.Property(t => t.JYJCDH)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.XH)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.XMBM)
                .HasMaxLength(100);

            this.Property(t => t.XMMC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DJ)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SL)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.XMLX)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("OUT_V_PACS_ZB");
            this.Property(t => t.JYJCDH).HasColumnName("JYJCDH");
            this.Property(t => t.XH).HasColumnName("XH");
            this.Property(t => t.XMBM).HasColumnName("XMBM");
            this.Property(t => t.XMMC).HasColumnName("XMMC");
            this.Property(t => t.DJ).HasColumnName("DJ");
            this.Property(t => t.SL).HasColumnName("SL");
            this.Property(t => t.XMLX).HasColumnName("XMLX");
        }
    }
}
