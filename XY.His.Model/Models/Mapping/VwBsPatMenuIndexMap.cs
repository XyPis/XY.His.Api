using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBsPatMenuIndexMap : EntityTypeConfiguration<VwBsPatMenuIndex>
    {
        public VwBsPatMenuIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PatId, t.PatientName, t.Sex, t.PatMenuId, t.RecordId, t.Tips, t.LsType, t.Code, t.MenuName, t.IsTitle, t.IsForNew });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PatMenuId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecordId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tips)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LsType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MenuName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.TableName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwBsPatMenuIndex");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.Tips).HasColumnName("Tips");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.IsTitle).HasColumnName("IsTitle");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.IsForNew).HasColumnName("IsForNew");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
        }
    }
}
