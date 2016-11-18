using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_Recipe_Detail_Print1Map : EntityTypeConfiguration<Vw_Recipe_Detail_Print1>
    {
        public Vw_Recipe_Detail_Print1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MzRegId, t.RecipeID, t.recipe_Num, t.Spec, t.Dosage, t.Totality, t.Memo, t.list_Num, t.Int_Code, t.IsCancel, t.Item_Desc, t.Group_Num, t.Item_Code, t.IsAttach, t.Unit_DiagID, t.PubDosage, t.PubUnit_DiagID, t.Limit_Dosage, t.IsOtherFee, t.isNoAttach, t.Price_In, t.IsCharge, t.Drug_Type, t.SequenceNum, t.PatientName, t.Sex, t.RecipeTime, t.AddressHome, t.AccountNo, t.IdCardNo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.recipe_Num)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Unit_Take)
                .HasMaxLength(50);

            this.Property(t => t.Unit_Diag)
                .HasMaxLength(50);

            this.Property(t => t.usagename)
                .HasMaxLength(50);

            this.Property(t => t.Hz)
                .HasMaxLength(50);

            this.Property(t => t.Frequency)
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrepareTime)
                .HasMaxLength(50);

            this.Property(t => t.Form_Name)
                .HasMaxLength(50);

            this.Property(t => t.list_Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Int_Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item_Desc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Group_Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item_Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.Unit_DiagID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PubDosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PubUnit_DiagID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PubUnit_Diag)
                .HasMaxLength(50);

            this.Property(t => t.PubUnit_Take)
                .HasMaxLength(50);

            this.Property(t => t.Limit_Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price_In)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Drug_Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SequenceNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.AgeString)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(15);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IllDesc)
                .HasMaxLength(500);

            this.Property(t => t.RecipeMemo)
                .HasMaxLength(100);

            this.Property(t => t.AccountNo)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.CertificateName)
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("Vw_Recipe_Detail_Print1");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.RecipeID).HasColumnName("RecipeID");
            this.Property(t => t.recipe_Num).HasColumnName("recipe_Num");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Unit_Take).HasColumnName("Unit_Take");
            this.Property(t => t.Unit_Diag).HasColumnName("Unit_Diag");
            this.Property(t => t.usagename).HasColumnName("usagename");
            this.Property(t => t.Hz).HasColumnName("Hz");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PrepareTime).HasColumnName("PrepareTime");
            this.Property(t => t.Form_Name).HasColumnName("Form_Name");
            this.Property(t => t.list_Num).HasColumnName("list_Num");
            this.Property(t => t.Int_Code).HasColumnName("Int_Code");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.Item_Desc).HasColumnName("Item_Desc");
            this.Property(t => t.Group_Num).HasColumnName("Group_Num");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Item_Code).HasColumnName("Item_Code");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.Unit_TakeID).HasColumnName("Unit_TakeID");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.Unit_DiagID).HasColumnName("Unit_DiagID");
            this.Property(t => t.PubDosage).HasColumnName("PubDosage");
            this.Property(t => t.PubUnit_DiagID).HasColumnName("PubUnit_DiagID");
            this.Property(t => t.PubUnit_TakeID).HasColumnName("PubUnit_TakeID");
            this.Property(t => t.PubUnit_Diag).HasColumnName("PubUnit_Diag");
            this.Property(t => t.PubUnit_Take).HasColumnName("PubUnit_Take");
            this.Property(t => t.IsBatch).HasColumnName("IsBatch");
            this.Property(t => t.Limit_Dosage).HasColumnName("Limit_Dosage");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.isNoAttach).HasColumnName("isNoAttach");
            this.Property(t => t.Price_In).HasColumnName("Price_In");
            this.Property(t => t.IsCharge).HasColumnName("IsCharge");
            this.Property(t => t.Drug_Type).HasColumnName("Drug_Type");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.SequenceNum).HasColumnName("SequenceNum");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BabyMonth).HasColumnName("BabyMonth");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.RecipeMemo).HasColumnName("RecipeMemo");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.PageNo).HasColumnName("PageNo");
            this.Property(t => t.AllPageNo).HasColumnName("AllPageNo");
            this.Property(t => t.IsNurseExecute).HasColumnName("IsNurseExecute");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LISCode).HasColumnName("LISCode");
            this.Property(t => t.CertificateName).HasColumnName("CertificateName");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
        }
    }
}
