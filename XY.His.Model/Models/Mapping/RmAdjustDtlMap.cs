using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmAdjustDtlMap : EntityTypeConfiguration<RmAdjustDtl>
    {
        public RmAdjustDtlMap()
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
            this.ToTable("RmAdjustDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.ProfLoss).HasColumnName("ProfLoss");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmAdjustDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmAdjustDtls)
                .HasForeignKey(d => d.RoomId);
            this.HasRequired(t => t.RmAdjust)
                .WithMany(t => t.RmAdjustDtls)
                .HasForeignKey(d => d.BillId);
            this.HasRequired(t => t.Rmstore)
                .WithMany(t => t.RmAdjustDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
