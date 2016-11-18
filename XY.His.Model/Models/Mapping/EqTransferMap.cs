using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class EqTransferMap : EntityTypeConfiguration<EqTransfer>
    {
        public EqTransferMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.ToPlace)
                .HasMaxLength(50);

            this.Property(t => t.RecieveMan)
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
            this.ToTable("EqTransfer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EquipmentId).HasColumnName("EquipmentId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ChangeTime).HasColumnName("ChangeTime");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.FromLocId).HasColumnName("FromLocId");
            this.Property(t => t.ToLocId).HasColumnName("ToLocId");
            this.Property(t => t.ToPlace).HasColumnName("ToPlace");
            this.Property(t => t.RecieveMan).HasColumnName("RecieveMan");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.EqTransfers)
                .HasForeignKey(d => d.FromLocId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.EqTransfers1)
                .HasForeignKey(d => d.ToLocId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.EqTransfers)
                .HasForeignKey(d => d.OperID);
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.EqTransfers)
                .HasForeignKey(d => d.EquipmentId);

        }
    }
}
