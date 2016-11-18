using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuDayReportMap : EntityTypeConfiguration<OuDayReport>
    {
        public OuDayReportMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RtpNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Remark)
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
            this.ToTable("OuDayReport");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RtpNo).HasColumnName("RtpNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.InArrear).HasColumnName("InArrear");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
