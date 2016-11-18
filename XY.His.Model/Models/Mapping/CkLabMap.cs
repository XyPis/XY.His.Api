using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkLabMap : EntityTypeConfiguration<CkLab>
    {
        public CkLabMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LabNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.RefLocation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IllHistory)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Diagnose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.ReportMemo)
                .HasMaxLength(1000);

            this.Property(t => t.TechMemo)
                .HasMaxLength(1000);

            this.Property(t => t.OtherMemo)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkLab");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsSource).HasColumnName("LsSource");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.RefLocation).HasColumnName("RefLocation");
            this.Property(t => t.IllHistory).HasColumnName("IllHistory");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.CollectTime).HasColumnName("CollectTime");
            this.Property(t => t.CollectOperId).HasColumnName("CollectOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.ReportMemo).HasColumnName("ReportMemo");
            this.Property(t => t.TechMemo).HasColumnName("TechMemo");
            this.Property(t => t.OtherMemo).HasColumnName("OtherMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.RecieveTime).HasColumnName("RecieveTime");
            this.Property(t => t.RecieveOperId).HasColumnName("RecieveOperId");
            this.Property(t => t.ResultTime).HasColumnName("ResultTime");
            this.Property(t => t.ResultOperId).HasColumnName("ResultOperId");
            this.Property(t => t.AuthTime).HasColumnName("AuthTime");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.ReportOperId).HasColumnName("ReportOperId");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.TestTypeId).HasColumnName("TestTypeId");
            this.Property(t => t.CollectLocId).HasColumnName("CollectLocId");
            this.Property(t => t.TogetherNum).HasColumnName("TogetherNum");
            this.Property(t => t.SJOperId).HasColumnName("SJOperId");
            this.Property(t => t.SJOperTime).HasColumnName("SJOperTime");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.CkLabs1)
                .HasForeignKey(d => d.CollectLocId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.CkLabs1)
                .HasForeignKey(d => d.CancelOperId);
            this.HasOptional(t => t.CkTestType)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.TestTypeId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.CkLabs)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
