using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class EmrReCordMap : EntityTypeConfiguration<EmrReCord>
    {
        public EmrReCordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RECCONTENT)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(400);

            this.Property(t => t.F2)
                .HasMaxLength(400);

            this.Property(t => t.F3)
                .HasMaxLength(400);

            this.Property(t => t.F4)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("EmrReCords");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.INTIME).HasColumnName("INTIME");
            this.Property(t => t.OUTTIME).HasColumnName("OUTTIME");
            this.Property(t => t.HOSPID).HasColumnName("HOSPID");
            this.Property(t => t.MODIFYTIME).HasColumnName("MODIFYTIME");
            this.Property(t => t.RECCONTENT).HasColumnName("RECCONTENT");
            this.Property(t => t.FIRSTRETIME).HasColumnName("FIRSTRETIME");
            this.Property(t => t.INEMRID).HasColumnName("INEMRID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ISMODIFY).HasColumnName("ISMODIFY");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
        }
    }
}
