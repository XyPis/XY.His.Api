using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InChinRicipeDtlMap : EntityTypeConfiguration<InChinRicipeDtl>
    {
        public InChinRicipeDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
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
            this.ToTable("InChinRicipeDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.LsDecoctWay).HasColumnName("LsDecoctWay");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InChinRicipeDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InChinRicipeDtls)
                .HasForeignKey(d => d.UnitTakeId);
            this.HasRequired(t => t.InChinRicipe)
                .WithMany(t => t.InChinRicipeDtls)
                .HasForeignKey(d => d.RecipeId);

        }
    }
}
