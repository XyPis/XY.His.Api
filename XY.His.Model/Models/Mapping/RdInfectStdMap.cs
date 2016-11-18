using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdInfectStdMap : EntityTypeConfiguration<RdInfectStd>
    {
        public RdInfectStdMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.LsClincSymptom)
                .HasMaxLength(50);

            this.Property(t => t.ReportUnit)
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.JName)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("RdInfectStd");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsCardType).HasColumnName("LsCardType");
            this.Property(t => t.Gestation).HasColumnName("Gestation");
            this.Property(t => t.LsZone).HasColumnName("LsZone");
            this.Property(t => t.LsCancelType).HasColumnName("LsCancelType");
            this.Property(t => t.IllDate).HasColumnName("IllDate");
            this.Property(t => t.DiagDate).HasColumnName("DiagDate");
            this.Property(t => t.DeadDate).HasColumnName("DeadDate");
            this.Property(t => t.IllId).HasColumnName("IllId");
            this.Property(t => t.LsClincSymptom).HasColumnName("LsClincSymptom");
            this.Property(t => t.ReportUnit).HasColumnName("ReportUnit");
            this.Property(t => t.IllIdCor).HasColumnName("IllIdCor");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LsCTrust).HasColumnName("LsCTrust");
            this.Property(t => t.LsCTiter).HasColumnName("LsCTiter");
            this.Property(t => t.LsCTPPA).HasColumnName("LsCTPPA");
            this.Property(t => t.LsCOther).HasColumnName("LsCOther");
            this.Property(t => t.LsETrust).HasColumnName("LsETrust");
            this.Property(t => t.LsETiter).HasColumnName("LsETiter");
            this.Property(t => t.LsETPPA).HasColumnName("LsETPPA");
            this.Property(t => t.LsEIgM).HasColumnName("LsEIgM");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.JName).HasColumnName("JName");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.ReciOperId).HasColumnName("ReciOperId");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdInfectStds)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.RdInfectStds)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
