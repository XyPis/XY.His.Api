using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfectReasonMap : EntityTypeConfiguration<VwNfinfectReason>
    {
        public VwNfinfectReasonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InfectId, t.InfReason });

            // Properties
            this.Property(t => t.InfectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InfReason)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InfReasonType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwNfinfectReason");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.IsRelated).HasColumnName("IsRelated");
            this.Property(t => t.InfReason).HasColumnName("InfReason");
            this.Property(t => t.InfReasonType).HasColumnName("InfReasonType");
        }
    }
}
