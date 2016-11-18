using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkResultMap : EntityTypeConfiguration<CkResult>
    {
        public CkResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LastResult)
                .HasMaxLength(100);

            this.Property(t => t.Result)
                .HasMaxLength(100);

            this.Property(t => t.ReportBy)
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.TextRange)
                .HasMaxLength(500);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.LastResult).HasColumnName("LastResult");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.LsRefFlag).HasColumnName("LsRefFlag");
            this.Property(t => t.IsPanic).HasColumnName("IsPanic");
            this.Property(t => t.IsDalta).HasColumnName("IsDalta");
            this.Property(t => t.DalAbsolute).HasColumnName("DalAbsolute");
            this.Property(t => t.DalPercent).HasColumnName("DalPercent");
            this.Property(t => t.LowValue).HasColumnName("LowValue");
            this.Property(t => t.HighValue).HasColumnName("HighValue");
            this.Property(t => t.PanicLow).HasColumnName("PanicLow");
            this.Property(t => t.PanicHigh).HasColumnName("PanicHigh");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.ReportBy).HasColumnName("ReportBy");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.TextRange).HasColumnName("TextRange");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.TestGroupId).HasColumnName("TestGroupId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");

            // Relationships
            this.HasRequired(t => t.CkMain)
                .WithMany(t => t.CkResults)
                .HasForeignKey(d => d.CheckId);
            this.HasOptional(t => t.CkTestGroup)
                .WithMany(t => t.CkResults)
                .HasForeignKey(d => d.TestGroupId);

        }
    }
}
