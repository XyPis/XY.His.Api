using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkGroupItemMap : EntityTypeConfiguration<CkGroupItem>
    {
        public CkGroupItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.AppId)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkGroupItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyGroupId).HasColumnName("CompanyGroupId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AppId).HasColumnName("AppId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CkCompanyGroup)
                .WithMany(t => t.CkGroupItems)
                .HasForeignKey(d => d.CompanyGroupId);
            this.HasRequired(t => t.CkItem)
                .WithMany(t => t.CkGroupItems)
                .HasForeignKey(d => d.TestId);

        }
    }
}
