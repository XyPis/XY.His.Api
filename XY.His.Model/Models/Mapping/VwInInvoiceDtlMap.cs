using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInInvoiceDtlMap : EntityTypeConfiguration<VwInInvoiceDtl>
    {
        public VwInInvoiceDtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.LocationId, t.LsMarkType, t.Totality, t.PriceIn, t.UnitId, t.DiscIn, t.DiscSelf, t.IsModiDisc, t.AmountPay, t.AmountSelf, t.AmountFact, t.IsPay, t.IsManual, t.LsPerform, t.IsCancel, t.FeeId, t.InvItemId, t.ExecLocId, t.ExecOperId, t.RegOperTime, t.RegOperId, t.DoctorId, t.HospId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            this.Property(t => t.GroupMainName)
                .HasMaxLength(50);

            this.Property(t => t.GroupSubName)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocName)
                .HasMaxLength(30);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitIdName)
                .HasMaxLength(50);

            this.Property(t => t.DiscIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountFact)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeHsName)
                .HasMaxLength(50);

            this.Property(t => t.FeetyName)
                .HasMaxLength(50);

            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvItemName)
                .HasMaxLength(50);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderLocationName)
                .HasMaxLength(30);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecOperName)
                .HasMaxLength(30);

            this.Property(t => t.ExecOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderDoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LimitGroupName)
                .HasMaxLength(50);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.PatientDoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatientLocationName)
                .HasMaxLength(30);

            this.Property(t => t.HospNo)
                .HasMaxLength(20);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwInInvoiceDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsGroupType).HasColumnName("LsGroupType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.GroupMainId).HasColumnName("GroupMainId");
            this.Property(t => t.GroupMainName).HasColumnName("GroupMainName");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.GroupSubName).HasColumnName("GroupSubName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.IsNew).HasColumnName("IsNew");
            this.Property(t => t.IsRpForbid).HasColumnName("IsRpForbid");
            this.Property(t => t.IsChildAdd).HasColumnName("IsChildAdd");
            this.Property(t => t.IsBedFee).HasColumnName("IsBedFee");
            this.Property(t => t.IsOpsAdd).HasColumnName("IsOpsAdd");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ExecLocName).HasColumnName("ExecLocName");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UnitIdName).HasColumnName("UnitIdName");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.DiscSelf).HasColumnName("DiscSelf");
            this.Property(t => t.IsModiDisc).HasColumnName("IsModiDisc");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AmountTally).HasColumnName("AmountTally");
            this.Property(t => t.AmountSelf).HasColumnName("AmountSelf");
            this.Property(t => t.AmountFact).HasColumnName("AmountFact");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.IsManual).HasColumnName("IsManual");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelId).HasColumnName("CancelId");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.FeeHsName).HasColumnName("FeeHsName");
            this.Property(t => t.FeeHsId).HasColumnName("FeeHsId");
            this.Property(t => t.FeetyName).HasColumnName("FeetyName");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.InvItemName).HasColumnName("InvItemName");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
            this.Property(t => t.OrderLocationName).HasColumnName("OrderLocationName");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.ExecOperName).HasColumnName("ExecOperName");
            this.Property(t => t.ExecOperId).HasColumnName("ExecOperId");
            this.Property(t => t.RegOperTime).HasColumnName("RegOperTime");
            this.Property(t => t.RegOperId).HasColumnName("RegOperId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OrderDoctorName).HasColumnName("OrderDoctorName");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.LimitGroupName).HasColumnName("LimitGroupName");
            this.Property(t => t.LimitFee).HasColumnName("LimitFee");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.PatientDoctorId).HasColumnName("PatientDoctorId");
            this.Property(t => t.PatientDoctorName).HasColumnName("PatientDoctorName");
            this.Property(t => t.PatientLocationId).HasColumnName("PatientLocationId");
            this.Property(t => t.PatientLocationName).HasColumnName("PatientLocationName");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.LsGFPatTypeName).HasColumnName("LsGFPatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.PatientSpecialityId).HasColumnName("PatientSpecialityId");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
        }
    }
}
