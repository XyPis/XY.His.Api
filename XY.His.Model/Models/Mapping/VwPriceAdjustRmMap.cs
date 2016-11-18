using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwPriceAdjustRmMap : EntityTypeConfiguration<VwPriceAdjustRm>
    {
        public VwPriceAdjustRmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNo, t.NotifyDate, t.DispUnit, t.OperTime, t.OperId, t.Memo, t.Code, t.Name, t.Spec, t.UnitId, t.DrugNum, t.OldPrice, t.NewPrice, t.ProfLoss, t.ItemId, t.LsRpType });

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.DispUnit)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DrugNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OldPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NewPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProfLoss)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwPriceAdjustRm");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.NotifyDate).HasColumnName("NotifyDate");
            this.Property(t => t.DispUnit).HasColumnName("DispUnit");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.ProfLoss).HasColumnName("ProfLoss");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
        }
    }
}
