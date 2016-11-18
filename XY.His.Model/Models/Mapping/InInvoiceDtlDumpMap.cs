using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InInvoiceDtlDumpMap : EntityTypeConfiguration<InInvoiceDtlDump>
    {
        public InInvoiceDtlDumpMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

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

            this.Property(t => t.ReservedField)
                .HasMaxLength(50);

            this.Property(t => t.ReservedField2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Urgent)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InInvoiceDtlDump");
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
            this.Property(t => t.AuthDtlId).HasColumnName("AuthDtlId");
            this.Property(t => t.CheckOperId).HasColumnName("CheckOperId");
            this.Property(t => t.ReservedField).HasColumnName("ReservedField");
            this.Property(t => t.ReservedField2).HasColumnName("ReservedField2");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CheckOperId1).HasColumnName("CheckOperId1");
            this.Property(t => t.DeleteTime).HasColumnName("DeleteTime");
            this.Property(t => t.DeleteOperId).HasColumnName("DeleteOperId");
            this.Property(t => t.AuthDtlId1).HasColumnName("AuthDtlId1");
            this.Property(t => t.PriceIn1).HasColumnName("PriceIn1");
            this.Property(t => t.PriceIn2).HasColumnName("PriceIn2");
            this.Property(t => t.LsPriceState).HasColumnName("LsPriceState");
            this.Property(t => t.Urgent).HasColumnName("Urgent");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsHsFeety)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.FeeHsId);
            this.HasRequired(t => t.BsInvInItem)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.InvItemId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLimitGroup)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.LimitGroupId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.ExecLocId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.InInvoiceDtlDumps1)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.BsZyFeety)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.FeeId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InInvoice)
                .WithMany(t => t.InInvoiceDtlDumps)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
