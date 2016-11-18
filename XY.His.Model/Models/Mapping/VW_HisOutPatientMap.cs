using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VW_HisOutPatientMap : EntityTypeConfiguration<VW_HisOutPatient>
    {
        public VW_HisOutPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PatientID, t.PatientName, t.MzRegNo, t.RegTime, t.RegDept, t.Sex, t.SexName, t.IsBaby, t.RegTypeId, t.RoomNo, t.IsPriority, t.IsElder, t.IsFreeReg, t.IsFreeDiag, t.IsInPatient, t.IsPreReg, t.PatId, t.PatTypeId, t.OperId, t.LineOrder });

            // Properties
            this.Property(t => t.PatientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.RegDept)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.RegTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.WorkTypeName)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LineOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VW_HisOutPatient");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.IsElder).HasColumnName("IsElder");
            this.Property(t => t.IsFreeReg).HasColumnName("IsFreeReg");
            this.Property(t => t.IsFreeDiag).HasColumnName("IsFreeDiag");
            this.Property(t => t.IsInPatient).HasColumnName("IsInPatient");
            this.Property(t => t.IsPreReg).HasColumnName("IsPreReg");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.WorkTypeName).HasColumnName("WorkTypeName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.LsGFPatTypeName).HasColumnName("LsGFPatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LineOrder).HasColumnName("LineOrder");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DiagnDept).HasColumnName("DiagnDept");
            this.Property(t => t.F5).HasColumnName("F5");
        }
    }
}
