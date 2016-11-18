using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OtBidDtlMap : EntityTypeConfiguration<OtBidDtl>
    {
        public OtBidDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RoundNTime)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Memo)
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
            this.ToTable("OtBidDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BidId).HasColumnName("BidId");
            this.Property(t => t.RoundNTime).HasColumnName("RoundNTime");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ExpOperId).HasColumnName("ExpOperId");
            this.Property(t => t.Point).HasColumnName("Point");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.OtBidDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OtBidDtls)
                .HasForeignKey(d => d.ExpOperId);
            this.HasOptional(t => t.OtBid)
                .WithMany(t => t.OtBidDtls)
                .HasForeignKey(d => d.BidId);

        }
    }
}
