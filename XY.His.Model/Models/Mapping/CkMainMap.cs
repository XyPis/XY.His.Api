using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkMainMap : EntityTypeConfiguration<CkMain>
    {
        public CkMainMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CancelMemo)
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

            this.Property(t => t.RptFileName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CkMain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CompanyCkeckId).HasColumnName("CompanyCkeckId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.RecieveTime).HasColumnName("RecieveTime");
            this.Property(t => t.RecieveOperId).HasColumnName("RecieveOperId");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.ReportOperId).HasColumnName("ReportOperId");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.ReportMemo).HasColumnName("ReportMemo");
            this.Property(t => t.TechMemo).HasColumnName("TechMemo");
            this.Property(t => t.OtherMemo).HasColumnName("OtherMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CompanyGroupId).HasColumnName("CompanyGroupId");
            this.Property(t => t.RptFileName).HasColumnName("RptFileName");
            this.Property(t => t.IsPay).HasColumnName("IsPay");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.CkCompany)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.CompanyId);
            this.HasOptional(t => t.CkCompanyCkeck)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.CompanyCkeckId);
            this.HasOptional(t => t.CkCompanyGroup)
                .WithMany(t => t.CkMains)
                .HasForeignKey(d => d.CompanyGroupId);

        }
    }
}
