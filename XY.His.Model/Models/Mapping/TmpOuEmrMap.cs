using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TmpOuEmrMap : EntityTypeConfiguration<TmpOuEmr>
    {
        public TmpOuEmrMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.GroupMain)
                .HasMaxLength(50);

            this.Property(t => t.GroupSub)
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(6);

            this.Property(t => t.PyCode)
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

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
            this.ToTable("TmpOuEmr");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GroupMain).HasColumnName("GroupMain");
            this.Property(t => t.GroupSub).HasColumnName("GroupSub");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.LsOpenType).HasColumnName("LsOpenType");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
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
            this.Property(t => t.Impression).HasColumnName("Impression");
            this.Property(t => t.Analys).HasColumnName("Analys");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.Tongue).HasColumnName("Tongue");
            this.Property(t => t.Pulse).HasColumnName("Pulse");
            this.Property(t => t.Moss).HasColumnName("Moss");
        }
    }
}
