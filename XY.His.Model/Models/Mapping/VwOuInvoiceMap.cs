using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuInvoiceMap : EntityTypeConfiguration<VwOuInvoice>
    {
        public VwOuInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InvoNo, t.InvoTime, t.InvoId, t.FactGet, t.Insurance, t.PaySelf, t.AmountPay, t.AddFee, t.TallyNo, t.MzRegId, t.OperTime, t.OperId, t.IsCancel });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.InvoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FactGet)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Insurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PaySelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TallyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.Sex)
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LsGFPatTypeName)
                .HasMaxLength(8);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.WorkTypeName)
                .HasMaxLength(50);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(500);

            this.Property(t => t.CancelOperName)
                .HasMaxLength(30);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.InvoLastNo)
                .HasMaxLength(12);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("VwOuInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AddFee).HasColumnName("AddFee");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
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
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.WorkTypeName).HasColumnName("WorkTypeName");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.CancelOperName).HasColumnName("CancelOperName");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.InvoLastNo).HasColumnName("InvoLastNo");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
