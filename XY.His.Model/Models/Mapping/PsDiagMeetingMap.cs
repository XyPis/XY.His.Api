using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PsDiagMeetingMap : EntityTypeConfiguration<PsDiagMeeting>
    {
        public PsDiagMeetingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Diagnose)
                .HasMaxLength(1000);

            this.Property(t => t.Clinic)
                .HasMaxLength(2000);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PsDiagMeeting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Clinic).HasColumnName("Clinic");
            this.Property(t => t.IsUrgent).HasColumnName("IsUrgent");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.PsDiagMeetings)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.PsDiagMeetings)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.PsDiagMeetings)
                .HasForeignKey(d => d.HospId);

        }
    }
}
