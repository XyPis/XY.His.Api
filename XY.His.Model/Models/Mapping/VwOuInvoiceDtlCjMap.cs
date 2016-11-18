using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuInvoiceDtlCjMap : EntityTypeConfiguration<VwOuInvoiceDtlCj>
    {
        public VwOuInvoiceDtlCjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.Code, t.Name, t.Spec, t.LocationName, t.DoctorName, t.Price, t.UnitIdName, t.ExecLocId, t.ExecLocName, t.LsPerform, t.LsPerformName, t.InvItemName, t.FeeId, t.FeetyName, t.InvItemId, t.InvoId, t.InvoNo, t.MzRegId, t.PatientName, t.InvoTime, t.TallyNo, t.MzRegNo, t.PatId, t.SexName, t.PatTypeName, t.OperId, t.OperName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitIdName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerformName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.InvItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeetyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.TallyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.PatTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwOuInvoiceDtlCj");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitIdName).HasColumnName("UnitIdName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.ExecLocName).HasColumnName("ExecLocName");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.LsPerformName).HasColumnName("LsPerformName");
            this.Property(t => t.InvItemName).HasColumnName("InvItemName");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.FeetyName).HasColumnName("FeetyName");
            this.Property(t => t.InvItemId).HasColumnName("InvItemId");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.TallyNo).HasColumnName("TallyNo");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperName).HasColumnName("OperName");
        }
    }
}
