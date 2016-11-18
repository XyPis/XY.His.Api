using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfectIllMap : EntityTypeConfiguration<VwNfinfectIll>
    {
        public VwNfinfectIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwNfinfectIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
        }
    }
}
