using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class EqRepairMap : EntityTypeConfiguration<EqRepair>
    {
        public EqRepairMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.RepairWay)
                .HasMaxLength(50);

            this.Property(t => t.RepairUnit)
                .HasMaxLength(50);

            this.Property(t => t.RepairMan)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EqRepair");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EquipmentId).HasColumnName("EquipmentId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.RepairTime).HasColumnName("RepairTime");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.RepairWay).HasColumnName("RepairWay");
            this.Property(t => t.RepairUnit).HasColumnName("RepairUnit");
            this.Property(t => t.RepairMan).HasColumnName("RepairMan");
            this.Property(t => t.RepairFee).HasColumnName("RepairFee");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.EqRepairs)
                .HasForeignKey(d => d.OperID);
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.EqRepairs)
                .HasForeignKey(d => d.EquipmentId);

        }
    }
}
