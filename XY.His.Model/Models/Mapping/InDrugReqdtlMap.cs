using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDrugReqdtlMap : EntityTypeConfiguration<InDrugReqdtl>
    {
        public InDrugReqdtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
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

            this.Property(t => t.BedName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InDrugReqdtl");
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
            this.Property(t => t.LsSecMarkType).HasColumnName("LsSecMarkType");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.Refusal).HasColumnName("Refusal");
            this.Property(t => t.IsArrearage).HasColumnName("IsArrearage");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.LsArrearage).HasColumnName("LsArrearage");

            // Relationships
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.FrequencyId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.UnitReq);
            this.HasOptional(t => t.BsUnit1)
                .WithMany(t => t.InDrugReqdtls1)
                .HasForeignKey(d => d.UnitTake);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.InDrugReq)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.RequestId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InDrugReqdtls)
                .HasForeignKey(d => d.HospId);

        }
    }
}
