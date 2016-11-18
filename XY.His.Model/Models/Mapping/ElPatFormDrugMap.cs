using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormDrugMap : EntityTypeConfiguration<ElPatFormDrug>
    {
        public ElPatFormDrugMap()
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
            this.ToTable("ElPatFormDrug");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.ElPatForm)
                .WithMany(t => t.ElPatFormDrugs)
                .HasForeignKey(d => d.PatFormId);

        }
    }
}
