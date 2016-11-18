using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OpsChargeMap : EntityTypeConfiguration<OpsCharge>
    {
        public OpsChargeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OpsCharge");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsTally).HasColumnName("IsTally");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Before).HasColumnName("Before");
            this.Property(t => t.Progress).HasColumnName("Progress");
            this.Property(t => t.After).HasColumnName("After");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.OpsCharges)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.OpsApply)
                .WithMany(t => t.OpsCharges)
                .HasForeignKey(d => d.ApplyId);

        }
    }
}
