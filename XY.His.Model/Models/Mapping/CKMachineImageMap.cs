using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineImageMap : EntityTypeConfiguration<CKMachineImage>
    {
        public CKMachineImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SampleNum)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.ImageType)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CKMachineImage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabID).HasColumnName("LabID");
            this.Property(t => t.SampleNum).HasColumnName("SampleNum");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.LabImage).HasColumnName("LabImage");
            this.Property(t => t.ImageType).HasColumnName("ImageType");
            this.Property(t => t.IsDisplay).HasColumnName("IsDisplay");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}
