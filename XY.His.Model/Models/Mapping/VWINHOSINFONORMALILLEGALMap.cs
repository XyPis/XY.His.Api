using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VWINHOSINFONORMALILLEGALMap : EntityTypeConfiguration<VWINHOSINFONORMALILLEGAL>
    {
        public VWINHOSINFONORMALILLEGALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.INPATNO });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INPATNO)
                .IsRequired()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("VWINHOSINFONORMALILLEGAL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.INPATNO).HasColumnName("INPATNO");
        }
    }
}
