using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_ChinRecipe_Detail_PrintMap : EntityTypeConfiguration<Vw_ChinRecipe_Detail_Print>
    {
        public Vw_ChinRecipe_Detail_PrintMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.RecipeId, t.MzRegId, t.recipe_Num, t.Spec, t.Dosage, t.Totality, t.Memo, t.List_Num, t.IsCancel, t.Item_Desc, t.Price_In, t.PatientName, t.SequenceNum, t.Sex, t.AddressHome, t.RecipeTime, t.AccountNo, t.IsCharge, t.IsPrint, t.DoctorId, t.IdCardNo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegId)
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

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(57);

            this.Property(t => t.PrepareTime)
                .HasMaxLength(50);

            this.Property(t => t.List_Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item_Desc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Price_In)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.SequenceNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IllDesc)
                .HasMaxLength(500);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(15);

            this.Property(t => t.AccountNo)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.RecipeMemo)
                .HasMaxLength(292);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.XdRpName)
                .HasMaxLength(50);

            this.Property(t => t.PrintName)
                .HasMaxLength(50);

            this.Property(t => t.CertificateName)
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("Vw_ChinRecipe_Detail_Print");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.recipe_Num).HasColumnName("recipe_Num");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Unit_Take).HasColumnName("Unit_Take");
            this.Property(t => t.Unit_Diag).HasColumnName("Unit_Diag");
            this.Property(t => t.usagename).HasColumnName("usagename");
            this.Property(t => t.Hz).HasColumnName("Hz");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PrepareTime).HasColumnName("PrepareTime");
            this.Property(t => t.List_Num).HasColumnName("List_Num");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.Item_Desc).HasColumnName("Item_Desc");
            this.Property(t => t.Price_In).HasColumnName("Price_In");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.SequenceNum).HasColumnName("SequenceNum");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BabyMonth).HasColumnName("BabyMonth");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.IsCharge).HasColumnName("IsCharge");
            this.Property(t => t.RecipeMemo).HasColumnName("RecipeMemo");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.XdRpName).HasColumnName("XdRpName");
            this.Property(t => t.DecoctNum).HasColumnName("DecoctNum");
            this.Property(t => t.PrintName).HasColumnName("PrintName");
            this.Property(t => t.CertificateName).HasColumnName("CertificateName");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
        }
    }
}
