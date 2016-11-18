using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InInvoYBMap : EntityTypeConfiguration<InInvoYB>
    {
        public InInvoYBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            this.Property(t => t.AccountAttribute)
                .HasMaxLength(50);

            this.Property(t => t.MedicalNo)
                .HasMaxLength(50);

            this.Property(t => t.F5)
                .HasMaxLength(50);

            this.Property(t => t.F6)
                .HasMaxLength(500);

            this.Property(t => t.F7)
                .HasMaxLength(500);

            this.Property(t => t.F8)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InInvoYB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.FactYP).HasColumnName("FactYP");
            this.Property(t => t.FactJZ).HasColumnName("FactJZ");
            this.Property(t => t.AllFactYP).HasColumnName("AllFactYP");
            this.Property(t => t.AllFactJZ).HasColumnName("AllFactJZ");
            this.Property(t => t.OtherFact).HasColumnName("OtherFact");
            this.Property(t => t.YBDisc).HasColumnName("YBDisc");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.UnderLine).HasColumnName("UnderLine");
            this.Property(t => t.InsuranceB1).HasColumnName("InsuranceB1");
            this.Property(t => t.InsuranceB2).HasColumnName("InsuranceB2");
            this.Property(t => t.InsuranceB3).HasColumnName("InsuranceB3");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.SelfPayDisc).HasColumnName("SelfPayDisc");
            this.Property(t => t.SelfPayB1).HasColumnName("SelfPayB1");
            this.Property(t => t.SelfPayB2).HasColumnName("SelfPayB2");
            this.Property(t => t.SelfPayB3).HasColumnName("SelfPayB3");
            this.Property(t => t.OutTopSelfFee).HasColumnName("OutTopSelfFee");
            this.Property(t => t.SelfFee).HasColumnName("SelfFee");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.BchzylbxAmount).HasColumnName("BchzylbxAmount");
            this.Property(t => t.AccountAttribute).HasColumnName("AccountAttribute");
            this.Property(t => t.BcProportion).HasColumnName("BcProportion");
            this.Property(t => t.FdAmount).HasColumnName("FdAmount");
            this.Property(t => t.MedicalNo).HasColumnName("MedicalNo");
            this.Property(t => t.NdybcAmount).HasColumnName("NdybcAmount");
            this.Property(t => t.TgProportion).HasColumnName("TgProportion");
            this.Property(t => t.WbhProportion).HasColumnName("WbhProportion");
            this.Property(t => t.ZyyProportion).HasColumnName("ZyyProportion");
            this.Property(t => t.ZzProportion).HasColumnName("ZzProportion");
            this.Property(t => t.KbcAmount).HasColumnName("KbcAmount");
            this.Property(t => t.KbcA1).HasColumnName("KbcA1");
            this.Property(t => t.KbcA2).HasColumnName("KbcA2");
            this.Property(t => t.KbcA3).HasColumnName("KbcA3");
            this.Property(t => t.KbcA4).HasColumnName("KbcA4");
            this.Property(t => t.KbcA5).HasColumnName("KbcA5");
            this.Property(t => t.KbcA6).HasColumnName("KbcA6");
            this.Property(t => t.KbcA12).HasColumnName("KbcA12");
            this.Property(t => t.KbcA13).HasColumnName("KbcA13");
            this.Property(t => t.KbcA16).HasColumnName("KbcA16");
            this.Property(t => t.KbcA17).HasColumnName("KbcA17");
            this.Property(t => t.KbcA18).HasColumnName("KbcA18");
            this.Property(t => t.KbcA19).HasColumnName("KbcA19");
            this.Property(t => t.KbcA20).HasColumnName("KbcA20");
            this.Property(t => t.SjbcA1).HasColumnName("SjbcA1");
            this.Property(t => t.SjbcA2).HasColumnName("SjbcA2");
            this.Property(t => t.SjbcA3).HasColumnName("SjbcA3");
            this.Property(t => t.SjbcA4).HasColumnName("SjbcA4");
            this.Property(t => t.SjbcA5).HasColumnName("SjbcA5");
            this.Property(t => t.SjbcA6).HasColumnName("SjbcA6");
            this.Property(t => t.SjbcA12).HasColumnName("SjbcA12");
            this.Property(t => t.SjbcA13).HasColumnName("SjbcA13");
            this.Property(t => t.SjbcA16).HasColumnName("SjbcA16");
            this.Property(t => t.SjbcA17).HasColumnName("SjbcA17");
            this.Property(t => t.SjbcA18).HasColumnName("SjbcA18");
            this.Property(t => t.SjbcA19).HasColumnName("SjbcA19");
            this.Property(t => t.SjbcA20).HasColumnName("SjbcA20");
            this.Property(t => t.OriginalAmount).HasColumnName("OriginalAmount");
            this.Property(t => t.OriginalA1).HasColumnName("OriginalA1");
            this.Property(t => t.OriginalA2).HasColumnName("OriginalA2");
            this.Property(t => t.OriginalA3).HasColumnName("OriginalA3");
            this.Property(t => t.OriginalA4).HasColumnName("OriginalA4");
            this.Property(t => t.OriginalA5).HasColumnName("OriginalA5");
            this.Property(t => t.OriginalA6).HasColumnName("OriginalA6");
            this.Property(t => t.OriginalA12).HasColumnName("OriginalA12");
            this.Property(t => t.OriginalA13).HasColumnName("OriginalA13");
            this.Property(t => t.OriginalA16).HasColumnName("OriginalA16");
            this.Property(t => t.OriginalA17).HasColumnName("OriginalA17");
            this.Property(t => t.OriginalA18).HasColumnName("OriginalA18");
            this.Property(t => t.OriginalA19).HasColumnName("OriginalA19");
            this.Property(t => t.OriginalA20).HasColumnName("OriginalA20");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.InvoYBTime).HasColumnName("InvoYBTime");
        }
    }
}
