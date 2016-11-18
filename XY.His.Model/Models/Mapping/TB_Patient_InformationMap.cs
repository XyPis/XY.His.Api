using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_Patient_InformationMap : EntityTypeConfiguration<TB_Patient_Information>
    {
        public TB_Patient_InformationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FileNumber, t.HealthRecordNumber, t.HealthCardNumber, t.CardNumber, t.CardType, t.CardTypeName, t.ChinaIDNumber, t.IDNumber, t.IDType, t.IDTypeName, t.PaymentMethod, t.PaymentMethodName, t.Name, t.Gender, t.GenderName, t.MaritalStatus, t.MaritalStatusName, t.Nation, t.NationName, t.Nationality, t.NationalityName, t.OccupationalCategory, t.OccupationalCategoryName, t.EducationLevel, t.EducationLevelName, t.EmailAddress, t.NameOfEmployer, t.PhoneOfEmployer, t.AddressOfEmployer, t.PostcodeOfEmployer, t.ContactPersonsName, t.ContactPersonsPhone, t.ContactIDNumber, t.RelationshipWithContact, t.RelationshipName, t.ContactPersonsAddress, t.ContactPersonsPostcode, t.PermanentAddressResidenceSign, t.ResidenceAddress, t.AdministrativeDivisionsCodeOfResidence, t.ProvinceOfResidence, t.CityOfResidence, t.CountyOfResidence, t.TownOfResidence, t.VillageOfResidence, t.HouseNumberOfResidence, t.PostcodeOfResidence, t.RegisteredAddress, t.AdministrativeDivisionsCodeOfRegisteredResidence, t.ProvinceOfRegisteredResidence, t.CityOfRegisteredResidence, t.CountyOfRegisteredResidence, t.TownOfRegisteredResidence, t.VillageOfRegisteredResidence, t.HouseNumberOfRegisteredResidence, t.PostcodeOfRegisteredResidence });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.FileNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HealthRecordNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HealthCardNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CardNumber)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.CardType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CardTypeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ChinaIDNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IDNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IDType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IDTypeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PaymentMethod)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PaymentMethodName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BirthDate)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.Gender)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GenderName)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MaritalStatusName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Nation)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NationName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Nationality)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NationalityName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OccupationalCategory)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OccupationalCategoryName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.EducationLevel)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.EducationLevelName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TelephoneNumber)
                .HasMaxLength(15);

            this.Property(t => t.MobilePhoneNumber)
                .HasMaxLength(15);

            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NameOfEmployer)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PhoneOfEmployer)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.AddressOfEmployer)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PostcodeOfEmployer)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ContactPersonsName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ContactPersonsPhone)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ContactIDNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RelationshipWithContact)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RelationshipName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ContactPersonsAddress)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ContactPersonsPostcode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PermanentAddressResidenceSign)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ResidenceAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AdministrativeDivisionsCodeOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ProvinceOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CityOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CountyOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TownOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.VillageOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HouseNumberOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PostcodeOfResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RegisteredAddress)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.AdministrativeDivisionsCodeOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ProvinceOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CityOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CountyOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TownOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.VillageOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HouseNumberOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PostcodeOfRegisteredResidence)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TB_Patient_Information");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.FileNumber).HasColumnName("FileNumber");
            this.Property(t => t.HealthRecordNumber).HasColumnName("HealthRecordNumber");
            this.Property(t => t.HealthCardNumber).HasColumnName("HealthCardNumber");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardTypeName).HasColumnName("CardTypeName");
            this.Property(t => t.ChinaIDNumber).HasColumnName("ChinaIDNumber");
            this.Property(t => t.IDNumber).HasColumnName("IDNumber");
            this.Property(t => t.IDType).HasColumnName("IDType");
            this.Property(t => t.IDTypeName).HasColumnName("IDTypeName");
            this.Property(t => t.PaymentMethod).HasColumnName("PaymentMethod");
            this.Property(t => t.PaymentMethodName).HasColumnName("PaymentMethodName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.GenderName).HasColumnName("GenderName");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.MaritalStatusName).HasColumnName("MaritalStatusName");
            this.Property(t => t.Nation).HasColumnName("Nation");
            this.Property(t => t.NationName).HasColumnName("NationName");
            this.Property(t => t.Nationality).HasColumnName("Nationality");
            this.Property(t => t.NationalityName).HasColumnName("NationalityName");
            this.Property(t => t.OccupationalCategory).HasColumnName("OccupationalCategory");
            this.Property(t => t.OccupationalCategoryName).HasColumnName("OccupationalCategoryName");
            this.Property(t => t.EducationLevel).HasColumnName("EducationLevel");
            this.Property(t => t.EducationLevelName).HasColumnName("EducationLevelName");
            this.Property(t => t.TelephoneNumber).HasColumnName("TelephoneNumber");
            this.Property(t => t.MobilePhoneNumber).HasColumnName("MobilePhoneNumber");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.NameOfEmployer).HasColumnName("NameOfEmployer");
            this.Property(t => t.PhoneOfEmployer).HasColumnName("PhoneOfEmployer");
            this.Property(t => t.AddressOfEmployer).HasColumnName("AddressOfEmployer");
            this.Property(t => t.PostcodeOfEmployer).HasColumnName("PostcodeOfEmployer");
            this.Property(t => t.ContactPersonsName).HasColumnName("ContactPersonsName");
            this.Property(t => t.ContactPersonsPhone).HasColumnName("ContactPersonsPhone");
            this.Property(t => t.ContactIDNumber).HasColumnName("ContactIDNumber");
            this.Property(t => t.RelationshipWithContact).HasColumnName("RelationshipWithContact");
            this.Property(t => t.RelationshipName).HasColumnName("RelationshipName");
            this.Property(t => t.ContactPersonsAddress).HasColumnName("ContactPersonsAddress");
            this.Property(t => t.ContactPersonsPostcode).HasColumnName("ContactPersonsPostcode");
            this.Property(t => t.PermanentAddressResidenceSign).HasColumnName("PermanentAddressResidenceSign");
            this.Property(t => t.ResidenceAddress).HasColumnName("ResidenceAddress");
            this.Property(t => t.AdministrativeDivisionsCodeOfResidence).HasColumnName("AdministrativeDivisionsCodeOfResidence");
            this.Property(t => t.ProvinceOfResidence).HasColumnName("ProvinceOfResidence");
            this.Property(t => t.CityOfResidence).HasColumnName("CityOfResidence");
            this.Property(t => t.CountyOfResidence).HasColumnName("CountyOfResidence");
            this.Property(t => t.TownOfResidence).HasColumnName("TownOfResidence");
            this.Property(t => t.VillageOfResidence).HasColumnName("VillageOfResidence");
            this.Property(t => t.HouseNumberOfResidence).HasColumnName("HouseNumberOfResidence");
            this.Property(t => t.PostcodeOfResidence).HasColumnName("PostcodeOfResidence");
            this.Property(t => t.RegisteredAddress).HasColumnName("RegisteredAddress");
            this.Property(t => t.AdministrativeDivisionsCodeOfRegisteredResidence).HasColumnName("AdministrativeDivisionsCodeOfRegisteredResidence");
            this.Property(t => t.ProvinceOfRegisteredResidence).HasColumnName("ProvinceOfRegisteredResidence");
            this.Property(t => t.CityOfRegisteredResidence).HasColumnName("CityOfRegisteredResidence");
            this.Property(t => t.CountyOfRegisteredResidence).HasColumnName("CountyOfRegisteredResidence");
            this.Property(t => t.TownOfRegisteredResidence).HasColumnName("TownOfRegisteredResidence");
            this.Property(t => t.VillageOfRegisteredResidence).HasColumnName("VillageOfRegisteredResidence");
            this.Property(t => t.HouseNumberOfRegisteredResidence).HasColumnName("HouseNumberOfRegisteredResidence");
            this.Property(t => t.PostcodeOfRegisteredResidence).HasColumnName("PostcodeOfRegisteredResidence");
        }
    }
}
