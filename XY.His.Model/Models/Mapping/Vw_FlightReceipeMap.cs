using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightReceipeMap : EntityTypeConfiguration<Vw_FlightReceipe>
    {
        public Vw_FlightReceipeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PatID, t.HospId, t.医嘱序号, t.医嘱子序号, t.长期医嘱标志, t.医嘱类别, t.Name, t.ID, t.Dosage, t.UnitTakeName, t.UsageName, t.持续时间, t.持续时间单位, t.PrintName, t.Times, t.Days, t.频率间隔单位, t.执行时间详细描述, t.医嘱状态, t.药品计价属性, t.计价属性 });

            // Properties
            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.医嘱序号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.医嘱子序号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.长期医嘱标志)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.医嘱类别)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.持续时间)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.持续时间单位)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PrintName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Times)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.频率间隔单位)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.执行时间详细描述)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.医嘱状态)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.药品计价属性)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.计价属性)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_FlightReceipe");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.医嘱序号).HasColumnName("医嘱序号");
            this.Property(t => t.医嘱子序号).HasColumnName("医嘱子序号");
            this.Property(t => t.长期医嘱标志).HasColumnName("长期医嘱标志");
            this.Property(t => t.医嘱类别).HasColumnName("医嘱类别");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.ChkOperTime).HasColumnName("ChkOperTime");
            this.Property(t => t.EndOperTime).HasColumnName("EndOperTime");
            this.Property(t => t.持续时间).HasColumnName("持续时间");
            this.Property(t => t.持续时间单位).HasColumnName("持续时间单位");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.PrintName).HasColumnName("PrintName");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.频率间隔单位).HasColumnName("频率间隔单位");
            this.Property(t => t.执行时间详细描述).HasColumnName("执行时间详细描述");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.医嘱状态).HasColumnName("医嘱状态");
            this.Property(t => t.药品计价属性).HasColumnName("药品计价属性");
            this.Property(t => t.计价属性).HasColumnName("计价属性");
        }
    }
}
