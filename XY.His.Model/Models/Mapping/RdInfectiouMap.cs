using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdInfectiouMap : EntityTypeConfiguration<RdInfectiou>
    {
        public RdInfectiouMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Midwife)
                .HasMaxLength(10);

            this.Property(t => t.IllIdCor)
                .HasMaxLength(500);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(20);

            this.Property(t => t.ReportUnit)
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.JName)
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.QilLness)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RdInfectious");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsCardType).HasColumnName("LsCardType");
            this.Property(t => t.LsCensus).HasColumnName("LsCensus");
            this.Property(t => t.LsZone).HasColumnName("LsZone");
            this.Property(t => t.Midwife).HasColumnName("Midwife");
            this.Property(t => t.LsCancelType).HasColumnName("LsCancelType");
            this.Property(t => t.IllDate).HasColumnName("IllDate");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.DeadDate).HasColumnName("DeadDate");
            this.Property(t => t.DiagDate).HasColumnName("DiagDate");
            this.Property(t => t.LsPreventive).HasColumnName("LsPreventive");
            this.Property(t => t.IllIdCor).HasColumnName("IllIdCor");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.ReportUnit).HasColumnName("ReportUnit");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.JIllId).HasColumnName("JIllId");
            this.Property(t => t.YIllId).HasColumnName("YIllId");
            this.Property(t => t.BIllId).HasColumnName("BIllId");
            this.Property(t => t.QIllId).HasColumnName("QIllId");
            this.Property(t => t.JName).HasColumnName("JName");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.ReciOperId).HasColumnName("ReciOperId");
            this.Property(t => t.IsWrite).HasColumnName("IsWrite");
            this.Property(t => t.Canceloperid).HasColumnName("Canceloperid");
            this.Property(t => t.Chkoperid).HasColumnName("Chkoperid");
            this.Property(t => t.Printstart).HasColumnName("Printstart");
            this.Property(t => t.ChkOperTime).HasColumnName("ChkOperTime");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.lscanceltype2).HasColumnName("lscanceltype2");
            this.Property(t => t.Hospid).HasColumnName("Hospid");
            this.Property(t => t.WorkType).HasColumnName("WorkType");
            this.Property(t => t.QilLness).HasColumnName("QilLness");
            this.Property(t => t.AfpID).HasColumnName("AfpID");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdInfectious)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.RdInfectious)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
