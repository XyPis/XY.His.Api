using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwGnKsFeeMap : EntityTypeConfiguration<VwGnKsFee>
    {
        public VwGnKsFeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.项目名称, t.费别, t.住院或门诊, t.项目编号 });

            // Properties
            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.项目名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.费别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.住院或门诊)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.项目编号)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VwGnKsFee");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.项目名称).HasColumnName("项目名称");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.费别).HasColumnName("费别");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.住院或门诊).HasColumnName("住院或门诊");
            this.Property(t => t.项目编号).HasColumnName("项目编号");
        }
    }
}
