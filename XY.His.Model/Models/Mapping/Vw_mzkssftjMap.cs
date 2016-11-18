using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_mzkssftjMap : EntityTypeConfiguration<Vw_mzkssftj>
    {
        public Vw_mzkssftjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.全院, t.Hospitalid });

            // Properties
            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.基础分类)
                .HasMaxLength(50);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.全院)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Hospitalid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_mzkssftj");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.全院).HasColumnName("全院");
            this.Property(t => t.Hospitalid).HasColumnName("Hospitalid");
        }
    }
}
