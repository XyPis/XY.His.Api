using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemPatTypeMap : EntityTypeConfiguration<BsItemPatType>
    {
        public BsItemPatTypeMap()
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
            this.ToTable("BsItemPatType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.InvMzItemId).HasColumnName("InvMzItemId");
            this.Property(t => t.InvInItemId).HasColumnName("InvInItemId");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsInvInItem)
                .WithMany(t => t.BsItemPatTypes)
                .HasForeignKey(d => d.InvInItemId);
            this.HasRequired(t => t.BsInvMzItem)
                .WithMany(t => t.BsItemPatTypes)
                .HasForeignKey(d => d.InvMzItemId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemPatTypes)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLimitGroup)
                .WithMany(t => t.BsItemPatTypes)
                .HasForeignKey(d => d.LimitGroupId);
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.BsItemPatTypes)
                .HasForeignKey(d => d.PatTypeId);

        }
    }
}
