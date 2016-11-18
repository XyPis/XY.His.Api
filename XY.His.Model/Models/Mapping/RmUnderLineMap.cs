using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmUnderLineMap : EntityTypeConfiguration<RmUnderLine>
    {
        public RmUnderLineMap()
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
            this.ToTable("RmUnderLine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnderLine).HasColumnName("UnderLine");
            this.Property(t => t.UperLine).HasColumnName("UperLine");
            this.Property(t => t.Normal).HasColumnName("Normal");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmUnderLines)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmUnderLines)
                .HasForeignKey(d => d.RoomId);

        }
    }
}
