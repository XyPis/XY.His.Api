using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightCheckingMap : EntityTypeConfiguration<Vw_FlightChecking>
    {
        public Vw_FlightCheckingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplyNo, t.检查号类别, t.检查标识号, t.PatId, t.XtypeName, t.临床症状, t.体征, t.相关化验结果, t.其他诊断, t.检查方式, t.使用仪器, t.病人来源, t.外来医疗单位名称, t.OperTime, t.doctorName, t.注意事项, t.操作者, t.检查结果状态 });

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.检查号类别)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.检查标识号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.XtypeName)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.CheckBody)
                .HasMaxLength(100);

            this.Property(t => t.临床症状)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.体征)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.相关化验结果)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.其他诊断)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Diagnose)
                .HasMaxLength(1000);

            this.Property(t => t.检查方式)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Equipment)
                .HasMaxLength(50);

            this.Property(t => t.使用仪器)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.病人来源)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.外来医疗单位名称)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.doctorName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ApplyMemo)
                .HasMaxLength(500);

            this.Property(t => t.注意事项)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.操作者)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.reportDoctorName)
                .HasMaxLength(30);

            this.Property(t => t.检查结果状态)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_FlightChecking");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.检查号类别).HasColumnName("检查号类别");
            this.Property(t => t.检查标识号).HasColumnName("检查标识号");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.XtypeName).HasColumnName("XtypeName");
            this.Property(t => t.CheckBody).HasColumnName("CheckBody");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.临床症状).HasColumnName("临床症状");
            this.Property(t => t.体征).HasColumnName("体征");
            this.Property(t => t.相关化验结果).HasColumnName("相关化验结果");
            this.Property(t => t.其他诊断).HasColumnName("其他诊断");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.检查方式).HasColumnName("检查方式");
            this.Property(t => t.Equipment).HasColumnName("Equipment");
            this.Property(t => t.使用仪器).HasColumnName("使用仪器");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.病人来源).HasColumnName("病人来源");
            this.Property(t => t.外来医疗单位名称).HasColumnName("外来医疗单位名称");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.doctorName).HasColumnName("doctorName");
            this.Property(t => t.ApplyMemo).HasColumnName("ApplyMemo");
            this.Property(t => t.预约日期及时间).HasColumnName("预约日期及时间");
            this.Property(t => t.注意事项).HasColumnName("注意事项");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.操作者).HasColumnName("操作者");
            this.Property(t => t.reportDoctorName).HasColumnName("reportDoctorName");
            this.Property(t => t.检查结果状态).HasColumnName("检查结果状态");
        }
    }
}
