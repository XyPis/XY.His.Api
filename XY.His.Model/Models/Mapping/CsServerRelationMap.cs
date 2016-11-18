using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsServerRelationMap : EntityTypeConfiguration<CsServerRelation>
    {
        public CsServerRelationMap()
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
            this.ToTable("CsServerRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SeverLocId).HasColumnName("SeverLocId");
            this.Property(t => t.BenefitLocId).HasColumnName("BenefitLocId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.CsServerRelations)
                .HasForeignKey(d => d.SeverLocId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.CsServerRelations1)
                .HasForeignKey(d => d.BenefitLocId);

        }
    }
}
