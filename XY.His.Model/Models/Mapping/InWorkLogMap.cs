using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InWorkLogMap : EntityTypeConfiguration<InWorkLog>
    {
        public InWorkLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Standard)
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

            // Table & Column Mappings
            this.ToTable("InWorkLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BedSum).HasColumnName("BedSum");
            this.Property(t => t.OverBedSum).HasColumnName("OverBedSum");
            this.Property(t => t.Standard).HasColumnName("Standard");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LastNum).HasColumnName("LastNum");
            this.Property(t => t.StartNum).HasColumnName("StartNum");
            this.Property(t => t.InHospital).HasColumnName("InHospital");
            this.Property(t => t.InLocation).HasColumnName("InLocation");
            this.Property(t => t.OutLocation).HasColumnName("OutLocation");
            this.Property(t => t.OutHospital).HasColumnName("OutHospital");
            this.Property(t => t.Dead).HasColumnName("Dead");
            this.Property(t => t.NowNum).HasColumnName("NowNum");
            this.Property(t => t.OverNum).HasColumnName("OverNum");
            this.Property(t => t.CompanyNum).HasColumnName("CompanyNum");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Danger).HasColumnName("Danger");
            this.Property(t => t.Heavy).HasColumnName("Heavy");
            this.Property(t => t.Acute).HasColumnName("Acute");
        }
    }
}
