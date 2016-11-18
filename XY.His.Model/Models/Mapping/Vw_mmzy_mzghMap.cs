using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_mmzy_mzghMap : EntityTypeConfiguration<Vw_mmzy_mzgh>
    {
        public Vw_mmzy_mzghMap()
        {
            // Primary Key
            this.HasKey(t => t.病人卡号);

            // Properties
            this.Property(t => t.挂号类别)
                .HasMaxLength(50);

            this.Property(t => t.挂号科室)
                .HasMaxLength(30);

            this.Property(t => t.挂号日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.大科室)
                .HasMaxLength(50);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.病人卡号)
                .IsRequired()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("Vw_mmzy_mzgh");
            this.Property(t => t.挂号类别).HasColumnName("挂号类别");
            this.Property(t => t.挂号科室).HasColumnName("挂号科室");
            this.Property(t => t.挂号日期).HasColumnName("挂号日期");
            this.Property(t => t.大科室).HasColumnName("大科室");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.病人卡号).HasColumnName("病人卡号");
            this.Property(t => t.金额).HasColumnName("金额");
        }
    }
}
