using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InEmrScoreMap : EntityTypeConfiguration<InEmrScore>
    {
        public InEmrScoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.EMRITEMSCORE)
                .HasMaxLength(100);

            this.Property(t => t.EMRSCORE)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(400);

            this.Property(t => t.F2)
                .HasMaxLength(400);

            this.Property(t => t.F3)
                .HasMaxLength(400);

            this.Property(t => t.F4)
                .HasMaxLength(400);

            this.Property(t => t.PARTSCORE)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InEmrScore");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EMRQCITEMID).HasColumnName("EMRQCITEMID");
            this.Property(t => t.HOSPID).HasColumnName("HOSPID");
            this.Property(t => t.EMRITEMSCORE).HasColumnName("EMRITEMSCORE");
            this.Property(t => t.EMRSCORE).HasColumnName("EMRSCORE");
            this.Property(t => t.ISSCORE).HasColumnName("ISSCORE");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.PARTSCORE).HasColumnName("PARTSCORE");
        }
    }
}
