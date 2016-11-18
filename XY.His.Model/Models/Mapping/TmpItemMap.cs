using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TmpItemMap : EntityTypeConfiguration<TmpItem>
    {
        public TmpItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CKey)
                .HasMaxLength(50);

            this.Property(t => t.CType)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(500);

            this.Property(t => t.TempName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TmpItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.CKey).HasColumnName("CKey");
            this.Property(t => t.CType).HasColumnName("CType");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.TempName).HasColumnName("TempName");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.TmpItems)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.GblSystemMenu)
                .WithMany(t => t.TmpItems)
                .HasForeignKey(d => d.MenuId);

        }
    }
}
