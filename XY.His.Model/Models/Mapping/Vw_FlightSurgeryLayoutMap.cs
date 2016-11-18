using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightSurgeryLayoutMap : EntityTypeConfiguration<Vw_FlightSurgeryLayout>
    {
        public Vw_FlightSurgeryLayoutMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplyNo, t.手术安排标识, t.LocationName, t.病人所在床号, t.ApplyTime, t.病情说明, t.手术等级, t.隔离标志, t.第一手术助手, t.第二手术助手, t.第三手术助手, t.第四手术助手, t.Name, t.麻醉医师, t.麻醉助手, t.输血者, t.Memo });

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.手术安排标识)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.病人所在床号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SeqNum)
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

            this.Property(t => t.DoctorName)
                .HasMaxLength(80);

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

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.麻醉医师)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.麻醉助手)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.输血者)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Vw_FlightSurgeryLayout");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.手术安排标识).HasColumnName("手术安排标识");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.病人所在床号).HasColumnName("病人所在床号");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OpsRoomId).HasColumnName("OpsRoomId");
            this.Property(t => t.SeqNum).HasColumnName("SeqNum");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.病情说明).HasColumnName("病情说明");
            this.Property(t => t.手术等级).HasColumnName("手术等级");
            this.Property(t => t.隔离标志).HasColumnName("隔离标志");
            this.Property(t => t.手术科室).HasColumnName("手术科室");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.第一手术助手).HasColumnName("第一手术助手");
            this.Property(t => t.第二手术助手).HasColumnName("第二手术助手");
            this.Property(t => t.第三手术助手).HasColumnName("第三手术助手");
            this.Property(t => t.第四手术助手).HasColumnName("第四手术助手");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.麻醉医师).HasColumnName("麻醉医师");
            this.Property(t => t.麻醉助手).HasColumnName("麻醉助手");
            this.Property(t => t.输血者).HasColumnName("输血者");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.PlanOperId).HasColumnName("PlanOperId");
        }
    }
}
