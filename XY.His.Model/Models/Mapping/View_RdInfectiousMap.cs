using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class View_RdInfectiousMap : EntityTypeConfiguration<View_RdInfectious>
    {
        public View_RdInfectiousMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperTime, t.ID, t.OperID, t.Sex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Midwife)
                .HasMaxLength(10);

            this.Property(t => t.ReportUnit)
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.JName)
                .HasMaxLength(10);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("View_RdInfectious");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
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
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.ReciOperId).HasColumnName("ReciOperId");
            this.Property(t => t.AFPID).HasColumnName("AFPID");
            this.Property(t => t.IsWrite).HasColumnName("IsWrite");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
        }
    }
}
