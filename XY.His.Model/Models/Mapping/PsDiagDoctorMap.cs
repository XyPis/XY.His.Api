using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PsDiagDoctorMap : EntityTypeConfiguration<PsDiagDoctor>
    {
        public PsDiagDoctorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Answer)
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
            this.ToTable("PsDiagDoctors");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.PsDiagDoctors)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.PsDiagDoctors)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.PsDiagMeeting)
                .WithMany(t => t.PsDiagDoctors)
                .HasForeignKey(d => d.ApplyId);

        }
    }
}
