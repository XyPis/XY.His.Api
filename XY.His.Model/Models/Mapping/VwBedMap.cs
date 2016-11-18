using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBedMap : EntityTypeConfiguration<VwBed>
    {
        public VwBedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.RoomNo, t.LocationId, t.OperID, t.OperTime, t.OrderBy, t.IconIndex, t.IsActive, t.LsClass, t.IsTaked, t.LsBALL, t.LsInStatus });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InTimeStr)
                .HasMaxLength(44);

            this.Property(t => t.Memo)
                .HasMaxLength(20);

            this.Property(t => t.OrderBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsClass)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.IsTaked)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsBALL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Weight)
                .HasMaxLength(12);

            this.Property(t => t.LsBALLName)
                .HasMaxLength(8);

            this.Property(t => t.HospNo)
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.AgeString)
                .HasMaxLength(100);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.IllDesc)
                .HasMaxLength(500);

            this.Property(t => t.LsInStatus)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("VwBed");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.InTimeStr).HasColumnName("InTimeStr");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsTaked).HasColumnName("IsTaked");
            this.Property(t => t.LsBALL).HasColumnName("LsBALL");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.LsBALLName).HasColumnName("LsBALLName");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.CaptionIcon).HasColumnName("CaptionIcon");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.MainBedId).HasColumnName("MainBedId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationIdPat).HasColumnName("LocationIdPat");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.IsNewIn).HasColumnName("IsNewIn");
            this.Property(t => t.IsUrgen).HasColumnName("IsUrgen");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.IsAddBed).HasColumnName("IsAddBed");
        }
    }
}
