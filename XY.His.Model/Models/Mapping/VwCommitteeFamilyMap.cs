using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCommitteeFamilyMap : EntityTypeConfiguration<VwCommitteeFamily>
    {
        public VwCommitteeFamilyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.RecordId });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(21);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ParentID)
                .HasMaxLength(50);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.RecordId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwCommitteeFamily");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
        }
    }
}
