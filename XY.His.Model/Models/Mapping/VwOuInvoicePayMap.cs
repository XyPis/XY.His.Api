using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuInvoicePayMap : EntityTypeConfiguration<VwOuInvoicePay>
    {
        public VwOuInvoicePayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InvoId, t.InvoNo, t.Amount, t.PaywayId, t.PayWayName, t.MzRegId, t.IsCancel, t.OperId, t.OperTime });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PaywayId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayWayName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.CardNo)
                .HasMaxLength(13);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwOuInvoicePay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PaywayId).HasColumnName("PaywayId");
            this.Property(t => t.PayWayName).HasColumnName("PayWayName");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.OperName).HasColumnName("OperName");
        }
    }
}
