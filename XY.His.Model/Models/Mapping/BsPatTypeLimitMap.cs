using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPatTypeLimitMap : EntityTypeConfiguration<BsPatTypeLimit>
    {
        public BsPatTypeLimitMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsPatTypeLimit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.DocLevId).HasColumnName("DocLevId");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsDocLevel)
                .WithMany(t => t.BsPatTypeLimits)
                .HasForeignKey(d => d.DocLevId);
            this.HasOptional(t => t.BsLimitGroup)
                .WithMany(t => t.BsPatTypeLimits)
                .HasForeignKey(d => d.LimitGroupId);
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.BsPatTypeLimits)
                .HasForeignKey(d => d.PatTypeId);

        }
    }
}
