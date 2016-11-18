using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPatTypeYbIllMap : EntityTypeConfiguration<BsPatTypeYbIll>
    {
        public BsPatTypeYbIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YbCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.YbDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IllIds)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsPatTypeYbIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.YbCode).HasColumnName("YbCode");
            this.Property(t => t.YbDesc).HasColumnName("YbDesc");
            this.Property(t => t.IllIds).HasColumnName("IllIds");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsPatType)
                .WithMany(t => t.BsPatTypeYbIlls)
                .HasForeignKey(d => d.PatTypeId);
            this.HasOptional(t => t.BsTallyType)
                .WithMany(t => t.BsPatTypeYbIlls)
                .HasForeignKey(d => d.TallyTypeId);

        }
    }
}
