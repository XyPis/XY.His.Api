using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdCurePlanMap : EntityTypeConfiguration<RdCurePlan>
    {
        public RdCurePlanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Illness)
                .HasMaxLength(50);

            this.Property(t => t.CureItem)
                .HasMaxLength(500);

            this.Property(t => t.CurePlan)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("RdCurePlan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Illness).HasColumnName("Illness");
            this.Property(t => t.CureItem).HasColumnName("CureItem");
            this.Property(t => t.CurePlan).HasColumnName("CurePlan");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.RdCurePlans)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdCurePlans)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RdCurePlans)
                .HasForeignKey(d => d.OperID);

        }
    }
}
