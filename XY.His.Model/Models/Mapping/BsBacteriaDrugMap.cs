using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsBacteriaDrugMap : EntityTypeConfiguration<BsBacteriaDrug>
    {
        public BsBacteriaDrugMap()
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
            this.ToTable("BsBacteriaDrug");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BactriaId).HasColumnName("BactriaId");
            this.Property(t => t.DrugId).HasColumnName("DrugId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBacteria)
                .WithMany(t => t.BsBacteriaDrugs)
                .HasForeignKey(d => d.BactriaId);
            this.HasRequired(t => t.BsBaseDrug)
                .WithMany(t => t.BsBacteriaDrugs)
                .HasForeignKey(d => d.DrugId);

        }
    }
}
