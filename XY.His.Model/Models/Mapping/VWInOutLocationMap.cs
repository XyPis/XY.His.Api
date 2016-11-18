using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VWInOutLocationMap : EntityTypeConfiguration<VWInOutLocation>
    {
        public VWInOutLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.OutLocId);

            // Properties
            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.InLocation)
                .HasMaxLength(30);

            this.Property(t => t.OutLocation)
                .HasMaxLength(30);

            this.Property(t => t.OutOperName)
                .HasMaxLength(30);

            this.Property(t => t.InOperName)
                .HasMaxLength(30);

            this.Property(t => t.OutLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VWInOutLocation");
            this.Property(t => t.OutOperTime).HasColumnName("OutOperTime");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.InLocation).HasColumnName("InLocation");
            this.Property(t => t.OutLocation).HasColumnName("OutLocation");
            this.Property(t => t.InOperTime).HasColumnName("InOperTime");
            this.Property(t => t.OutOperName).HasColumnName("OutOperName");
            this.Property(t => t.InOperName).HasColumnName("InOperName");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OutLocId).HasColumnName("OutLocId");
            this.Property(t => t.InLocId).HasColumnName("InLocId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
        }
    }
}
