using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class syssegmentMap : EntityTypeConfiguration<syssegment>
    {
        public syssegmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.segment, t.name, t.status });

            // Properties
            this.Property(t => t.segment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("syssegments");
            this.Property(t => t.segment).HasColumnName("segment");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
