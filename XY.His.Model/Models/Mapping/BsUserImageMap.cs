using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsUserImageMap : EntityTypeConfiguration<BsUserImage>
    {
        public BsUserImageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserId, t.UserImage });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserImage)
                .IsRequired();

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BsUserImage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserImage).HasColumnName("UserImage");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
