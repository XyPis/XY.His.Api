using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsUserWindowMap : EntityTypeConfiguration<BsUserWindow>
    {
        public BsUserWindowMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Caption)
                .IsRequired()
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
            this.ToTable("BsUserWindows");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.BsUserWindows)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.GblSystemMenu)
                .WithMany(t => t.BsUserWindows)
                .HasForeignKey(d => d.MenuId);

        }
    }
}
