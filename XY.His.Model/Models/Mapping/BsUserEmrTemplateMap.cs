using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsUserEmrTemplateMap : EntityTypeConfiguration<BsUserEmrTemplate>
    {
        public BsUserEmrTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TemplateFile)
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
            this.ToTable("BsUserEmrTemplate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TemplateFile).HasColumnName("TemplateFile");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.LsOpenType).HasColumnName("LsOpenType");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsUserEmrTemplates)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.BsUserEmrTemplates)
                .HasForeignKey(d => d.OperId);

        }
    }
}
