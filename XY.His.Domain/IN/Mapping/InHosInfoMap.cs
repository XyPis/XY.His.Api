using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.IN.Mapping
{
    public class InHosInfoMap : EntityTypeConfiguration<InHosInfo>
    {
        public InHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.YbRegNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(50);

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
                .HasMaxLength(50);

            this.Property(t => t.AreaCodeWork)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LinkmanPhone)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.LinkmanAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkmanPost)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanArea)
                .HasMaxLength(50);

            this.Property(t => t.Status)
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

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.TipsNurse)
                .HasMaxLength(500);

            this.Property(t => t.TipsBalance)
                .HasMaxLength(500);

            this.Property(t => t.TipsOther)
                .HasMaxLength(500);

            this.Property(t => t.OtherRoles)
                .HasMaxLength(50);

            this.Property(t => t.FromHospital)
                .HasMaxLength(200);

            this.Property(t => t.F5)
                .HasMaxLength(20);

            this.Property(t => t.F6)
                .HasMaxLength(20);

            this.Property(t => t.F7)
                .HasMaxLength(20);

            this.Property(t => t.F8)
                .HasMaxLength(20);

            this.Property(t => t.YBBZCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InHosInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
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
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.CertificateId).HasColumnName("CertificateId");
            this.Property(t => t.LsInType).HasColumnName("LsInType");
            this.Property(t => t.LsInWay).HasColumnName("LsInWay");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.DocMz).HasColumnName("DocMz");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.IsYbMt).HasColumnName("IsYbMt");
            this.Property(t => t.YbRegNo).HasColumnName("YbRegNo");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.AgeDay).HasColumnName("AgeDay");
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
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.LinkmanArea).HasColumnName("LinkmanArea");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LeaveTime).HasColumnName("LeaveTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsEndChg).HasColumnName("IsEndChg");
            this.Property(t => t.EndChgOperID).HasColumnName("EndChgOperID");
            this.Property(t => t.EndchgoperTime).HasColumnName("EndchgoperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.MotherHospId).HasColumnName("MotherHospId");
            this.Property(t => t.FromHospitalId).HasColumnName("FromHospitalId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.LocOut).HasColumnName("LocOut");
            this.Property(t => t.TipsNurse).HasColumnName("TipsNurse");
            this.Property(t => t.TipsBalance).HasColumnName("TipsBalance");
            this.Property(t => t.TipsOther).HasColumnName("TipsOther");
            this.Property(t => t.OtherRoles).HasColumnName("OtherRoles");
            this.Property(t => t.IsIllegal).HasColumnName("IsIllegal");
            this.Property(t => t.UnLines).HasColumnName("UnLines");
            this.Property(t => t.Scale).HasColumnName("Scale");
            this.Property(t => t.FromHospital).HasColumnName("FromHospital");
            this.Property(t => t.NUMBER1).HasColumnName("NUMBER1");
            this.Property(t => t.NUMBER2).HasColumnName("NUMBER2");
            this.Property(t => t.NUMBER3).HasColumnName("NUMBER3");
            this.Property(t => t.NUMBER4).HasColumnName("NUMBER4");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.YBBZCode).HasColumnName("YBBZCode");

            // Relationships           

        }
    }
}
