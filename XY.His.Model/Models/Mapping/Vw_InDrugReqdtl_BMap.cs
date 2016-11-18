using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InDrugReqdtl_BMap : EntityTypeConfiguration<Vw_InDrugReqdtl_B>
    {
        public Vw_InDrugReqdtl_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.RequestId, t.ListNum, t.HospId, t.ForDate, t.ItemId, t.AdviceId, t.GroupNum, t.LsMarkType, t.Dosage, t.UnitReq, t.Totality, t.IsPrint, t.IsIssued, t.IsConfirm });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitReq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.RegDate)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_InDrugReqdtl_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitReq).HasColumnName("UnitReq");
            this.Property(t => t.UnitTake).HasColumnName("UnitTake");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.ConfirmOperId).HasColumnName("ConfirmOperId");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
        }
    }
}
