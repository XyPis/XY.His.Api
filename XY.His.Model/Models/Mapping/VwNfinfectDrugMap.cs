using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfectDrugMap : EntityTypeConfiguration<VwNfinfectDrug>
    {
        public VwNfinfectDrugMap()
        {
            // Primary Key
            this.HasKey(t => t.InfectId);

            // Properties
            this.Property(t => t.InfectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BaseDrug)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.Usage)
                .HasMaxLength(50);

            this.Property(t => t.Frequency)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwNfinfectDrug");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.BaseDrug).HasColumnName("BaseDrug");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Usage).HasColumnName("Usage");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.totaldosage).HasColumnName("totaldosage");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Amount).HasColumnName("Amount");
        }
    }
}
