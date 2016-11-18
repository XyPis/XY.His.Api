using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuRecipeDtlMap : EntityTypeConfiguration<VwOuRecipeDtl>
    {
        public VwOuRecipeDtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LsRepType, t.RecipeNum, t.RecipeTime, t.LocationId, t.DoctorId, t.IsPriority, t.IsPend, t.IsExecuted, t.GroupNum, t.ListNum, t.ItemId, t.Name, t.Spec, t.Dosage, t.Totality, t.UnitDiagId, t.LsGfType, t.LsRpType, t.PriceDiag, t.IsBack, t.IsToBack, t.IsIssue, t.IsPrepared, t.IsPrint, t.IsCancel, t.IsCharged, t.IsOtherFee, t.IsAttach, t.MzRegId, t.MzRegNo, t.CardNo, t.PatientName, t.SexName, t.PatTypeId, t.RegTypeId, t.ItemCode });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRepType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRepTypeName)
                .HasMaxLength(14);

            this.Property(t => t.RecipeNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeName)
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitDiagName)
                .HasMaxLength(50);

            this.Property(t => t.UnitDiagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsGfType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsGfTypeName)
                .HasMaxLength(14);

            this.Property(t => t.LsRpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRpTypeName)
                .HasMaxLength(6);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.PrepareTime)
                .HasMaxLength(50);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.RegTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DoctorCode)
                .HasMaxLength(12);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VwOuRecipeDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.LsRepTypeName).HasColumnName("LsRepTypeName");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsPend).HasColumnName("IsPend");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.IsDoctorInput).HasColumnName("IsDoctorInput");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.FeeTotality).HasColumnName("FeeTotality");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.LsGfType).HasColumnName("LsGfType");
            this.Property(t => t.LsGfTypeName).HasColumnName("LsGfTypeName");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.LsRpTypeName).HasColumnName("LsRpTypeName");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.IsToBack).HasColumnName("IsToBack");
            this.Property(t => t.IssueOperId).HasColumnName("IssueOperId");
            this.Property(t => t.IssueTime).HasColumnName("IssueTime");
            this.Property(t => t.IsIssue).HasColumnName("IsIssue");
            this.Property(t => t.PrepareOperId).HasColumnName("PrepareOperId");
            this.Property(t => t.PrepareTime).HasColumnName("PrepareTime");
            this.Property(t => t.IsPrepared).HasColumnName("IsPrepared");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.DoctorCode).HasColumnName("DoctorCode");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
        }
    }
}
