using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BSDOCREGTYPE_TEMP_Map : EntityTypeConfiguration<BSDOCREGTYPE_TEMP_>
    {
        public BSDOCREGTYPE_TEMP_Map()
        {
            // Primary Key
            this.HasKey(t => new { t.locationid, t.regtypeid, t.timespanid, t.doctorid });

            // Properties
            this.Property(t => t.locationid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.regtypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.timespanid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.mdinfo)
                .HasMaxLength(62);

            this.Property(t => t.tdinfo)
                .HasMaxLength(62);

            this.Property(t => t.wdinfo)
                .HasMaxLength(62);

            this.Property(t => t.tudinfo)
                .HasMaxLength(62);

            this.Property(t => t.fdinfo)
                .HasMaxLength(62);

            this.Property(t => t.stdinfo)
                .HasMaxLength(62);

            this.Property(t => t.sudinfo)
                .HasMaxLength(62);

            this.Property(t => t.doctorid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BSDOCREGTYPE_TEMP$");
            this.Property(t => t.locationid).HasColumnName("locationid");
            this.Property(t => t.regtypeid).HasColumnName("regtypeid");
            this.Property(t => t.timespanid).HasColumnName("timespanid");
            this.Property(t => t.mdinfo).HasColumnName("mdinfo");
            this.Property(t => t.tdinfo).HasColumnName("tdinfo");
            this.Property(t => t.wdinfo).HasColumnName("wdinfo");
            this.Property(t => t.tudinfo).HasColumnName("tudinfo");
            this.Property(t => t.fdinfo).HasColumnName("fdinfo");
            this.Property(t => t.stdinfo).HasColumnName("stdinfo");
            this.Property(t => t.sudinfo).HasColumnName("sudinfo");
            this.Property(t => t.doctorid).HasColumnName("doctorid");
        }
    }
}
