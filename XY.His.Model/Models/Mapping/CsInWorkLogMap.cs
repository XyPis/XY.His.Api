using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsInWorkLogMap : EntityTypeConfiguration<CsInWorkLog>
    {
        public CsInWorkLogMap()
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
            this.ToTable("CsInWorkLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.OriginalNum).HasColumnName("OriginalNum");
            this.Property(t => t.AdmittedOutps).HasColumnName("AdmittedOutps");
            this.Property(t => t.FromOtherDept).HasColumnName("FromOtherDept");
            this.Property(t => t.TotalInHospitalDays).HasColumnName("TotalInHospitalDays");
            this.Property(t => t.TotalInDeptDays).HasColumnName("TotalInDeptDays");
            this.Property(t => t.TransDeptNum).HasColumnName("TransDeptNum");
            this.Property(t => t.TotalBedUsedDays).HasColumnName("TotalBedUsedDays");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.InputTime).HasColumnName("InputTime");
            this.Property(t => t.BedUsedRates).HasColumnName("BedUsedRates");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
