using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInTempDrugApplyMap : EntityTypeConfiguration<VwInTempDrugApply>
    {
        public VwInTempDrugApplyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HospNO, t.AdviceTime, t.HospID, t.GroupNum, t.ItemName, t.Spec, t.Dosage, t.UnitName, t.AdviceID, t.DoctorID, t.PatientName, t.LocationID, t.ItemID, t.ItemCode, t.Totality, t.UnitInID, t.IsAttach, t.TOTALRoom, t.UnitKC, t.UnitRoomName, t.BedName, t.Memo, t.LsExecLoc });

            // Properties
            this.Property(t => t.HospNO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.HospID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AdviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitInID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TOTALRoom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitKC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitRoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BedName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FrequencyPrintName)
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.UsagePrintName)
                .HasMaxLength(50);

            this.Property(t => t.LsExecLoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwInTempDrugApply");
            this.Property(t => t.HospNO).HasColumnName("HospNO");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.AdviceID).HasColumnName("AdviceID");
            this.Property(t => t.UnitTakeID).HasColumnName("UnitTakeID");
            this.Property(t => t.FrequencyID).HasColumnName("FrequencyID");
            this.Property(t => t.UsageID).HasColumnName("UsageID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitInID).HasColumnName("UnitInID");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.TOTALRoom).HasColumnName("TOTALRoom");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.UnitKC).HasColumnName("UnitKC");
            this.Property(t => t.UnitRoomName).HasColumnName("UnitRoomName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.FrequencyPrintName).HasColumnName("FrequencyPrintName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.UsagePrintName).HasColumnName("UsagePrintName");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.requestid).HasColumnName("requestid");
            this.Property(t => t.ForToday).HasColumnName("ForToday");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.StoreNum).HasColumnName("StoreNum");
            this.Property(t => t.BackNum).HasColumnName("BackNum");
            this.Property(t => t.BackedNum).HasColumnName("BackedNum");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.IsBackReq).HasColumnName("IsBackReq");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.IsMinus).HasColumnName("IsMinus");
        }
    }
}
