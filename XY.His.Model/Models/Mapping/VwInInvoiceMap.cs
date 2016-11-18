using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInInvoiceMap : EntityTypeConfiguration<VwInInvoice>
    {
        public VwInInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LsPayType, t.ToDate, t.ChargeDays, t.Beprice, t.FactGet, t.Insurance, t.PaySelf, t.Deposit, t.Complement, t.Arrearage, t.AmountPay, t.AddFee, t.TallyNo, t.FromDate, t.OperId, t.IsCancel, t.HospId, t.PatTypeId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .HasMaxLength(20);

            this.Property(t => t.LsPayType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPayTypeName)
                .HasMaxLength(8);

            this.Property(t => t.ChargeDays)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Beprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FactGet)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Insurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PaySelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Deposit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Complement)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Arrearage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TallyNo)
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

            this.Property(t => t.OperTime)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.CancelOperTime)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.CancelOperName)
                .HasMaxLength(30);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .HasMaxLength(20);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwInInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.LsPayType).HasColumnName("LsPayType");
            this.Property(t => t.LsPayTypeName).HasColumnName("LsPayTypeName");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.ChargeDays).HasColumnName("ChargeDays");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.Deposit).HasColumnName("Deposit");
            this.Property(t => t.Complement).HasColumnName("Complement");
            this.Property(t => t.Arrearage).HasColumnName("Arrearage");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AddFee).HasColumnName("AddFee");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.CancelOperName).HasColumnName("CancelOperName");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InDays).HasColumnName("InDays");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
        }
    }
}
