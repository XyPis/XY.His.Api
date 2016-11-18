using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsDeptCostParaMap : EntityTypeConfiguration<CsDeptCostPara>
    {
        public CsDeptCostParaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ToLocIds)
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
            this.ToTable("CsDeptCostPara");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.CostSubjId).HasColumnName("CostSubjId");
            this.Property(t => t.LsAppPara).HasColumnName("LsAppPara");
            this.Property(t => t.ToLocIds).HasColumnName("ToLocIds");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.CsDeptCostParas)
                .HasForeignKey(d => d.LocId);
            this.HasRequired(t => t.CsCostSubj)
                .WithMany(t => t.CsDeptCostParas)
                .HasForeignKey(d => d.CostSubjId);

        }
    }
}
