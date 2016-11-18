using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuDrugNurseNotIssueDtlBMap : EntityTypeConfiguration<VwOuDrugNurseNotIssueDtlB>
    {
        public VwOuDrugNurseNotIssueDtlBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.IsToBack, t.RecipeTime, t.IsPrepared, t.IsPrint, t.IsCancel, t.IsCharged, t.Memo, t.IsOtherFee, t.IsAttach, t.UnitDiagId, t.Totality, t.Dosage, t.GroupNum, t.ItemId, t.ListNum, t.RecipeId, t.IsBack, t.ItemCode, t.ItemName, t.Spec, t.PriceDiag });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitDiagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.UnitTakeName)
                .HasMaxLength(50);

            this.Property(t => t.UnitDiagName)
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
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
            this.ToTable("VwOuDrugNurseNotIssueDtlB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IsSelected).HasColumnName("IsSelected");
            this.Property(t => t.IsDoctorInput).HasColumnName("IsDoctorInput");
            this.Property(t => t.IsToBack).HasColumnName("IsToBack");
            this.Property(t => t.IssueOperId).HasColumnName("IssueOperId");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.IsPrepared).HasColumnName("IsPrepared");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
