using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormMap : EntityTypeConfiguration<ElPatForm>
    {
        public ElPatFormMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.RejectReason)
                .HasMaxLength(50);

            this.Property(t => t.InActiveReason)
                .IsRequired()
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
            this.ToTable("ElPatForm");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.RecId).HasColumnName("RecId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthTime).HasColumnName("AuthTime");
            this.Property(t => t.RejectReason).HasColumnName("RejectReason");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsHospital)
                .WithMany(t => t.ElPatForms)
                .HasForeignKey(d => d.HospitalId);
            this.HasOptional(t => t.BsPatient)
                .WithMany(t => t.ElPatForms)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.ElPatForms)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.ElPatRecord)
                .WithMany(t => t.ElPatForms)
                .HasForeignKey(d => d.RecId);
            this.HasRequired(t => t.GblPatientMenu)
                .WithMany(t => t.ElPatForms)
                .HasForeignKey(d => d.PatMenuId);

        }
    }
}
