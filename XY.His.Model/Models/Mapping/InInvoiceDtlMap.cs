using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InInvoiceDtlMap : EntityTypeConfiguration<InInvoiceDtl>
    {
        public InInvoiceDtlMap()
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

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(50);

            this.Property(t => t.F7)
                .HasMaxLength(50);

            this.Property(t => t.F8)
                .HasMaxLength(50);

            this.Property(t => t.Urgent)
                .HasMaxLength(20);

            this.Property(t => t.ReservedField)
                .HasMaxLength(50);

            this.Property(t => t.ReservedField2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InInvoiceDtl");
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
            this.Property(t => t.MainDoctorId).HasColumnName("MainDoctorId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.OuInvoId).HasColumnName("OuInvoId");
            this.Property(t => t.Urgent).HasColumnName("Urgent");
            this.Property(t => t.ReservedField).HasColumnName("ReservedField");
            this.Property(t => t.ReservedField2).HasColumnName("ReservedField2");
            this.Property(t => t.PriceIn1).HasColumnName("PriceIn1");
            this.Property(t => t.PriceIn2).HasColumnName("PriceIn2");
            this.Property(t => t.LsPriceState).HasColumnName("LsPriceState");
            this.Property(t => t.DocLocId).HasColumnName("DocLocId");
            this.Property(t => t.ExecDoctorId).HasColumnName("ExecDoctorId");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsHsFeety)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.FeeHsId);
            this.HasRequired(t => t.BsInvInItem)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.InvItemId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLimitGroup)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.LimitGroupId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.ExecLocId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.InInvoiceDtls1)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.BsZyFeety)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.FeeId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InInvoice)
                .WithMany(t => t.InInvoiceDtls)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
