using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemYbTipMap : EntityTypeConfiguration<BsItemYbTip>
    {
        public BsItemYbTipMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            this.Property(t => t.Tips)
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

            // Table & Column Mappings
            this.ToTable("BsItemYbTips");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.Tips).HasColumnName("Tips");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.BsItemYbTips)
                .HasForeignKey(d => d.IcdId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemYbTips)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsPatType)
                .WithMany(t => t.BsItemYbTips)
                .HasForeignKey(d => d.PatTypeId);
            this.HasRequired(t => t.BsTallyGroup)
                .WithOptional(t => t.BsItemYbTip);

        }
    }
}
