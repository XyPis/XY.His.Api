using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsOuWorkLogMap : EntityTypeConfiguration<CsOuWorkLog>
    {
        public CsOuWorkLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YearMonth)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CsOuWorkLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.OutpNum).HasColumnName("OutpNum");
            this.Property(t => t.OperatedNum).HasColumnName("OperatedNum");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.InputTime).HasColumnName("InputTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.CsOuWorkLogs)
                .HasForeignKey(d => d.OperId);

        }
    }
}
