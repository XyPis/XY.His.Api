using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwReferralBsPatientMap : EntityTypeConfiguration<VwReferralBsPatient>
    {
        public VwReferralBsPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.CardNo, t.Name, t.SexName, t.Sex, t.isBaby, t.Native, t.Residence, t.PhoneWork, t.AddressWork, t.PostCodeWork, t.AreaCodeWork, t.PhoneHome, t.AddressHome, t.PostCodeHome, t.AreaCodeHome, t.MedicareNo, t.AccountNo, t.IsOversea, t.Company, t.LsMarriage, t.IdCardNo, t.BloodGroup, t.XNo, t.Sensitive, t.LinkmanName, t.LinkmanAddress, t.LinkmanPhone, t.isHouseMaster, t.LsCensus, t.Circumference, t.Waistline, t.Sternline, t.LsSport, t.LsSportTime, t.LsSportType, t.LsBitHabit, t.SleepHour, t.LsSleepTrouble, t.SmokeHistory, t.DrinkHistory, t.OtherHabit, t.IsActive, t.InActiveReason, t.IconIndex, t.OperTime, t.OperID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.CommitteeName)
                .HasMaxLength(50);

            this.Property(t => t.PoliceStationName)
                .HasMaxLength(50);

            this.Property(t => t.FamilyName)
                .HasMaxLength(30);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Residence)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PhoneWork)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.AddressWork)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PostCodeWork)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeWork)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PostCodeHome)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeHome)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.MedicareNo)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.AccountNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .HasMaxLength(20);

            this.Property(t => t.LsMarriage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MarriageName)
                .HasMaxLength(4);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CertificateName)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(30);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.BloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.XNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sensitive)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RelationName)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LinkmanPost)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanArea)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkmanPhone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.LsCensus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Census)
                .HasMaxLength(4);

            this.Property(t => t.EduLevelName)
                .HasMaxLength(50);

            this.Property(t => t.Circumference)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Waistline)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sternline)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSport)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sport)
                .HasMaxLength(11);

            this.Property(t => t.LsSportTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSportType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsBitHabit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SleepHour)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSleepTrouble)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SleepTrouble)
                .HasMaxLength(8);

            this.Property(t => t.SmokeHistory)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.DrinkHistory)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OtherHabit)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.InActiveReason)
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

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoadName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwReferralBsPatient");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.isBaby).HasColumnName("isBaby");
            this.Property(t => t.NationId).HasColumnName("NationId");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.RegionId).HasColumnName("RegionId");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.CommitteeName).HasColumnName("CommitteeName");
            this.Property(t => t.PoliceStationId).HasColumnName("PoliceStationId");
            this.Property(t => t.PoliceStationName).HasColumnName("PoliceStationName");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.FamilyName).HasColumnName("FamilyName");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.PhoneWork).HasColumnName("PhoneWork");
            this.Property(t => t.AddressWork).HasColumnName("AddressWork");
            this.Property(t => t.PostCodeWork).HasColumnName("PostCodeWork");
            this.Property(t => t.AreaCodeWork).HasColumnName("AreaCodeWork");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.AreaCodeHome).HasColumnName("AreaCodeHome");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.IsOversea).HasColumnName("IsOversea");
            this.Property(t => t.PassTime).HasColumnName("PassTime");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.MarriageName).HasColumnName("MarriageName");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.CertificateId).HasColumnName("CertificateId");
            this.Property(t => t.CertificateName).HasColumnName("CertificateName");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.XNo).HasColumnName("XNo");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.RelaMasterId).HasColumnName("RelaMasterId");
            this.Property(t => t.RelationName).HasColumnName("RelationName");
            this.Property(t => t.MotherPatId).HasColumnName("MotherPatId");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.LinkmanArea).HasColumnName("LinkmanArea");
            this.Property(t => t.LinkmanAddress).HasColumnName("LinkmanAddress");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.isHouseMaster).HasColumnName("isHouseMaster");
            this.Property(t => t.LsCensus).HasColumnName("LsCensus");
            this.Property(t => t.Census).HasColumnName("Census");
            this.Property(t => t.LevelId).HasColumnName("LevelId");
            this.Property(t => t.EduLevelName).HasColumnName("EduLevelName");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Circumference).HasColumnName("Circumference");
            this.Property(t => t.Waistline).HasColumnName("Waistline");
            this.Property(t => t.Sternline).HasColumnName("Sternline");
            this.Property(t => t.LsSport).HasColumnName("LsSport");
            this.Property(t => t.Sport).HasColumnName("Sport");
            this.Property(t => t.LsSportTime).HasColumnName("LsSportTime");
            this.Property(t => t.LsSportType).HasColumnName("LsSportType");
            this.Property(t => t.LsBitHabit).HasColumnName("LsBitHabit");
            this.Property(t => t.SleepHour).HasColumnName("SleepHour");
            this.Property(t => t.LsSleepTrouble).HasColumnName("LsSleepTrouble");
            this.Property(t => t.SleepTrouble).HasColumnName("SleepTrouble");
            this.Property(t => t.SmokeHistory).HasColumnName("SmokeHistory");
            this.Property(t => t.DrinkHistory).HasColumnName("DrinkHistory");
            this.Property(t => t.OtherHabit).HasColumnName("OtherHabit");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.RoadName).HasColumnName("RoadName");
        }
    }
}
