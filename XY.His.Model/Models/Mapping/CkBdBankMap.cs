using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkBdBankMap : EntityTypeConfiguration<CkBdBank>
    {
        public CkBdBankMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SerialNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RHD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Account)
                .HasMaxLength(5);

            this.Property(t => t.OfferMan)
                .HasMaxLength(50);

            this.Property(t => t.CollectMan)
                .HasMaxLength(50);

            this.Property(t => t.BackMemo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.DiscardReason)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CkBdBank");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.BloodTypeId).HasColumnName("BloodTypeId");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.RHD).HasColumnName("RHD");
            this.Property(t => t.RecieveDate).HasColumnName("RecieveDate");
            this.Property(t => t.RecieveOperId).HasColumnName("RecieveOperId");
            this.Property(t => t.LsSource).HasColumnName("LsSource");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.ExpireDate).HasColumnName("ExpireDate");
            this.Property(t => t.OfferMan).HasColumnName("OfferMan");
            this.Property(t => t.CollectDate).HasColumnName("CollectDate");
            this.Property(t => t.CollectMan).HasColumnName("CollectMan");
            this.Property(t => t.Vollume).HasColumnName("Vollume");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.BackDate).HasColumnName("BackDate");
            this.Property(t => t.BackOperId).HasColumnName("BackOperId");
            this.Property(t => t.BackMemo).HasColumnName("BackMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.DiscardReason).HasColumnName("DiscardReason");
            this.Property(t => t.DiscardTime).HasColumnName("DiscardTime");
            this.Property(t => t.DiscardOperID).HasColumnName("DiscardOperID");
        }
    }
}
