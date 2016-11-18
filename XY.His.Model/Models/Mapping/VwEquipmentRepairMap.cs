using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwEquipmentRepairMap : EntityTypeConfiguration<VwEquipmentRepair>
    {
        public VwEquipmentRepairMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.OperID, t.Name, t.LsEqType });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.EqType)
                .HasMaxLength(50);

            this.Property(t => t.BsLocationName)
                .HasMaxLength(30);

            this.Property(t => t.LsEqType)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.RepairMan)
                .HasMaxLength(50);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("VwEquipmentRepair");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.EqType).HasColumnName("EqType");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.BsLocationName).HasColumnName("BsLocationName");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LsEqType).HasColumnName("LsEqType");
            this.Property(t => t.RepairTime).HasColumnName("RepairTime");
            this.Property(t => t.RepairMan).HasColumnName("RepairMan");
            this.Property(t => t.RepairFee).HasColumnName("RepairFee");
            this.Property(t => t.Reason).HasColumnName("Reason");
        }
    }
}
