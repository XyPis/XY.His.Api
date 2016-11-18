using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkQcControlMap : EntityTypeConfiguration<CkQcControl>
    {
        public CkQcControlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CkQcControl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MachineID).HasColumnName("MachineID");

            // Relationships
            this.HasRequired(t => t.CKMachine)
                .WithMany(t => t.CkQcControls)
                .HasForeignKey(d => d.MachineID);

        }
    }
}
