using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TmpMyPatMap : EntityTypeConfiguration<TmpMyPat>
    {
        public TmpMyPatMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TmpMyPat");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsAlert).HasColumnName("IsAlert");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.TmpMyPats)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.TmpMyPats)
                .HasForeignKey(d => d.FrequencyId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.TmpMyPats)
                .HasForeignKey(d => d.PatId);

        }
    }
}
