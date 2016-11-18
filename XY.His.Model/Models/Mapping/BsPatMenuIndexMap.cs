using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPatMenuIndexMap : EntityTypeConfiguration<BsPatMenuIndex>
    {
        public BsPatMenuIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ParentID)
                .HasMaxLength(50);

            this.Property(t => t.Tips)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsPatMenuIndex");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.Tips).HasColumnName("Tips");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.BsPatMenuIndexes)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.GblPatientMenu)
                .WithMany(t => t.BsPatMenuIndexes)
                .HasForeignKey(d => d.PatMenuId);

        }
    }
}
