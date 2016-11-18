using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsLimitGroupMap : EntityTypeConfiguration<BsLimitGroup>
    {
        public BsLimitGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsLimitType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsLimitGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.TypeGFXEId).HasColumnName("TypeGFXEId");
            this.Property(t => t.LimitFeeMz).HasColumnName("LimitFeeMz");
            this.Property(t => t.LimitFeeZy).HasColumnName("LimitFeeZy");
            this.Property(t => t.LsLimitType).HasColumnName("LsLimitType");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.DocLevelId).HasColumnName("DocLevelId");

            // Relationships
            this.HasOptional(t => t.BsGfxe)
                .WithMany(t => t.BsLimitGroups)
                .HasForeignKey(d => d.TypeGFXEId);

        }
    }
}
