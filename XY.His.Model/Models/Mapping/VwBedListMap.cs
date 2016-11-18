using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBedListMap : EntityTypeConfiguration<VwBedList>
    {
        public VwBedListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BedName, t.LsBALL, t.PatientName, t.HospId, t.LocationId });

            // Properties
            this.Property(t => t.BedName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LsBALL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwBedList");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.LsBALL).HasColumnName("LsBALL");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
        }
    }
}
