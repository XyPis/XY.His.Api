using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_EMR_HaveToMap : EntityTypeConfiguration<Vw_DI_EMR_HaveTo>
    {
        public Vw_DI_EMR_HaveToMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.卡号, t.住院号, t.病人姓名, t.入院时间, t.住院次数, t.病历类别, t.HospId, t.CatalogId });

            // Properties
            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.卡号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.病人姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.出院时间)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.病历类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CatalogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_DI_EMR_HaveTo");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.病人姓名).HasColumnName("病人姓名");
            this.Property(t => t.入院时间).HasColumnName("入院时间");
            this.Property(t => t.出院时间).HasColumnName("出院时间");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.病历类别).HasColumnName("病历类别");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
        }
    }
}
