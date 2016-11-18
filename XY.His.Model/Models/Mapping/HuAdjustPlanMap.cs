using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuAdjustPlanMap : EntityTypeConfiguration<HuAdjustPlan>
    {
        public HuAdjustPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.DispUnit)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(255);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuAdjustPlan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.NotifyDate).HasColumnName("NotifyDate");
            this.Property(t => t.DispUnit).HasColumnName("DispUnit");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.HuAdjustPlans)
                .HasForeignKey(d => d.HouseId);

        }
    }
}
