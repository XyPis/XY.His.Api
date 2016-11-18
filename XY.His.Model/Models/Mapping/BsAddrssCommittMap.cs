using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsAddrssCommittMap : EntityTypeConfiguration<BsAddrssCommitt>
    {
        public BsAddrssCommittMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AdrressKey)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsAddrssCommitt");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AdrressKey).HasColumnName("AdrressKey");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsAreaCommittee)
                .WithMany(t => t.BsAddrssCommitts)
                .HasForeignKey(d => d.CommitteeId);

        }
    }
}
