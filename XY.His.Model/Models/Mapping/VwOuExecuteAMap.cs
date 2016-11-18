using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuExecuteAMap : EntityTypeConfiguration<VwOuExecuteA>
    {
        public VwOuExecuteAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MzRegNo, t.PatientName, t.MzRegId, t.GroupNum, t.NDay, t.NTime, t.IsExecuted, t.OperId, t.ItemName, t.Spec, t.Dosage, t.UnitTakeName, t.UsageName, t.FrequencyName, t.UnitDiagName, t.CardNo, t.ItemId, t.PriceDiag, t.Days });

            // Properties
            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitDiagName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwOuExecuteA");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.NDay).HasColumnName("NDay");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.ExecutedTime).HasColumnName("ExecutedTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.IssueTime).HasColumnName("IssueTime");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.DiagnDept).HasColumnName("DiagnDept");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.IsPatientBack).HasColumnName("IsPatientBack");
        }
    }
}
