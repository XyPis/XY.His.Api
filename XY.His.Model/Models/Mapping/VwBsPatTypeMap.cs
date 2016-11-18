using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBsPatTypeMap : EntityTypeConfiguration<VwBsPatType>
    {
        public VwBsPatTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.DiscDiag, t.DiscIn, t.TallyTypeId, t.TallyTypeName, t.TallyGroupName, t.IsGf, t.IsYb, t.ArrearAmount });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DiscDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TallyTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ArrearAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwBsPatType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.LsGFPatTypeName).HasColumnName("LsGFPatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
        }
    }
}
