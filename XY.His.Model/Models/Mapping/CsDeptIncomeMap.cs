using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsDeptIncomeMap : EntityTypeConfiguration<CsDeptIncome>
    {
        public CsDeptIncomeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YearMonth)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.Abstract)
                .HasMaxLength(30);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CsDeptIncome");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.FeeHsId).HasColumnName("FeeHsId");
            this.Property(t => t.OperLocId).HasColumnName("OperLocId");
            this.Property(t => t.ExcLocId).HasColumnName("ExcLocId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Abstract).HasColumnName("Abstract");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsHsFeety)
                .WithMany(t => t.CsDeptIncomes)
                .HasForeignKey(d => d.FeeHsId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.CsDeptIncomes)
                .HasForeignKey(d => d.ExcLocId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.CsDeptIncomes1)
                .HasForeignKey(d => d.OperLocId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.CsDeptIncomes)
                .HasForeignKey(d => d.OperId);

        }
    }
}
