using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdFollowMap : EntityTypeConfiguration<RdFollow>
    {
        public RdFollowMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.VisitMan)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Purpose)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Process)
                .HasMaxLength(1000);

            this.Property(t => t.Result)
                .HasMaxLength(1000);

            this.Property(t => t.Other)
                .HasMaxLength(1000);

            this.Property(t => t.SumUp)
                .HasMaxLength(1000);

            this.Property(t => t.Memo)
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
            this.ToTable("RdFollow");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.VisitMan).HasColumnName("VisitMan");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.LsVisitType).HasColumnName("LsVisitType");
            this.Property(t => t.IsVisited).HasColumnName("IsVisited");
            this.Property(t => t.Process).HasColumnName("Process");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Other).HasColumnName("Other");
            this.Property(t => t.SumUp).HasColumnName("SumUp");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.RdFollows)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdFollows)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RdFollows)
                .HasForeignKey(d => d.OperID);

        }
    }
}
