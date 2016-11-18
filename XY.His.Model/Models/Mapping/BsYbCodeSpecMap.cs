using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsYbCodeSpecMap : EntityTypeConfiguration<BsYbCodeSpec>
    {
        public BsYbCodeSpecMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YbCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsYbCodeSpec");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.YbCode).HasColumnName("YbCode");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.BsYbCodeSpecs)
                .HasForeignKey(d => d.IcdId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsYbCodeSpecs)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsTallyGroup)
                .WithMany(t => t.BsYbCodeSpecs)
                .HasForeignKey(d => d.TallyGroupId);

        }
    }
}
