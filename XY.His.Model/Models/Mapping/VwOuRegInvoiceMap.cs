using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuRegInvoiceMap : EntityTypeConfiguration<VwOuRegInvoice>
    {
        public VwOuRegInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InvoNo, t.IsCancel, t.InvoTime, t.RegFee, t.DiagnoFee, t.ZyFee, t.OtherFee1, t.OtherFee2, t.MzRegId, t.PatientName, t.SexName, t.PatId, t.MzRegNo, t.RegTypeId, t.RegDept, t.IsPriority, t.RoomNo, t.IsElder, t.IsFreeDiag, t.IsInPatient, t.IsPreReg, t.IsFreeReg, t.RegTime, t.OperId, t.PatTypeId, t.LineOrder });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CancelTimeStr)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.InvoTimeStr)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.RegFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiagnoFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ZyFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OtherFee1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OtherFee2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MzRegNo2)
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.RegTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.RegDept)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RegTimeStr)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.LineOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwOuRegInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelTimeStr).HasColumnName("CancelTimeStr");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.InvoTimeStr).HasColumnName("InvoTimeStr");
            this.Property(t => t.RegFee).HasColumnName("RegFee");
            this.Property(t => t.DiagnoFee).HasColumnName("DiagnoFee");
            this.Property(t => t.ZyFee).HasColumnName("ZyFee");
            this.Property(t => t.OtherFee1).HasColumnName("OtherFee1");
            this.Property(t => t.OtherFee2).HasColumnName("OtherFee2");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.MzRegNo2).HasColumnName("MzRegNo2");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.IsElder).HasColumnName("IsElder");
            this.Property(t => t.IsFreeDiag).HasColumnName("IsFreeDiag");
            this.Property(t => t.IsInPatient).HasColumnName("IsInPatient");
            this.Property(t => t.IsPreReg).HasColumnName("IsPreReg");
            this.Property(t => t.IsFreeReg).HasColumnName("IsFreeReg");
            this.Property(t => t.RegTimeStr).HasColumnName("RegTimeStr");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.DiagnDept).HasColumnName("DiagnDept");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.LineOrder).HasColumnName("LineOrder");
            this.Property(t => t.IsFirstDiag).HasColumnName("IsFirstDiag");
        }
    }
}
