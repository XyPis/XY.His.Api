using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblEmailUserMap : EntityTypeConfiguration<GblEmailUser>
    {
        public GblEmailUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblEmailUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.ReadTime).HasColumnName("ReadTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.GblEmailUsers)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.GblEmail)
                .WithMany(t => t.GblEmailUsers)
                .HasForeignKey(d => d.EmailId);

        }
    }
}
