using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.IN.Mapping
{
    public class InPatFeesListMap : EntityTypeConfiguration<InPatFeesList>
    {
        public InPatFeesListMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            this.Property(t => t.InPatNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InPatFeesList");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BedID).HasColumnName("BedID");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.PatTypeID).HasColumnName("PatTypeID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.Deposit).HasColumnName("Deposit");
            this.Property(t => t.NotPay).HasColumnName("NotPay");
            this.Property(t => t.HasPay).HasColumnName("HasPay");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.AmountNoPay).HasColumnName("AmountNoPay");
            this.Property(t => t.AmountPayNoPay).HasColumnName("AmountPayNoPay");
            this.Property(t => t.DepositNoPay).HasColumnName("DepositNoPay");
            this.Property(t => t.DepositMz).HasColumnName("DepositMz");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.AllFactGet).HasColumnName("AllFactGet");
            this.Property(t => t.YPAmount).HasColumnName("YPAmount");
            this.Property(t => t.YPBL).HasColumnName("YPBL");

            // Relationships            

        }
    }
}
