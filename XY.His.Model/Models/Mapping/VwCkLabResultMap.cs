using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkLabResultMap : EntityTypeConfiguration<VwCkLabResult>
    {
        public VwCkLabResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LabNum, t.Diagnose, t.OperTime, t.OperId, t.IsPriority, t.IsCancel, t.LabId, t.TestId, t.ItemName, t.Price, t.TestTypeName, t.Result, t.Unit, t.LsRefFlag, t.IsPanic, t.IsDalta, t.DalAbsolute, t.DalPercent, t.LowValue, t.HighValue, t.PanicLow, t.PanicHigh, t.IsPass, t.IsReport, t.Memo, t.ReportOperTime, t.ReportOperId, t.ReportOperName, t.IsPrint, t.IsPositive });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LabNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.Diagnose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.LsSourceName)
                .HasMaxLength(8);

            this.Property(t => t.LabId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestTypeName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LastResult)
                .HasMaxLength(100);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LsRefFlag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DalAbsolute)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DalPercent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LowValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HighValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PanicLow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PanicHigh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ReportOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReportOperName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.IsPositive)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwCkLabResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.CollectTime).HasColumnName("CollectTime");
            this.Property(t => t.CollectOperId).HasColumnName("CollectOperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.LsSourceName).HasColumnName("LsSourceName");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.TestTypeName).HasColumnName("TestTypeName");
            this.Property(t => t.LastResult).HasColumnName("LastResult");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.LsRefFlag).HasColumnName("LsRefFlag");
            this.Property(t => t.IsPanic).HasColumnName("IsPanic");
            this.Property(t => t.IsDalta).HasColumnName("IsDalta");
            this.Property(t => t.DalAbsolute).HasColumnName("DalAbsolute");
            this.Property(t => t.DalPercent).HasColumnName("DalPercent");
            this.Property(t => t.LowValue).HasColumnName("LowValue");
            this.Property(t => t.HighValue).HasColumnName("HighValue");
            this.Property(t => t.PanicLow).HasColumnName("PanicLow");
            this.Property(t => t.PanicHigh).HasColumnName("PanicHigh");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.IsReport).HasColumnName("IsReport");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ReportOperTime).HasColumnName("ReportOperTime");
            this.Property(t => t.ReportOperId).HasColumnName("ReportOperId");
            this.Property(t => t.ReportOperName).HasColumnName("ReportOperName");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.IsPositive).HasColumnName("IsPositive");
        }
    }
}
