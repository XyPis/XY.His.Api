using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VW_HisInPatientMap : EntityTypeConfiguration<VW_HisInPatient>
    {
        public VW_HisInPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PatID, t.InPatNo, t.HospNo, t.PatientName, t.Sex, t.SexName, t.AddressHome, t.YbRegNo, t.LocIn, t.NTime, t.InTime, t.LsInStatus, t.PatTypeId, t.OperTime, t.OperID, t.IsEndChg, t.IdCardNo, t.LinkmanName, t.LinkmanPhone, t.InvoiceStuts, t.IsBB });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.YbRegNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.RoomNo)
                .HasMaxLength(6);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.LocIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocInName)
                .HasMaxLength(30);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InDate)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.LsInStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Illness)
                .HasMaxLength(400);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LinkmanPhone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.LocSource)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceStuts)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.InvoiceTime)
                .HasMaxLength(100);

            this.Property(t => t.IsBB)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VW_HisInPatient");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.YbRegNo).HasColumnName("YbRegNo");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.LocInName).HasColumnName("LocInName");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InDate).HasColumnName("InDate");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.InDays).HasColumnName("InDays");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.LsGFPatTypeName).HasColumnName("LsGFPatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.MotherHospId).HasColumnName("MotherHospId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.Illness).HasColumnName("Illness");
            this.Property(t => t.IsEndChg).HasColumnName("IsEndChg");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.LocSource).HasColumnName("LocSource");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.InvoiceStuts).HasColumnName("InvoiceStuts");
            this.Property(t => t.InvoiceTime).HasColumnName("InvoiceTime");
            this.Property(t => t.IsBB).HasColumnName("IsBB");
        }
    }
}
