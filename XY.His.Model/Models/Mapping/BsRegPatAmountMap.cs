using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsRegPatAmountMap : EntityTypeConfiguration<BsRegPatAmount>
    {
        public BsRegPatAmountMap()
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
            this.ToTable("BsRegPatAmount");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RegTypeID).HasColumnName("RegTypeID");
            this.Property(t => t.PatTypeID).HasColumnName("PatTypeID");
            this.Property(t => t.RegFee).HasColumnName("RegFee");
            this.Property(t => t.DiagnoFee).HasColumnName("DiagnoFee");
            this.Property(t => t.OtherFee1).HasColumnName("OtherFee1");
            this.Property(t => t.OtherFee2).HasColumnName("OtherFee2");
            this.Property(t => t.PaySel).HasColumnName("PaySel");
            this.Property(t => t.TallyFee).HasColumnName("TallyFee");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.BsRegPatAmounts)
                .HasForeignKey(d => d.PatTypeID);
            this.HasRequired(t => t.BsRegType)
                .WithMany(t => t.BsRegPatAmounts)
                .HasForeignKey(d => d.RegTypeID);

        }
    }
}
