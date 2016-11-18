using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class EqAttachMap : EntityTypeConfiguration<EqAttach>
    {
        public EqAttachMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsFileType)
                .IsRequired()
                .HasMaxLength(50);

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
            this.ToTable("EqAttach");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EquipmentId).HasColumnName("EquipmentId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.LsFileType).HasColumnName("LsFileType");
            this.Property(t => t.AttachFile).HasColumnName("AttachFile");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.EqAttaches)
                .HasForeignKey(d => d.EquipmentId);

        }
    }
}
