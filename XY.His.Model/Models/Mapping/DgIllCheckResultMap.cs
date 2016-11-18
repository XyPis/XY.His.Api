using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgIllCheckResultMap : EntityTypeConfiguration<DgIllCheckResult>
    {
        public DgIllCheckResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckResult)
                .HasMaxLength(500);

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

            // Table & Column Mappings
            this.ToTable("DgIllCheckResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.CheckResult).HasColumnName("CheckResult");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.IsWomen).HasColumnName("IsWomen");
            this.Property(t => t.IsMen).HasColumnName("IsMen");
            this.Property(t => t.IsOlder).HasColumnName("IsOlder");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}
