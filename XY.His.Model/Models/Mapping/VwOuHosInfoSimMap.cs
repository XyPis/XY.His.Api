using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuHosInfoSimMap : EntityTypeConfiguration<VwOuHosInfoSim>
    {
        public VwOuHosInfoSimMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MzRegNo, t.PatientName, t.PatId, t.CardNo, t.Sex, t.BirthDate, t.BabyMonth, t.RegTime, t.IsPriority, t.RegTypeId, t.RegDept, t.PatTypeId, t.GetTallyType, t.GetTallyTypeName, t.IsInPatient, t.IsLocationDiagSee, t.DiagStatus, t.LineOrder });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.BabyMonth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AgeString)
                .HasMaxLength(50);

            this.Property(t => t.RegLocation)
                .HasMaxLength(100);

            this.Property(t => t.RegTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.RegDept)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.GetTallyType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.GetTallyTypeName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.IsLocationDiagSee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiagStatus)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            this.Property(t => t.LineOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("VwOuHosInfoSim");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BabyMonth).HasColumnName("BabyMonth");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.RegLocation).HasColumnName("RegLocation");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DiagnDept).HasColumnName("DiagnDept");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.GetTallyType).HasColumnName("GetTallyType");
            this.Property(t => t.GetTallyTypeName).HasColumnName("GetTallyTypeName");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.IsInPatient).HasColumnName("IsInPatient");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.IsOuChargeInput).HasColumnName("IsOuChargeInput");
            this.Property(t => t.IsLocationSee).HasColumnName("IsLocationSee");
            this.Property(t => t.IsLocationDiagSee).HasColumnName("IsLocationDiagSee");
            this.Property(t => t.IsDiagnosed).HasColumnName("IsDiagnosed");
            this.Property(t => t.DiagStatus).HasColumnName("DiagStatus");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.TimeSpanId).HasColumnName("TimeSpanId");
            this.Property(t => t.LineOrder).HasColumnName("LineOrder");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
        }
    }
}
