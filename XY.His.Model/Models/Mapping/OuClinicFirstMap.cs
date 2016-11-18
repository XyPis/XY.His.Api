using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuClinicFirstMap : EntityTypeConfiguration<OuClinicFirst>
    {
        public OuClinicFirstMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MainInform)
                .HasMaxLength(500);

            this.Property(t => t.SickHist)
                .HasMaxLength(1000);

            this.Property(t => t.CheckUp)
                .HasMaxLength(1000);

            this.Property(t => t.CheckCT)
                .HasMaxLength(1000);

            this.Property(t => t.Disposal)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Impression)
                .HasMaxLength(1000);

            this.Property(t => t.Analys)
                .HasMaxLength(1000);

            this.Property(t => t.Others)
                .HasMaxLength(1000);

            this.Property(t => t.Tongue)
                .HasMaxLength(100);

            this.Property(t => t.Pulse)
                .HasMaxLength(100);

            this.Property(t => t.Moss)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuClinicFirst");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.MainInform).HasColumnName("MainInform");
            this.Property(t => t.SickHist).HasColumnName("SickHist");
            this.Property(t => t.ExamT).HasColumnName("ExamT");
            this.Property(t => t.ExamP).HasColumnName("ExamP");
            this.Property(t => t.ExamR).HasColumnName("ExamR");
            this.Property(t => t.ExamBp).HasColumnName("ExamBp");
            this.Property(t => t.ExamBp2).HasColumnName("ExamBp2");
            this.Property(t => t.CheckUp).HasColumnName("CheckUp");
            this.Property(t => t.CheckCT).HasColumnName("CheckCT");
            this.Property(t => t.Disposal).HasColumnName("Disposal");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Impression).HasColumnName("Impression");
            this.Property(t => t.Analys).HasColumnName("Analys");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.Tongue).HasColumnName("Tongue");
            this.Property(t => t.Pulse).HasColumnName("Pulse");
            this.Property(t => t.Moss).HasColumnName("Moss");
            this.Property(t => t.XMLEMR).HasColumnName("XMLEMR");
            this.Property(t => t.XMLCancer).HasColumnName("XMLCancer");
            this.Property(t => t.XMLSex).HasColumnName("XMLSex");
            this.Property(t => t.XMLTuberculosis).HasColumnName("XMLTuberculosis");
            this.Property(t => t.XMLContagion).HasColumnName("XMLContagion");
            this.Property(t => t.ExamSugar).HasColumnName("ExamSugar");
            this.Property(t => t.FirstDate).HasColumnName("FirstDate");

            // Relationships
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OuClinicFirsts)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
