using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_PatientInNTimeMap : EntityTypeConfiguration<Vw_PatientInNTime>
    {
        public Vw_PatientInNTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.PatID);

            // Properties
            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_PatientInNTime");
            this.Property(t => t.MaxNTime).HasColumnName("MaxNTime");
            this.Property(t => t.PatID).HasColumnName("PatID");
        }
    }
}
