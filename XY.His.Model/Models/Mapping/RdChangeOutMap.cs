using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdChangeOutMap : EntityTypeConfiguration<RdChangeOut>
    {
        public RdChangeOutMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.ToHospital)
                .HasMaxLength(50);

            this.Property(t => t.BackDiagnose)
                .HasMaxLength(500);

            this.Property(t => t.Disposal)
                .HasMaxLength(2000);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.IllDesc)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RdChangeOut");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ChangeTime).HasColumnName("ChangeTime");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.ToHospital).HasColumnName("ToHospital");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.BackDiagnose).HasColumnName("BackDiagnose");
            this.Property(t => t.Disposal).HasColumnName("Disposal");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
