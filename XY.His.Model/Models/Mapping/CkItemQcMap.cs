using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkItemQcMap : EntityTypeConfiguration<CkItemQc>
    {
        public CkItemQcMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.QcName)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkItemQc");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.QcName).HasColumnName("QcName");
            this.Property(t => t.Dev3).HasColumnName("Dev3");
            this.Property(t => t.Dev2).HasColumnName("Dev2");
            this.Property(t => t.Dev1).HasColumnName("Dev1");
            this.Property(t => t.DevM1).HasColumnName("DevM1");
            this.Property(t => t.DevM2).HasColumnName("DevM2");
            this.Property(t => t.DevM3).HasColumnName("DevM3");
            this.Property(t => t.AvgValue).HasColumnName("AvgValue");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.CtrlId).HasColumnName("CtrlId");

            // Relationships
            this.HasOptional(t => t.CkQcControl)
                .WithMany(t => t.CkItemQcs)
                .HasForeignKey(d => d.CtrlId);

        }
    }
}
