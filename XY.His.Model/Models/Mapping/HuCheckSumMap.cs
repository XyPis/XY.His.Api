using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuCheckSumMap : EntityTypeConfiguration<HuCheckSum>
    {
        public HuCheckSumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SumFor)
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
            this.ToTable("HuCheckSum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.SumFor).HasColumnName("SumFor");
            this.Property(t => t.BuyIn).HasColumnName("BuyIn");
            this.Property(t => t.BackIn).HasColumnName("BackIn");
            this.Property(t => t.PyIn).HasColumnName("PyIn");
            this.Property(t => t.OtherIn).HasColumnName("OtherIn");
            this.Property(t => t.DeptOut).HasColumnName("DeptOut");
            this.Property(t => t.SaleOut).HasColumnName("SaleOut");
            this.Property(t => t.BackOut).HasColumnName("BackOut");
            this.Property(t => t.PkOut).HasColumnName("PkOut");
            this.Property(t => t.LoseOut).HasColumnName("LoseOut");
            this.Property(t => t.AdjustAmouUp).HasColumnName("AdjustAmouUp");
            this.Property(t => t.AdjustAmouDn).HasColumnName("AdjustAmouDn");
            this.Property(t => t.CheckAmou).HasColumnName("CheckAmou");
            this.Property(t => t.BalanceAmou).HasColumnName("BalanceAmou");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.HuCheck)
                .WithMany(t => t.HuCheckSums)
                .HasForeignKey(d => d.BillId);

        }
    }
}
