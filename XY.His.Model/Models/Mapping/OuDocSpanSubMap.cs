using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuDocSpanSubMap : EntityTypeConfiguration<OuDocSpanSub>
    {
        public OuDocSpanSubMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.f1)
                .HasMaxLength(100);

            this.Property(t => t.f2)
                .HasMaxLength(100);

            this.Property(t => t.f3)
                .HasMaxLength(100);

            this.Property(t => t.f4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuDocSpanSub");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.weekplanid).HasColumnName("weekplanid");
            this.Property(t => t.spanlimitnum).HasColumnName("spanlimitnum");
            this.Property(t => t.sublimitnum).HasColumnName("sublimitnum");
            this.Property(t => t.timespansubid).HasColumnName("timespansubid");
            this.Property(t => t.f1).HasColumnName("f1");
            this.Property(t => t.f2).HasColumnName("f2");
            this.Property(t => t.f3).HasColumnName("f3");
            this.Property(t => t.f4).HasColumnName("f4");

            // Relationships
            this.HasOptional(t => t.BsDocRegType)
                .WithMany(t => t.OuDocSpanSubs)
                .HasForeignKey(d => d.weekplanid);
            this.HasOptional(t => t.BsRegSpanSub)
                .WithMany(t => t.OuDocSpanSubs)
                .HasForeignKey(d => d.timespansubid);

        }
    }
}
