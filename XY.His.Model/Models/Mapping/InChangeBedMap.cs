using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InChangeBedMap : EntityTypeConfiguration<InChangeBed>
    {
        public InChangeBedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Reason)
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
            this.ToTable("InChangeBed");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsLocal).HasColumnName("LsLocal");
            this.Property(t => t.ChgTime).HasColumnName("ChgTime");
            this.Property(t => t.PreBed).HasColumnName("PreBed");
            this.Property(t => t.PostBed).HasColumnName("PostBed");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBed)
                .WithMany(t => t.InChangeBeds)
                .HasForeignKey(d => d.PreBed);
            this.HasRequired(t => t.BsBed1)
                .WithMany(t => t.InChangeBeds1)
                .HasForeignKey(d => d.PostBed);
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.InChangeBeds)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InChangeBeds)
                .HasForeignKey(d => d.HospId);

        }
    }
}
