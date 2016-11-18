using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuInvoiceDtlMap : EntityTypeConfiguration<OuInvoiceDtl>
    {
        public OuInvoiceDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
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
            this.ToTable("OuInvoiceDtl");
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

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsHsFeety)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.FeeHsId);
            this.HasRequired(t => t.BsInvMzItem)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.InvItemId);
            this.HasRequired(t => t.BsInvMzItem1)
                .WithMany(t => t.OuInvoiceDtls1)
                .HasForeignKey(d => d.InvItemId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLimitGroup)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.LimitGroupId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.ExecLocId);
            this.HasRequired(t => t.BsMzFeety)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.FeeId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.OuInvoice)
                .WithMany(t => t.OuInvoiceDtls)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
