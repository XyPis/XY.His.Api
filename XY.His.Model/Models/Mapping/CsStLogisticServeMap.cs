using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsStLogisticServeMap : EntityTypeConfiguration<CsStLogisticServe>
    {
        public CsStLogisticServeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YearMonth)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CsStLogisticServe");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.LogisticServeId).HasColumnName("LogisticServeId");
            this.Property(t => t.BenefitLocId).HasColumnName("BenefitLocId");
            this.Property(t => t.ServeLocId).HasColumnName("ServeLocId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Money).HasColumnName("Money");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.InputTime).HasColumnName("InputTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CsLogisticServe)
                .WithMany(t => t.CsStLogisticServes)
                .HasForeignKey(d => d.LogisticServeId);

        }
    }
}
