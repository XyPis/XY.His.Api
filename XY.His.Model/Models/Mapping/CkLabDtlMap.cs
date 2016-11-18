using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkLabDtlMap : EntityTypeConfiguration<CkLabDtl>
    {
        public CkLabDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.ItemId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkLabDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.TubeTypeId).HasColumnName("TubeTypeId");
            this.Property(t => t.IsDownLoad).HasColumnName("IsDownLoad");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.IsBilled).HasColumnName("IsBilled");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.RecipeDtlId).HasColumnName("RecipeDtlId");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");

            // Relationships
            this.HasOptional(t => t.BsLabSource)
                .WithMany(t => t.CkLabDtls)
                .HasForeignKey(d => d.SourceId);
            this.HasOptional(t => t.BsTubeType)
                .WithMany(t => t.CkLabDtls)
                .HasForeignKey(d => d.TubeTypeId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.CkLabDtls)
                .HasForeignKey(d => d.PrintOperId);
            this.HasRequired(t => t.CkLab)
                .WithMany(t => t.CkLabDtls)
                .HasForeignKey(d => d.LabId);

        }
    }
}
