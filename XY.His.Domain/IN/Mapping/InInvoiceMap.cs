using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.IN.Mapping
{
    public class InInvoiceMap : EntityTypeConfiguration<InInvoice>
    {
        public InInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .HasMaxLength(20);

            this.Property(t => t.TallyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.ReAmountMemo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.LsPayType).HasColumnName("LsPayType");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.ChargeDays).HasColumnName("ChargeDays");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.Deposit).HasColumnName("Deposit");
            this.Property(t => t.Complement).HasColumnName("Complement");
            this.Property(t => t.Arrearage).HasColumnName("Arrearage");
            this.Property(t => t.AddFee).HasColumnName("AddFee");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.YbIllId).HasColumnName("YbIllId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CancelCheckTime).HasColumnName("CancelCheckTime");
            this.Property(t => t.ReAmount).HasColumnName("ReAmount");
            this.Property(t => t.ReAmountDate).HasColumnName("ReAmountDate");
            this.Property(t => t.ReAmountMemo).HasColumnName("ReAmountMemo");

            // Relationships
        }
    }
}
