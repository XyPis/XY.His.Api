using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PlProjectItemMap : EntityTypeConfiguration<PlProjectItem>
    {
        public PlProjectItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(3000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PlProjectItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProjId).HasColumnName("ProjId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Hours).HasColumnName("Hours");
            this.Property(t => t.BeginPlan).HasColumnName("BeginPlan");
            this.Property(t => t.EndPlan).HasColumnName("EndPlan");
            this.Property(t => t.IsClose).HasColumnName("IsClose");
            this.Property(t => t.HoursFact).HasColumnName("HoursFact");
            this.Property(t => t.EndFact).HasColumnName("EndFact");
            this.Property(t => t.ChargeOperId).HasColumnName("ChargeOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.PlItem)
                .WithMany(t => t.PlProjectItems)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.PlProject)
                .WithMany(t => t.PlProjectItems)
                .HasForeignKey(d => d.ProjId);

        }
    }
}
