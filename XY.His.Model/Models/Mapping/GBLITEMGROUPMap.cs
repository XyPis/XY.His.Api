using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GBLITEMGROUPMap : EntityTypeConfiguration<GBLITEMGROUP>
    {
        public GBLITEMGROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GBLITEMGROUP");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
