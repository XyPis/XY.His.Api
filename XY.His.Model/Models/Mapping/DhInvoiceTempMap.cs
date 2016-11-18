using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DhInvoiceTempMap : EntityTypeConfiguration<DhInvoiceTemp>
    {
        public DhInvoiceTempMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.OperName)
                .HasMaxLength(50);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .HasMaxLength(50);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeCode)
                .HasMaxLength(50);

            this.Property(t => t.PatType1)
                .HasMaxLength(50);

            this.Property(t => t.PatType2)
                .HasMaxLength(50);

            this.Property(t => t.PatType3)
                .HasMaxLength(50);

            this.Property(t => t.ICDCode)
                .HasMaxLength(50);

            this.Property(t => t.Illness)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DhInvoiceTemp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.InDays).HasColumnName("InDays");
            this.Property(t => t.PatTypeCode).HasColumnName("PatTypeCode");
            this.Property(t => t.PatType1).HasColumnName("PatType1");
            this.Property(t => t.PatType2).HasColumnName("PatType2");
            this.Property(t => t.PatType3).HasColumnName("PatType3");
            this.Property(t => t.ICDCode).HasColumnName("ICDCode");
            this.Property(t => t.Illness).HasColumnName("Illness");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
