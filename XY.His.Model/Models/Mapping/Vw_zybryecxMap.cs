using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zybryecxMap : EntityTypeConfiguration<Vw_zybryecx>
    {
        public Vw_zybryecxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.预交额, t.总金额 });

            // Properties
            this.Property(t => t.住院号)
                .HasMaxLength(20);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.床号)
                .HasMaxLength(10);

            this.Property(t => t.科室)
                .HasMaxLength(30);

            this.Property(t => t.类型)
                .HasMaxLength(50);

            this.Property(t => t.预交额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.总金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_zybryecx");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.床号).HasColumnName("床号");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.类型).HasColumnName("类型");
            this.Property(t => t.预交额).HasColumnName("预交额");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.欠款).HasColumnName("欠款");
            this.Property(t => t.余款).HasColumnName("余款");
        }
    }
}
