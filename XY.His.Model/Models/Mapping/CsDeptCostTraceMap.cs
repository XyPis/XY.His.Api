using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsDeptCostTraceMap : EntityTypeConfiguration<CsDeptCostTrace>
    {
        public CsDeptCostTraceMap()
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
            this.ToTable("CsDeptCostTrace");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.CostSubjId).HasColumnName("CostSubjId");
            this.Property(t => t.FromLocId).HasColumnName("FromLocId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Step).HasColumnName("Step");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.CsDeptCostTraces)
                .HasForeignKey(d => d.LocId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.CsDeptCostTraces1)
                .HasForeignKey(d => d.FromLocId);

        }
    }
}
