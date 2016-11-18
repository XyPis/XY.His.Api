using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuIncomeAllMap : EntityTypeConfiguration<VwOuIncomeAll>
    {
        public VwOuIncomeAllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.大科, t.分院, t.基础分类, t.金额, t.PatientId });

            // Properties
            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.大科)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.分院)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.基础分类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwOuIncomeAll");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.大科).HasColumnName("大科");
            this.Property(t => t.分院).HasColumnName("分院");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.PatientId).HasColumnName("PatientId");
        }
    }
}
