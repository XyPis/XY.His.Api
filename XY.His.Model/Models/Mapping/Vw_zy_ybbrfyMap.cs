using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zy_ybbrfyMap : EntityTypeConfiguration<Vw_zy_ybbrfy>
    {
        public Vw_zy_ybbrfyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.总金额, t.日期 });

            // Properties
            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.总金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_zy_ybbrfy");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.日期).HasColumnName("日期");
        }
    }
}
