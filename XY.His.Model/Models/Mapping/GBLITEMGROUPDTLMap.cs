using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GBLITEMGROUPDTLMap : EntityTypeConfiguration<GBLITEMGROUPDTL>
    {
        public GBLITEMGROUPDTLMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GBLITEMGROUPDTL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GROUPID).HasColumnName("GROUPID");
            this.Property(t => t.ITEMID).HasColumnName("ITEMID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.GBLITEMGROUPDTLs)
                .HasForeignKey(d => d.ITEMID);
            this.HasRequired(t => t.GBLITEMGROUP)
                .WithMany(t => t.GBLITEMGROUPDTLs)
                .HasForeignKey(d => d.GROUPID);

        }
    }
}
