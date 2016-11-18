using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsOuMergeFeeMap : EntityTypeConfiguration<BsOuMergeFee>
    {
        public BsOuMergeFeeMap()
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
            this.ToTable("BsOuMergeFee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.ItemId1).HasColumnName("ItemId1");
            this.Property(t => t.ItemId2).HasColumnName("ItemId2");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsOuMergeFees)
                .HasForeignKey(d => d.ItemId1);
            this.HasRequired(t => t.BsItem1)
                .WithMany(t => t.BsOuMergeFees1)
                .HasForeignKey(d => d.ItemId2);
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.BsOuMergeFees)
                .HasForeignKey(d => d.PatTypeId);

        }
    }
}
