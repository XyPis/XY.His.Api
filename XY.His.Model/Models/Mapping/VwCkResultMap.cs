using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkResultMap : EntityTypeConfiguration<VwCkResult>
    {
        public VwCkResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CheckId, t.TestId, t.SexName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientNo)
                .HasMaxLength(19);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.CheckId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShortName)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.TestTypeName)
                .HasMaxLength(30);

            this.Property(t => t.TestGroupName)
                .HasMaxLength(50);

            this.Property(t => t.UseRange)
                .HasMaxLength(500);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.Format)
                .HasMaxLength(50);

            this.Property(t => t.PrintHigh)
                .HasMaxLength(50);

            this.Property(t => t.PrintLow)
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .HasMaxLength(100);

            this.Property(t => t.LastResult)
                .HasMaxLength(100);

            this.Property(t => t.ReportBy)
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.CheckNo)
                .HasMaxLength(20);

            this.Property(t => t.CompanyName)
                .HasMaxLength(30);

            this.Property(t => t.CkeckNo)
                .HasMaxLength(50);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.HighLow)
                .HasMaxLength(2);

            this.Property(t => t.IsDangerous)
                .HasMaxLength(2);

            this.Property(t => t.Compare)
                .HasMaxLength(2);

            this.Property(t => t.NormalRange)
                .HasMaxLength(63);

            this.Property(t => t.MarriageName)
                .HasMaxLength(4);

            this.Property(t => t.AddressHome)
                .HasMaxLength(100);

            this.Property(t => t.PhotoFolder)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwCkResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatientNo).HasColumnName("PatientNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsTestType).HasColumnName("LsTestType");
            this.Property(t => t.TestTypeId).HasColumnName("TestTypeId");
            this.Property(t => t.TestTypeName).HasColumnName("TestTypeName");
            this.Property(t => t.TestGroupId).HasColumnName("TestGroupId");
            this.Property(t => t.TestGroupName).HasColumnName("TestGroupName");
            this.Property(t => t.IsZero).HasColumnName("IsZero");
            this.Property(t => t.LsGroup).HasColumnName("LsGroup");
            this.Property(t => t.IsReport).HasColumnName("IsReport");
            this.Property(t => t.UseRange).HasColumnName("UseRange");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.LimitHigh).HasColumnName("LimitHigh");
            this.Property(t => t.LimitLow).HasColumnName("LimitLow");
            this.Property(t => t.PrintHigh).HasColumnName("PrintHigh");
            this.Property(t => t.PrintLow).HasColumnName("PrintLow");
            this.Property(t => t.DefaultDalAbsolute).HasColumnName("DefaultDalAbsolute");
            this.Property(t => t.DefaultDalPercent).HasColumnName("DefaultDalPercent");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsDisplay).HasColumnName("IsDisplay");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.LastResult).HasColumnName("LastResult");
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
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.ReportBy).HasColumnName("ReportBy");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CompanyCkeckId).HasColumnName("CompanyCkeckId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CkeckDate).HasColumnName("CkeckDate");
            this.Property(t => t.CkeckNo).HasColumnName("CkeckNo");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.HighLow).HasColumnName("HighLow");
            this.Property(t => t.IsDangerous).HasColumnName("IsDangerous");
            this.Property(t => t.Compare).HasColumnName("Compare");
            this.Property(t => t.NormalRange).HasColumnName("NormalRange");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.MarriageName).HasColumnName("MarriageName");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PhotoFolder).HasColumnName("PhotoFolder");
        }
    }
}
