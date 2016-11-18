using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkBldReactionMap : EntityTypeConfiguration<CkBldReaction>
    {
        public CkBldReactionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecNo)
                .HasMaxLength(12);

            this.Property(t => t.TransType)
                .HasMaxLength(50);

            this.Property(t => t.ClincHandle)
                .HasMaxLength(500);

            this.Property(t => t.TransHandle)
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkBldReaction");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.BloodId).HasColumnName("BloodId");
            this.Property(t => t.TransTime).HasColumnName("TransTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.TransType).HasColumnName("TransType");
            this.Property(t => t.TotalVollume).HasColumnName("TotalVollume");
            this.Property(t => t.ReactTime).HasColumnName("ReactTime");
            this.Property(t => t.LsTransType).HasColumnName("LsTransType");
            this.Property(t => t.ClincHandle).HasColumnName("ClincHandle");
            this.Property(t => t.TransHandle).HasColumnName("TransHandle");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.CkBldReactions)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.CkBldReactions)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.CkBdBank)
                .WithMany(t => t.CkBldReactions)
                .HasForeignKey(d => d.BloodId);
            this.HasRequired(t => t.CkLab)
                .WithMany(t => t.CkBldReactions)
                .HasForeignKey(d => d.LabId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.CkBldReactions)
                .HasForeignKey(d => d.HospId);

        }
    }
}
