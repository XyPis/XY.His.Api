using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdCancerMap : EntityTypeConfiguration<RdCancer>
    {
        public RdCancerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.PathologyType)
                .HasMaxLength(50);

            this.Property(t => t.DeadCause)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.F2)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.F3)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.F4)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.ReportUnit)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("RdCancer");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsCardType).HasColumnName("LsCardType");
            this.Property(t => t.LsCensus).HasColumnName("LsCensus");
            this.Property(t => t.IllId).HasColumnName("IllId");
            this.Property(t => t.LsIllBase).HasColumnName("LsIllBase");
            this.Property(t => t.DiagDate).HasColumnName("DiagDate");
            this.Property(t => t.PathologyType).HasColumnName("PathologyType");
            this.Property(t => t.FormerlyIllness).HasColumnName("FormerlyIllness");
            this.Property(t => t.YDiagDate).HasColumnName("YDiagDate");
            this.Property(t => t.DeadDate).HasColumnName("DeadDate");
            this.Property(t => t.DeadCause).HasColumnName("DeadCause");
            this.Property(t => t.ICDId).HasColumnName("ICDId");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReciOperId).HasColumnName("ReciOperId");
            this.Property(t => t.ReportUnit).HasColumnName("ReportUnit");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdCancers)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.RdCancers)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
