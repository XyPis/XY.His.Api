using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zybrxmhzMap : EntityTypeConfiguration<Vw_zybrxmhz>
    {
        public Vw_zybrxmhzMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FeeId, t.HospId, t.InvItemId });

            // Properties
            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegOperTime)
                .HasMaxLength(92);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_zybrxmhz");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.RegOperTime).HasColumnName("RegOperTime");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
        }
    }
}
