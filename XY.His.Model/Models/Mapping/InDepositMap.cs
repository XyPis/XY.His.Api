using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDepositMap : EntityTypeConfiguration<InDeposit>
    {
        public InDepositMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .IsRequired()
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
            this.ToTable("InDeposit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.IsFirst).HasColumnName("IsFirst");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.LsCancelType).HasColumnName("LsCancelType");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CancelCheckTime).HasColumnName("CancelCheckTime");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InDeposits)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.InDeposits1)
                .HasForeignKey(d => d.CancelOperId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InDeposits)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InInvoice)
                .WithMany(t => t.InDeposits)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
