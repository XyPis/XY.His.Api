using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InOpsSumMap : EntityTypeConfiguration<InOpsSum>
    {
        public InOpsSumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InOpsSum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.SelectDateNum).HasColumnName("SelectDateNum");
            this.Property(t => t.EmergencyNum).HasColumnName("EmergencyNum");
            this.Property(t => t.OutPatientNum).HasColumnName("OutPatientNum");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InOpsSums)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InOpsSums)
                .HasForeignKey(d => d.OperId);

        }
    }
}
