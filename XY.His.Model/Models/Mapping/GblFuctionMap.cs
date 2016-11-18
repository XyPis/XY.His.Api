using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblFuctionMap : EntityTypeConfiguration<GblFuction>
    {
        public GblFuctionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("GblFuction");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsTest).HasColumnName("IsTest");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Code).HasColumnName("Code");

            // Relationships
            this.HasOptional(t => t.GblSystemMenu)
                .WithMany(t => t.GblFuctions)
                .HasForeignKey(d => d.MenuId);

        }
    }
}
