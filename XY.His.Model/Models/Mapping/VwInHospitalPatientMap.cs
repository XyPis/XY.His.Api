using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInHospitalPatientMap : EntityTypeConfiguration<VwInHospitalPatient>
    {
        public VwInHospitalPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospNo, t.InPatNo, t.CardNo, t.Name, t.Sex, t.NTime, t.IsBaby, t.LsMarriage, t.BloodGroup, t.XNo, t.Residence, t.City, t.Province, t.IsOversea, t.IdCardNo, t.Company, t.Occupation, t.BsTallyGroupName, t.TallyTypeId, t.TallyTypeName, t.PatTypeId, t.PatTypeName, t.DiscIn, t.IsYbMt, t.YbRegNo, t.PhoneHome, t.AddressHome, t.PostCodeHome, t.AreaCodeHome, t.PhoneWork, t.AddressWork, t.PostCodeWork, t.AreaCodeWork, t.LinkmanName, t.LinkmanPhone, t.LinkmanAddress, t.LinkmanArea, t.LinkmanPost, t.InTime, t.LsInType, t.LsInWay, t.LsInIllness, t.LocIn, t.LocationName, t.LsInStatus, t.Status, t.OperTime, t.OperID, t.MedicareNo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarriage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.XNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Residence)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BsTallyGroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TallyTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DiscIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YbRegNo)
                .IsRequired()
                .HasMaxLength(20);

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

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LinkmanPhone)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.LinkmanAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkmanArea)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.LinkmanPost)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.LsInType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInWay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInIllness)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BedNo)
                .HasMaxLength(10);

            this.Property(t => t.RoomNo)
                .HasMaxLength(6);

            this.Property(t => t.LsInStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicareNo)
                .IsRequired()
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("VwInHospitalPatient");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.XNo).HasColumnName("XNo");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.IsOversea).HasColumnName("IsOversea");
            this.Property(t => t.PassTime).HasColumnName("PassTime");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.BsTallyGroupName).HasColumnName("BsTallyGroupName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.IsYbMt).HasColumnName("IsYbMt");
            this.Property(t => t.YbRegNo).HasColumnName("YbRegNo");
            this.Property(t => t.CertificateId).HasColumnName("CertificateId");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.AreaCodeHome).HasColumnName("AreaCodeHome");
            this.Property(t => t.PhoneWork).HasColumnName("PhoneWork");
            this.Property(t => t.AddressWork).HasColumnName("AddressWork");
            this.Property(t => t.PostCodeWork).HasColumnName("PostCodeWork");
            this.Property(t => t.AreaCodeWork).HasColumnName("AreaCodeWork");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.LinkmanAddress).HasColumnName("LinkmanAddress");
            this.Property(t => t.LinkmanArea).HasColumnName("LinkmanArea");
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.LsInType).HasColumnName("LsInType");
            this.Property(t => t.LsInWay).HasColumnName("LsInWay");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.DocMz).HasColumnName("DocMz");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedNo).HasColumnName("BedNo");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
        }
    }
}
