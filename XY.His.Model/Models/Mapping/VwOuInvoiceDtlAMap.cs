using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuInvoiceDtlAMap : EntityTypeConfiguration<VwOuInvoiceDtlA>
    {
        public VwOuInvoiceDtlAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.DiscSelf, t.Price, t.DiscDiag, t.Totality, t.UnitId, t.Amount, t.AmountFact, t.AmountSelf, t.AmountTally, t.ExecLocId, t.DoctorId, t.LsPerform, t.IsModiDisc, t.LimitFee, t.FeeId, t.InvItemId, t.InvoId, t.InvoNo, t.MzRegId, t.InvoTime, t.TallyNo, t.OperId, t.OperTime, t.IsCancel });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsGroupTypeName)
                .HasMaxLength(8);

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

            this.Property(t => t.OrderLocationName)
                .HasMaxLength(30);

            this.Property(t => t.DiscSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitIdName)
                .HasMaxLength(50);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountFact)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountTally)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerformName)
                .HasMaxLength(4);

            this.Property(t => t.LimitGroupName)
                .HasMaxLength(50);

            this.Property(t => t.LimitFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvItemName)
                .HasMaxLength(50);

            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeetyName)
                .HasMaxLength(50);

            this.Property(t => t.FeeHsName)
                .HasMaxLength(50);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.TallyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .HasMaxLength(13);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.CancelOperName)
                .HasMaxLength(30);

            this.Property(t => t.XdRpName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwOuInvoiceDtlA");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsGroupType).HasColumnName("LsGroupType");
            this.Property(t => t.LsGroupTypeName).HasColumnName("LsGroupTypeName");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.GroupMainId).HasColumnName("GroupMainId");
            this.Property(t => t.GroupMainName).HasColumnName("GroupMainName");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.GroupSubName).HasColumnName("GroupSubName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.OrderLocationName).HasColumnName("OrderLocationName");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.IsNew).HasColumnName("IsNew");
            this.Property(t => t.IsRpForbid).HasColumnName("IsRpForbid");
            this.Property(t => t.IsChildAdd).HasColumnName("IsChildAdd");
            this.Property(t => t.IsBedFee).HasColumnName("IsBedFee");
            this.Property(t => t.IsOpsAdd).HasColumnName("IsOpsAdd");
            this.Property(t => t.DiscSelf).HasColumnName("DiscSelf");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UnitIdName).HasColumnName("UnitIdName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountFact).HasColumnName("AmountFact");
            this.Property(t => t.AmountSelf).HasColumnName("AmountSelf");
            this.Property(t => t.AmountTally).HasColumnName("AmountTally");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.LsPerformName).HasColumnName("LsPerformName");
            this.Property(t => t.IsModiDisc).HasColumnName("IsModiDisc");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.LimitGroupName).HasColumnName("LimitGroupName");
            this.Property(t => t.LimitFee).HasColumnName("LimitFee");
            this.Property(t => t.InvItemName).HasColumnName("InvItemName");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.FeetyName).HasColumnName("FeetyName");
            this.Property(t => t.FeeHsId).HasColumnName("FeeHsId");
            this.Property(t => t.FeeHsName).HasColumnName("FeeHsName");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.LsGFPatTypeName).HasColumnName("LsGFPatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelOperName).HasColumnName("CancelOperName");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.XdRpName).HasColumnName("XdRpName");
            this.Property(t => t.RecipeItemId).HasColumnName("RecipeItemId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
        }
    }
}
