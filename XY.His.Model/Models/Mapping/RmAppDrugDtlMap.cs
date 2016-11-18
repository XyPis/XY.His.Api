using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmAppDrugDtlMap : EntityTypeConfiguration<RmAppDrugDtl>
    {
        public RmAppDrugDtlMap()
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
            this.ToTable("RmAppDrugDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmAppDrugDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmAppDrugDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.RmAppDrug)
                .WithMany(t => t.RmAppDrugDtls)
                .HasForeignKey(d => d.BillId);

        }
    }
}
