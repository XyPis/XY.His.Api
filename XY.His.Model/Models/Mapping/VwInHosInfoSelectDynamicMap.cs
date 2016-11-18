using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInHosInfoSelectDynamicMap : EntityTypeConfiguration<VwInHosInfoSelectDynamic>
    {
        public VwInHosInfoSelectDynamicMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PatTypeId, t.PatID, t.PatientName, t.HospNo, t.NTime, t.InTime, t.Sex, t.LsInStatus, t.InPatNo, t.BirthDate, t.GetTallyType, t.GetTallyTypeName, t.Age, t.Native, t.Residence, t.Company, t.Occupation, t.Mobile, t.Phone, t.Sensitive, t.IdCardNo, t.MedicareNo, t.LinkmanName, t.AgeString, t.WorkTypeName, t.MarriageName, t.NationName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LsInStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.GetTallyType)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.GetTallyTypeName)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Age)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Residence)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Occupation)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Sensitive)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedicareNo)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.AgeString)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.WorkTypeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MarriageName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NationName)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("VwInHosInfoSelectDynamic");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.FirtDay).HasColumnName("FirtDay");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.BedIsAdd).HasColumnName("BedIsAdd");
            this.Property(t => t.BedOrderBy).HasColumnName("BedOrderBy");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.GetTallyType).HasColumnName("GetTallyType");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.GetTallyTypeName).HasColumnName("GetTallyTypeName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.MotherHospId).HasColumnName("MotherHospId");
            this.Property(t => t.WorkTypeName).HasColumnName("WorkTypeName");
            this.Property(t => t.MarriageName).HasColumnName("MarriageName");
            this.Property(t => t.NationName).HasColumnName("NationName");
        }
    }
}
