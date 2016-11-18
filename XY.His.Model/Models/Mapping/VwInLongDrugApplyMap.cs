using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInLongDrugApplyMap : EntityTypeConfiguration<VwInLongDrugApply>
    {
        public VwInLongDrugApplyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InPatNo, t.HospNo, t.HospId, t.GroupNum, t.ItemName, t.Spec, t.ItemID, t.Dosage, t.UnitName, t.AdviceID, t.IsAttach, t.TOTALRoom, t.DoctorId, t.Memo, t.PatientName, t.ItemCode, t.UnitKC, t.UnitRoomName, t.BedName, t.LsExecLoc, t.IsEnd, t.Expr1, t.LocIn, t.OrderBy, t.Sex, t.PatID, t.UnitInId, t.Lsrptype });

            // Properties
            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AdviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TOTALRoom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UnitKC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitRoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BedName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FrequencyPrintName)
                .HasMaxLength(50);

            this.Property(t => t.UsagePrintName)
                .HasMaxLength(50);

            this.Property(t => t.LsExecLoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitInId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Lsrptype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwInLongDrugApply");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.AdviceID).HasColumnName("AdviceID");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.TOTALRoom).HasColumnName("TOTALRoom");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.UnitKC).HasColumnName("UnitKC");
            this.Property(t => t.UnitRoomName).HasColumnName("UnitRoomName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.FrequencyPrintName).HasColumnName("FrequencyPrintName");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.ForToday).HasColumnName("ForToday");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.StoreNum).HasColumnName("StoreNum");
            this.Property(t => t.BackNum).HasColumnName("BackNum");
            this.Property(t => t.BackedNum).HasColumnName("BackedNum");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.IsBackReq).HasColumnName("IsBackReq");
            this.Property(t => t.UsagePrintName).HasColumnName("UsagePrintName");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.IsMinus).HasColumnName("IsMinus");
            this.Property(t => t.FirstDay).HasColumnName("FirstDay");
            this.Property(t => t.LastDay).HasColumnName("LastDay");
            this.Property(t => t.IsEnd).HasColumnName("IsEnd");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.MainDoctorId).HasColumnName("MainDoctorId");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Lsrptype).HasColumnName("Lsrptype");
        }
    }
}
