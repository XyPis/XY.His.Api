using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VWRequestBillBackReqMap : EntityTypeConfiguration<VWRequestBillBackReq>
    {
        public VWRequestBillBackReqMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoomName, t.DoctorId, t.PatientName, t.SexName, t.GroupNum, t.LsMarkType, t.RoomId, t.Dosage, t.ForDate, t.Totality, t.ListNum, t.RequestId, t.HospId, t.IsIssued, t.ReqBackTotality, t.IsConfirm, t.IsPrint, t.UnitReq, t.AdviceId, t.ItemId, t.ID, t.LsSendStatus, t.ReqTime, t.ReqOperId, t.RequestNo, t.ItemCode, t.PriceIn, t.HospNo, t.ReqOperName, t.ReqLocationId, t.ReqLocationName, t.BackTotality });

            // Properties
            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.UnitInName)
                .HasMaxLength(50);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReqBackTotality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitReq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSendStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReqOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequestNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.ReqOperName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ReqLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReqLocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.BackTotality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VWRequestBillBackReq");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.UnitInName).HasColumnName("UnitInName");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.ReqBackTotality).HasColumnName("ReqBackTotality");
            this.Property(t => t.IsBackReq).HasColumnName("IsBackReq");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
            this.Property(t => t.ConfirmOperId).HasColumnName("ConfirmOperId");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UnitTake).HasColumnName("UnitTake");
            this.Property(t => t.UnitReq).HasColumnName("UnitReq");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsSendStatus).HasColumnName("LsSendStatus");
            this.Property(t => t.ReqTime).HasColumnName("ReqTime");
            this.Property(t => t.ReqOperId).HasColumnName("ReqOperId");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.ReqOperName).HasColumnName("ReqOperName");
            this.Property(t => t.ReqLocationId).HasColumnName("ReqLocationId");
            this.Property(t => t.ReqLocationName).HasColumnName("ReqLocationName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ReqBackId).HasColumnName("ReqBackId");
            this.Property(t => t.BackTotality).HasColumnName("BackTotality");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
        }
    }
}
