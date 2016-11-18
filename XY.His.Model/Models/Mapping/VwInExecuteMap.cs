using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInExecuteMap : EntityTypeConfiguration<VwInExecute>
    {
        public VwInExecuteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.用法, t.科室, t.病区 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.用法)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.病区)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwInExecute");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.用法).HasColumnName("用法");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.病区).HasColumnName("病区");
            this.Property(t => t.次数).HasColumnName("次数");
            this.Property(t => t.年).HasColumnName("年");
            this.Property(t => t.月).HasColumnName("月");
        }
    }
}
