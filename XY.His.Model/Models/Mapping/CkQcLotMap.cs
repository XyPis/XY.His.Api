using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkQcLotMap : EntityTypeConfiguration<CkQcLot>
    {
        public CkQcLotMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SampleNum)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CkQcLot");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.SampleNum).HasColumnName("SampleNum");
            this.Property(t => t.MachineId).HasColumnName("MachineId");
            this.Property(t => t.ExpiryDate).HasColumnName("ExpiryDate");
            this.Property(t => t.CtrlId).HasColumnName("CtrlId");

            // Relationships
            this.HasRequired(t => t.CKMachine)
                .WithMany(t => t.CkQcLots)
                .HasForeignKey(d => d.MachineId);
            this.HasRequired(t => t.CkQcControl)
                .WithMany(t => t.CkQcLots)
                .HasForeignKey(d => d.CtrlId);

        }
    }
}
