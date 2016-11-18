using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightSurgeryNoticeMap : EntityTypeConfiguration<Vw_FlightSurgeryNotice>
    {
        public Vw_FlightSurgeryNoticeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplyNo, t.病历号, t.Name, t.IsUrgent, t.OperTime, t.病情说明, t.手术等级, t.隔离标志, t.第一手术助手, t.第二手术助手, t.第三手术助手, t.第四手术助手 });

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.病历号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Diagnose)
                .HasMaxLength(1000);

            this.Property(t => t.病情说明)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.手术等级)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.隔离标志)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.第一手术助手)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.第二手术助手)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.第三手术助手)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.第四手术助手)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_FlightSurgeryNotice");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.病历号).HasColumnName("病历号");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.IsUrgent).HasColumnName("IsUrgent");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.病情说明).HasColumnName("病情说明");
            this.Property(t => t.手术等级).HasColumnName("手术等级");
            this.Property(t => t.隔离标志).HasColumnName("隔离标志");
            this.Property(t => t.第一手术助手).HasColumnName("第一手术助手");
            this.Property(t => t.第二手术助手).HasColumnName("第二手术助手");
            this.Property(t => t.第三手术助手).HasColumnName("第三手术助手");
            this.Property(t => t.第四手术助手).HasColumnName("第四手术助手");
        }
    }
}
