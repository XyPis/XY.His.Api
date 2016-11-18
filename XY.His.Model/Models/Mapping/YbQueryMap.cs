using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class YbQueryMap : EntityTypeConfiguration<YbQuery>
    {
        public YbQueryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DesigCode)
                .HasMaxLength(50);

            this.Property(t => t.PersonNum)
                .HasMaxLength(50);

            this.Property(t => t.YbSeq)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.TransType)
                .HasMaxLength(50);

            this.Property(t => t.SerialNum)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveNum)
                .HasMaxLength(50);

            this.Property(t => t.TotalAmount)
                .HasMaxLength(50);

            this.Property(t => t.InsuranceAmount)
                .HasMaxLength(50);

            this.Property(t => t.SuppleAmount)
                .HasMaxLength(50);

            this.Property(t => t.CashPayment)
                .HasMaxLength(50);

            this.Property(t => t.SelfAmount)
                .HasMaxLength(50);

            this.Property(t => t.SomeSelfAmount)
                .HasMaxLength(50);

            this.Property(t => t.EnterCosts)
                .HasMaxLength(50);

            this.Property(t => t.ToPayStandard)
                .HasMaxLength(50);

            this.Property(t => t.IntoCosts)
                .HasMaxLength(50);

            this.Property(t => t.SelfPaid)
                .HasMaxLength(50);

            this.Property(t => t.EnterInsuranceCosts)
                .HasMaxLength(50);

            this.Property(t => t.SuppInsurancePays)
                .HasMaxLength(50);

            this.Property(t => t.LimitSelfPaid)
                .HasMaxLength(50);

            this.Property(t => t.Ntime)
                .HasMaxLength(50);

            this.Property(t => t.DevelopersLogo)
                .HasMaxLength(50);

            this.Property(t => t.SettlementDate)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("YbQuery");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DesigCode).HasColumnName("DesigCode");
            this.Property(t => t.PersonNum).HasColumnName("PersonNum");
            this.Property(t => t.YbSeq).HasColumnName("YbSeq");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.TransType).HasColumnName("TransType");
            this.Property(t => t.SerialNum).HasColumnName("SerialNum");
            this.Property(t => t.ReceiveNum).HasColumnName("ReceiveNum");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.InsuranceAmount).HasColumnName("InsuranceAmount");
            this.Property(t => t.SuppleAmount).HasColumnName("SuppleAmount");
            this.Property(t => t.CashPayment).HasColumnName("CashPayment");
            this.Property(t => t.SelfAmount).HasColumnName("SelfAmount");
            this.Property(t => t.SomeSelfAmount).HasColumnName("SomeSelfAmount");
            this.Property(t => t.EnterCosts).HasColumnName("EnterCosts");
            this.Property(t => t.ToPayStandard).HasColumnName("ToPayStandard");
            this.Property(t => t.IntoCosts).HasColumnName("IntoCosts");
            this.Property(t => t.SelfPaid).HasColumnName("SelfPaid");
            this.Property(t => t.EnterInsuranceCosts).HasColumnName("EnterInsuranceCosts");
            this.Property(t => t.SuppInsurancePays).HasColumnName("SuppInsurancePays");
            this.Property(t => t.LimitSelfPaid).HasColumnName("LimitSelfPaid");
            this.Property(t => t.Ntime).HasColumnName("Ntime");
            this.Property(t => t.DevelopersLogo).HasColumnName("DevelopersLogo");
            this.Property(t => t.SettlementDate).HasColumnName("SettlementDate");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzregId).HasColumnName("MzregId");
            this.Property(t => t.HospId).HasColumnName("HospId");
        }
    }
}
