using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class vwOuClinicPrintMap : EntityTypeConfiguration<vwOuClinicPrint>
    {
        public vwOuClinicPrintMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MzRegId, t.MzRegNo, t.Name, t.Sex, t.Company, t.AddressHome, t.Native, t.Sensitive, t.RegTime, t.ItemName, t.DrugFormName, t.UsageName, t.UnitTakeName, t.UnitDiagName, t.NationName, t.LsMarriage, t.FrequencyName, t.MainInform, t.CheckUp, t.Disposal, t.SickHist, t.Impression, t.Analys, t.Others, t.Residence });

            // Properties
            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(15);

            this.Property(t => t.Sensitive)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IllDesc)
                .HasMaxLength(500);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DrugFormName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitTakeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.UnitDiagName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.NationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsMarriage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Occupation)
                .HasMaxLength(20);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.FrequencyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MainInform)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CheckUp)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.CheckCT)
                .HasMaxLength(1000);

            this.Property(t => t.Disposal)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.SickHist)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Impression)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Analys)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Others)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.RecipeNum)
                .HasMaxLength(20);

            this.Property(t => t.AgeString)
                .HasMaxLength(50);

            this.Property(t => t.Residence)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Tongue)
                .HasMaxLength(100);

            this.Property(t => t.Pulse)
                .HasMaxLength(100);

            this.Property(t => t.Moss)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vwOuClinicPrint");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.DrugFormName).HasColumnName("DrugFormName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.NationName).HasColumnName("NationName");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.MainInform).HasColumnName("MainInform");
            this.Property(t => t.CheckUp).HasColumnName("CheckUp");
            this.Property(t => t.ExamT).HasColumnName("ExamT");
            this.Property(t => t.ExamP).HasColumnName("ExamP");
            this.Property(t => t.ExamR).HasColumnName("ExamR");
            this.Property(t => t.ExamBp).HasColumnName("ExamBp");
            this.Property(t => t.ExamBp2).HasColumnName("ExamBp2");
            this.Property(t => t.CheckCT).HasColumnName("CheckCT");
            this.Property(t => t.Disposal).HasColumnName("Disposal");
            this.Property(t => t.SickHist).HasColumnName("SickHist");
            this.Property(t => t.Impression).HasColumnName("Impression");
            this.Property(t => t.Analys).HasColumnName("Analys");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.Tongue).HasColumnName("Tongue");
            this.Property(t => t.Pulse).HasColumnName("Pulse");
            this.Property(t => t.Moss).HasColumnName("Moss");
            this.Property(t => t.IsDoctorInput).HasColumnName("IsDoctorInput");
        }
    }
}
