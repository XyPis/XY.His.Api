using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkBldApplyMap : EntityTypeConfiguration<CkBldApply>
    {
        public CkBldApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecNo)
                .HasMaxLength(12);

            this.Property(t => t.PatBloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PatRHD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Illness)
                .HasMaxLength(50);

            this.Property(t => t.Purpose)
                .HasMaxLength(500);

            this.Property(t => t.HstyBlood)
                .HasMaxLength(500);

            this.Property(t => t.HstyReact)
                .HasMaxLength(500);

            this.Property(t => t.HstyTest)
                .HasMaxLength(500);

            this.Property(t => t.HstyPregnancy)
                .HasMaxLength(500);

            this.Property(t => t.HstyBirth)
                .HasMaxLength(500);

            this.Property(t => t.TestResult)
                .HasMaxLength(500);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.SpecHandle)
                .HasMaxLength(500);

            this.Property(t => t.BloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Replace)
                .HasMaxLength(50);

            this.Property(t => t.LabNum)
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkBldApply");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.PatBloodGroup).HasColumnName("PatBloodGroup");
            this.Property(t => t.PatRHD).HasColumnName("PatRHD");
            this.Property(t => t.Illness).HasColumnName("Illness");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.HstyBlood).HasColumnName("HstyBlood");
            this.Property(t => t.HstyReact).HasColumnName("HstyReact");
            this.Property(t => t.HstyTest).HasColumnName("HstyTest");
            this.Property(t => t.HstyPregnancy).HasColumnName("HstyPregnancy");
            this.Property(t => t.HstyBirth).HasColumnName("HstyBirth");
            this.Property(t => t.TestResult).HasColumnName("TestResult");
            this.Property(t => t.BloodTypeId).HasColumnName("BloodTypeId");
            this.Property(t => t.Vollume).HasColumnName("Vollume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.PreOps).HasColumnName("PreOps");
            this.Property(t => t.SpecHandle).HasColumnName("SpecHandle");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.Replace).HasColumnName("Replace");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.IsAgree).HasColumnName("IsAgree");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.CkBloodType)
                .WithMany(t => t.CkBldApplies)
                .HasForeignKey(d => d.BloodTypeId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.CkBldApplies)
                .HasForeignKey(d => d.HospId);

        }
    }
}
