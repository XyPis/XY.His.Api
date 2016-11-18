using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineFluidMap : EntityTypeConfiguration<CKMachineFluid>
    {
        public CKMachineFluidMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MachineFluidCode)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CKMachineFluid");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.BodyFluidId).HasColumnName("BodyFluidId");
            this.Property(t => t.MachineFluidCode).HasColumnName("MachineFluidCode");
        }
    }
}
