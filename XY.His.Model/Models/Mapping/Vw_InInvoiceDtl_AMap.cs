using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InInvoiceDtl_AMap : EntityTypeConfiguration<Vw_InInvoiceDtl_A>
    {
        public Vw_InInvoiceDtl_AMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.HospId, t.ItemId, t.RegOperTime, t.RegOperId, t.LocationId, t.AdviceId, t.LsMarkType, t.Totality, t.PriceIn, t.UnitId, t.IsPay, t.DiscIn, t.DiscSelf, t.Amount, t.AmountFact, t.AmountSelf, t.AmountTally, t.AmountPay, t.LsPerform, t.IsModiDisc, t.DoctorId, t.ExecOperId, t.ExecLocId, t.InvItemId, t.FeeId, t.OperTime, t.OperId, t.IsCancel, t.IsManual });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountFact)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountTally)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.HostName)
                .HasMaxLength(50);

            this.Property(t => t.RegDate)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.AdviceName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_InInvoiceDtl_A");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.RegOperTime).HasColumnName("RegOperTime");
            this.Property(t => t.RegOperId).HasColumnName("RegOperId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.DiscSelf).HasColumnName("DiscSelf");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountFact).HasColumnName("AmountFact");
            this.Property(t => t.AmountSelf).HasColumnName("AmountSelf");
            this.Property(t => t.AmountTally).HasColumnName("AmountTally");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.IsModiDisc).HasColumnName("IsModiDisc");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.LimitFee).HasColumnName("LimitFee");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.ExecOperId).HasColumnName("ExecOperId");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.FeeHsId).HasColumnName("FeeHsId");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelId).HasColumnName("CancelId");
            this.Property(t => t.IsManual).HasColumnName("IsManual");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HostName).HasColumnName("HostName");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.GroupItemId).HasColumnName("GroupItemId");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.AdviceName).HasColumnName("AdviceName");
        }
    }
}
