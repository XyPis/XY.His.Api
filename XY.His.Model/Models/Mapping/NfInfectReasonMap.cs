using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NfInfectReasonMap : EntityTypeConfiguration<NfInfectReason>
    {
        public NfInfectReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NfInfectReason");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.InfReasonId).HasColumnName("InfReasonId");
            this.Property(t => t.IsRelated).HasColumnName("IsRelated");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsInfReason)
                .WithMany(t => t.NfInfectReasons)
                .HasForeignKey(d => d.InfReasonId);
            this.HasRequired(t => t.NfInfect)
                .WithMany(t => t.NfInfectReasons)
                .HasForeignKey(d => d.InfectId);

        }
    }
}
