using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OutMedTableHiMap : EntityTypeConfiguration<OutMedTableHi>
    {
        public OutMedTableHiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PresNO)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.MedOnlyCode)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.MedPack)
                .HasMaxLength(40);

            this.Property(t => t.MedUnitPack)
                .HasMaxLength(20);

            this.Property(t => t.MedUnit)
                .HasMaxLength(40);

            this.Property(t => t.PresType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PatientID)
                .HasMaxLength(60);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.PatientSex)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.PatientAge)
                .HasMaxLength(8);

            this.Property(t => t.PatientBirth)
                .HasMaxLength(40);

            this.Property(t => t.Diagnosis)
                .HasMaxLength(100);

            this.Property(t => t.WardNO)
                .HasMaxLength(20);

            this.Property(t => t.WardName)
                .HasMaxLength(64);

            this.Property(t => t.MedPerdos)
                .HasMaxLength(40);

            this.Property(t => t.MedUsage)
                .HasMaxLength(80);

            this.Property(t => t.MedPerday)
                .HasMaxLength(40);

            this.Property(t => t.DoctorName)
                .HasMaxLength(64);

            this.Property(t => t.FPNO)
                .HasMaxLength(60);

            this.Property(t => t.SEndflag)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MedType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Remark)
                .HasMaxLength(60);

            this.Property(t => t.YFCode)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Endflag)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.YfFinish)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("OutMedTableHis");
            this.Property(t => t.PresNO).HasColumnName("PresNO");
            this.Property(t => t.MedID).HasColumnName("MedID");
            this.Property(t => t.MedOnlyCode).HasColumnName("MedOnlyCode");
            this.Property(t => t.MedAMT).HasColumnName("MedAMT");
            this.Property(t => t.MedPack).HasColumnName("MedPack");
            this.Property(t => t.MedUnitPack).HasColumnName("MedUnitPack");
            this.Property(t => t.MedUnit).HasColumnName("MedUnit");
            this.Property(t => t.MedOutTime).HasColumnName("MedOutTime");
            this.Property(t => t.PresType).HasColumnName("PresType");
            this.Property(t => t.WindowNO).HasColumnName("WindowNO");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.PatientSex).HasColumnName("PatientSex");
            this.Property(t => t.PatientAge).HasColumnName("PatientAge");
            this.Property(t => t.PatientBirth).HasColumnName("PatientBirth");
            this.Property(t => t.Diagnosis).HasColumnName("Diagnosis");
            this.Property(t => t.WardNO).HasColumnName("WardNO");
            this.Property(t => t.WardName).HasColumnName("WardName");
            this.Property(t => t.MedPerdos).HasColumnName("MedPerdos");
            this.Property(t => t.MedUsage).HasColumnName("MedUsage");
            this.Property(t => t.MedPerday).HasColumnName("MedPerday");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.FPNO).HasColumnName("FPNO");
            this.Property(t => t.SEndflag).HasColumnName("SEndflag");
            this.Property(t => t.MedUnitPrice).HasColumnName("MedUnitPrice");
            this.Property(t => t.MedTotalPrice).HasColumnName("MedTotalPrice");
            this.Property(t => t.MedType).HasColumnName("MedType");
            this.Property(t => t.MedConvercof).HasColumnName("MedConvercof");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.YFCode).HasColumnName("YFCode");
            this.Property(t => t.Endflag).HasColumnName("Endflag");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YfFinish).HasColumnName("YfFinish");
        }
    }
}
