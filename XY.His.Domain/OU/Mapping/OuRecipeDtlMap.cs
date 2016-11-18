using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.OU.Mapping
{
    public class OuRecipeDtlMap : EntityTypeConfiguration<OuRecipeDtl>
    {
        public OuRecipeDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrepareTime)
                .HasMaxLength(50);

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

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuRecipeDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.XDRpId).HasColumnName("XDRpId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.IsPrepared).HasColumnName("IsPrepared");
            this.Property(t => t.PrepareTime).HasColumnName("PrepareTime");
            this.Property(t => t.PrepareOperId).HasColumnName("PrepareOperId");
            this.Property(t => t.IsIssue).HasColumnName("IsIssue");
            this.Property(t => t.IssueTime).HasColumnName("IssueTime");
            this.Property(t => t.IssueOperId).HasColumnName("IssueOperId");
            this.Property(t => t.IsToBack).HasColumnName("IsToBack");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsDoctorInput).HasColumnName("IsDoctorInput");
            this.Property(t => t.RecNum).HasColumnName("RecNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.AllPageNo).HasColumnName("AllPageNo");
            this.Property(t => t.PageNo).HasColumnName("PageNo");

            // Relationships  
        }
    }
}
