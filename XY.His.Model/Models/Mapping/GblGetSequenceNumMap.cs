using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblGetSequenceNumMap : EntityTypeConfiguration<GblGetSequenceNum>
    {
        public GblGetSequenceNumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.GetdateStr)
                .HasMaxLength(8);

            this.Property(t => t.NextSequenceStr)
                .HasMaxLength(16);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblGetSequenceNum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NextSequenceNum).HasColumnName("NextSequenceNum");
            this.Property(t => t.IsDayBegin).HasColumnName("IsDayBegin");
            this.Property(t => t.GetdateStr).HasColumnName("GetdateStr");
            this.Property(t => t.NextSequenceStr).HasColumnName("NextSequenceStr");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
