using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_mmzy_mzzlrc_fyMap : EntityTypeConfiguration<Vw_mmzy_mzzlrc_fy>
    {
        public Vw_mmzy_mzzlrc_fyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.卡号, t.处方号 });

            // Properties
            this.Property(t => t.分院)
                .HasMaxLength(50);

            this.Property(t => t.科室)
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.卡号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.处方号)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_mmzy_mzzlrc_fy");
            this.Property(t => t.分院).HasColumnName("分院");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.处方号).HasColumnName("处方号");
        }
    }
}
