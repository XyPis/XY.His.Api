using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgRoadDtlMap : EntityTypeConfiguration<DgRoadDtl>
    {
        public DgRoadDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
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
            this.ToTable("DgRoadDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoadId).HasColumnName("RoadId");
            this.Property(t => t.DayGroupId).HasColumnName("DayGroupId");
            this.Property(t => t.CureId).HasColumnName("CureId");
            this.Property(t => t.DrugId).HasColumnName("DrugId");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.NurseId).HasColumnName("NurseId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.LsAdvType).HasColumnName("LsAdvType");
            this.Property(t => t.LsCureType).HasColumnName("LsCureType");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.FeeTotality).HasColumnName("FeeTotality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.IsNeed).HasColumnName("IsNeed");
            this.Property(t => t.IsReason).HasColumnName("IsReason");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
