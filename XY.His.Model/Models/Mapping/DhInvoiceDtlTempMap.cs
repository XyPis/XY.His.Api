using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DhInvoiceDtlTempMap : EntityTypeConfiguration<DhInvoiceDtlTemp>
    {
        public DhInvoiceDtlTempMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .HasMaxLength(20);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.LimitName)
                .HasMaxLength(50);

            this.Property(t => t.FeetyName)
                .HasMaxLength(50);

            this.Property(t => t.InvFeetyName)
                .HasMaxLength(50);

            this.Property(t => t.AccountName)
                .HasMaxLength(50);

            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            this.Property(t => t.Location1)
                .HasMaxLength(50);

            this.Property(t => t.Location2)
                .HasMaxLength(50);

            this.Property(t => t.Location3)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(50);

            this.Property(t => t.DocLevel)
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
            this.ToTable("DhInvoiceDtlTemp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LimitName).HasColumnName("LimitName");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.FeetyName).HasColumnName("FeetyName");
            this.Property(t => t.InvFeetyName).HasColumnName("InvFeetyName");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Location1).HasColumnName("Location1");
            this.Property(t => t.Location2).HasColumnName("Location2");
            this.Property(t => t.Location3).HasColumnName("Location3");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.DocLevel).HasColumnName("DocLevel");
            this.Property(t => t.RegOperTime).HasColumnName("RegOperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
