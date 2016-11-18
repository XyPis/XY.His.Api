using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuInvoiceDtl_AMap : EntityTypeConfiguration<OuInvoiceDtl_A>
    {
        public OuInvoiceDtl_AMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.InvoId, t.ItemId, t.Totality, t.UnitId, t.Price, t.DiscDiag, t.IsModiDisc, t.DiscSelf, t.Amount, t.AmountFact, t.AmountSelf, t.AmountTally, t.LsPerform, t.LimitFee, t.ExecLocId, t.DoctorId, t.InvItemId, t.FeeId, t.Memo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountFact)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountTally)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LimitFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuInvoiceDtl_A");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.IsModiDisc).HasColumnName("IsModiDisc");
            this.Property(t => t.DiscSelf).HasColumnName("DiscSelf");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountFact).HasColumnName("AmountFact");
            this.Property(t => t.AmountSelf).HasColumnName("AmountSelf");
            this.Property(t => t.AmountTally).HasColumnName("AmountTally");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.LimitFee).HasColumnName("LimitFee");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.FeeHsId).HasColumnName("FeeHsId");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.RecipeItemId).HasColumnName("RecipeItemId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.RecipeGroupId).HasColumnName("RecipeGroupId");
            this.Property(t => t.DocLocID).HasColumnName("DocLocID");
        }
    }
}
