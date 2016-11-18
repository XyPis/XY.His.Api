using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NrPlanMap : EntityTypeConfiguration<NrPlan>
    {
        public NrPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            this.Property(t => t.Target)
                .HasMaxLength(500);

            this.Property(t => t.Measure)
                .HasMaxLength(500);

            this.Property(t => t.BasisOf)
                .HasMaxLength(500);

            this.Property(t => t.Evaluate)
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
            this.ToTable("NrPlan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.Target).HasColumnName("Target");
            this.Property(t => t.Measure).HasColumnName("Measure");
            this.Property(t => t.BasisOf).HasColumnName("BasisOf");
            this.Property(t => t.Evaluate).HasColumnName("Evaluate");
            this.Property(t => t.EvalOperId).HasColumnName("EvalOperId");
            this.Property(t => t.EvalTime).HasColumnName("EvalTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.NrPlans)
                .HasForeignKey(d => d.IcdId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.NrPlans)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.NrPlans)
                .HasForeignKey(d => d.HospId);

        }
    }
}
