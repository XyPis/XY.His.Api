using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InEmrSignMap : EntityTypeConfiguration<InEmrSign>
    {
        public InEmrSignMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InEmrSign");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.EmrId).HasColumnName("EmrId");
            this.Property(t => t.SignValue).HasColumnName("SignValue");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
