using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkPsApplyMap : EntityTypeConfiguration<CkPsApply>
    {
        public CkPsApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CheckBody)
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
            this.ToTable("CkPsApply");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CheckBody).HasColumnName("CheckBody");
            this.Property(t => t.XType).HasColumnName("XType");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.CkPsApplies)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.CkMain)
                .WithMany(t => t.CkPsApplies)
                .HasForeignKey(d => d.CheckId);

        }
    }
}
