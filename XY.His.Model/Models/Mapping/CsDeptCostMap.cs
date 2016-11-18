using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsDeptCostMap : EntityTypeConfiguration<CsDeptCost>
    {
        public CsDeptCostMap()
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
            this.ToTable("CsDeptCost");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.CostSubjId).HasColumnName("CostSubjId");
            this.Property(t => t.TotAmount).HasColumnName("TotAmount");
            this.Property(t => t.PlanAmount).HasColumnName("PlanAmount");
            this.Property(t => t.PrimeCost).HasColumnName("PrimeCost");
            this.Property(t => t.ApportCost1).HasColumnName("ApportCost1");
            this.Property(t => t.ApportCost2).HasColumnName("ApportCost2");
            this.Property(t => t.ApportCost3).HasColumnName("ApportCost3");
            this.Property(t => t.ApportCost4).HasColumnName("ApportCost4");
            this.Property(t => t.ApportCostSend).HasColumnName("ApportCostSend");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.CsDeptCosts)
                .HasForeignKey(d => d.LocId);
            this.HasOptional(t => t.CsCostSubj)
                .WithMany(t => t.CsDeptCosts)
                .HasForeignKey(d => d.CostSubjId);

        }
    }
}
