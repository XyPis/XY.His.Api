using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdLiverMap : EntityTypeConfiguration<RdLiver>
    {
        public RdLiverMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.JName)
                .HasMaxLength(10);

            this.Property(t => t.ALT)
                .HasMaxLength(10);

            this.Property(t => t.Tbil)
                .HasMaxLength(10);

            this.Property(t => t.HAV_RNA)
                .HasMaxLength(10);

            this.Property(t => t.HBV_DNA)
                .HasMaxLength(10);

            this.Property(t => t.HCV_RNA)
                .HasMaxLength(10);

            this.Property(t => t.K_HDV)
                .HasMaxLength(10);

            this.Property(t => t.HDV_RNA)
                .HasMaxLength(10);

            this.Property(t => t.HEV_RNA)
                .HasMaxLength(10);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(50);

            this.Property(t => t.ReportUnit)
                .HasMaxLength(10);

            this.Property(t => t.Phone)
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.ReportPerson)
                .HasMaxLength(10);

            this.Property(t => t.JReportPerson)
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RdLiver");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsCardType).HasColumnName("LsCardType");
            this.Property(t => t.LsCensus).HasColumnName("LsCensus");
            this.Property(t => t.JName).HasColumnName("JName");
            this.Property(t => t.LsZone).HasColumnName("LsZone");
            this.Property(t => t.LsCancelType).HasColumnName("LsCancelType");
            this.Property(t => t.IllDate).HasColumnName("IllDate");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.DeadDate).HasColumnName("DeadDate");
            this.Property(t => t.DiagDate).HasColumnName("DiagDate");
            this.Property(t => t.LsDiagType).HasColumnName("LsDiagType");
            this.Property(t => t.LsPreventive).HasColumnName("LsPreventive");
            this.Property(t => t.LsClinicType).HasColumnName("LsClinicType");
            this.Property(t => t.LsIllSource).HasColumnName("LsIllSource");
            this.Property(t => t.ALT).HasColumnName("ALT");
            this.Property(t => t.Tbil).HasColumnName("Tbil");
            this.Property(t => t.LsK_HAVIgM).HasColumnName("LsK_HAVIgM");
            this.Property(t => t.HAV_RNA).HasColumnName("HAV_RNA");
            this.Property(t => t.LsHbs_Ag).HasColumnName("LsHbs_Ag");
            this.Property(t => t.LsK_HBs).HasColumnName("LsK_HBs");
            this.Property(t => t.LsHBeAg).HasColumnName("LsHBeAg");
            this.Property(t => t.LsK_HBe).HasColumnName("LsK_HBe");
            this.Property(t => t.LsK_HBc).HasColumnName("LsK_HBc");
            this.Property(t => t.LsK_HBcIgM).HasColumnName("LsK_HBcIgM");
            this.Property(t => t.HBV_DNA).HasColumnName("HBV_DNA");
            this.Property(t => t.LsK_HCV).HasColumnName("LsK_HCV");
            this.Property(t => t.HCV_RNA).HasColumnName("HCV_RNA");
            this.Property(t => t.LsK_HDVIgM).HasColumnName("LsK_HDVIgM");
            this.Property(t => t.K_HDV).HasColumnName("K_HDV");
            this.Property(t => t.HDV_RNA).HasColumnName("HDV_RNA");
            this.Property(t => t.LsK_HEVIgM).HasColumnName("LsK_HEVIgM");
            this.Property(t => t.LsK_HEV).HasColumnName("LsK_HEV");
            this.Property(t => t.HEV_RNA).HasColumnName("HEV_RNA");
            this.Property(t => t.IllIdCor).HasColumnName("IllIdCor");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.ReportUnit).HasColumnName("ReportUnit");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.ReportPerson).HasColumnName("ReportPerson");
            this.Property(t => t.JReportDate).HasColumnName("JReportDate");
            this.Property(t => t.JReportPerson).HasColumnName("JReportPerson");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.ReciOperId).HasColumnName("ReciOperId");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdLivers)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.RdLivers)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
