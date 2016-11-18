using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuInvoiceMap : EntityTypeConfiguration<OuInvoice>
    {
        public OuInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.TallyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

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
                .HasMaxLength(500);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AddFee).HasColumnName("AddFee");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.FeeMainId).HasColumnName("FeeMainId");
            this.Property(t => t.FeeSubId).HasColumnName("FeeSubId");
            this.Property(t => t.TallyTime).HasColumnName("TallyTime");
            this.Property(t => t.CancelTallyTime).HasColumnName("CancelTallyTime");
            this.Property(t => t.ReAmount).HasColumnName("ReAmount");
            this.Property(t => t.ReAmountDate).HasColumnName("ReAmountDate");
            this.Property(t => t.ReAmountMemo).HasColumnName("ReAmountMemo");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.YbIllId).HasColumnName("YbIllId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CancelCheckTime).HasColumnName("CancelCheckTime");
            this.Property(t => t.DocLocId).HasColumnName("DocLocId");

            // Relationships
            this.HasOptional(t => t.BsFeeType)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.FeeMainId);
            this.HasOptional(t => t.BsFeeTypeSub)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.FeeSubId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.BsPatType)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.PatTypeId);
            this.HasOptional(t => t.BsPatTypeYbIll)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.YbIllId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OuInvoices)
                .HasForeignKey(d => d.MzRegId);
            this.HasOptional(t => t.OuInvoice2)
                .WithMany(t => t.OuInvoice1)
                .HasForeignKey(d => d.InvoLastId);

        }
    }
}
