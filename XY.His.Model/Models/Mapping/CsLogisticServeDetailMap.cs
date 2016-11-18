using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsLogisticServeDetailMap : EntityTypeConfiguration<CsLogisticServeDetail>
    {
        public CsLogisticServeDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Abstract)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ServeNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CsLogisticServeDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ServeDate).HasColumnName("ServeDate");
            this.Property(t => t.Abstract).HasColumnName("Abstract");
            this.Property(t => t.LogisticServeId).HasColumnName("LogisticServeId");
            this.Property(t => t.BenefitLocId).HasColumnName("BenefitLocId");
            this.Property(t => t.ServeLocId).HasColumnName("ServeLocId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Equivalent).HasColumnName("Equivalent");
            this.Property(t => t.ServeNo).HasColumnName("ServeNo");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsAcctMark).HasColumnName("IsAcctMark");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
