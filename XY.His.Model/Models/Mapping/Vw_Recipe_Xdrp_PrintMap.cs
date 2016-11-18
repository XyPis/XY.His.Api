using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_Recipe_Xdrp_PrintMap : EntityTypeConfiguration<Vw_Recipe_Xdrp_Print>
    {
        public Vw_Recipe_Xdrp_PrintMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MzRegId, t.RecipeID, t.recipe_Num, t.Spec, t.Unit_Take, t.Unit_Diag, t.usagename, t.Hz, t.Frequency, t.Dosage, t.Totality, t.Memo, t.Form_Name, t.list_Num, t.Int_Code, t.IsCancel, t.Item_Desc, t.Group_Num, t.Days, t.Item_Code, t.isNoAttach, t.Price_In, t.Drug_Type, t.Amount, t.Rp_Type, t.SequenceNum, t.PatientName, t.Sex, t.RecipeTime, t.AddressHome, t.AccountNo });

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
                .HasMaxLength(1);

            this.Property(t => t.Unit_Take)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Unit_Diag)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.usagename)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Hz)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Frequency)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PrepareTime)
                .HasMaxLength(50);

            this.Property(t => t.Form_Name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.list_Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Int_Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsCancel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item_Desc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Group_Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item_Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Price_In)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Drug_Type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rp_Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SequenceNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

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

            // Table & Column Mappings
            this.ToTable("Vw_Recipe_Xdrp_Print");
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
            this.Property(t => t.isNoAttach).HasColumnName("isNoAttach");
            this.Property(t => t.Price_In).HasColumnName("Price_In");
            this.Property(t => t.Drug_Type).HasColumnName("Drug_Type");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Rp_Type).HasColumnName("Rp_Type");
            this.Property(t => t.SequenceNum).HasColumnName("SequenceNum");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
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
        }
    }
}
