using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightExamineMap : EntityTypeConfiguration<Vw_FlightExamine>
    {
        public Vw_FlightExamineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CkLabDtlID, t.优先标志, t.PatId, t.patientName, t.Sex, t.检验目的, t.Diagnose, t.OperTime, t.结果状态, t.费用, t.应收费用 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CkLabDtlID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.优先标志)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.patientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NamePY)
                .HasMaxLength(4000);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Age)
                .HasMaxLength(40);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.检验目的)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Diagnose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.DoctorName)
                .HasMaxLength(30);

            this.Property(t => t.结果状态)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ReportName)
                .HasMaxLength(30);

            this.Property(t => t.AuthOperNae)
                .HasMaxLength(30);

            this.Property(t => t.费用)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.应收费用)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ReportMemo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Vw_FlightExamine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CkLabDtlID).HasColumnName("CkLabDtlID");
            this.Property(t => t.优先标志).HasColumnName("优先标志");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.AuthTime).HasColumnName("AuthTime");
            this.Property(t => t.patientName).HasColumnName("patientName");
            this.Property(t => t.NamePY).HasColumnName("NamePY");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.检验目的).HasColumnName("检验目的");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.CollectTime).HasColumnName("CollectTime");
            this.Property(t => t.RecieveTime).HasColumnName("RecieveTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.CollectLocId).HasColumnName("CollectLocId");
            this.Property(t => t.结果状态).HasColumnName("结果状态");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.ReportOperId).HasColumnName("ReportOperId");
            this.Property(t => t.ReportName).HasColumnName("ReportName");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.AuthOperNae).HasColumnName("AuthOperNae");
            this.Property(t => t.费用).HasColumnName("费用");
            this.Property(t => t.应收费用).HasColumnName("应收费用");
            this.Property(t => t.ReportMemo).HasColumnName("ReportMemo");
        }
    }
}
