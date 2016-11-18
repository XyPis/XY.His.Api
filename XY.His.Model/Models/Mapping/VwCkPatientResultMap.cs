using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkPatientResultMap : EntityTypeConfiguration<VwCkPatientResult>
    {
        public VwCkPatientResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CardNo, t.Sex, t.TestId, t.PatientName, t.TestName, t.Code, t.LabNum, t.PatId, t.OperTime, t.Result, t.IsPass, t.Unit });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.TestName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LabNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LastResult)
                .HasMaxLength(100);

            this.Property(t => t.TestGroup)
                .HasMaxLength(100);

            this.Property(t => t.HighLow)
                .HasMaxLength(2);

            this.Property(t => t.IsDangerous)
                .HasMaxLength(2);

            this.Property(t => t.Compare)
                .HasMaxLength(2);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NormalRange)
                .HasMaxLength(63);

            this.Property(t => t.Age)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("VwCkPatientResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.TestName).HasColumnName("TestName");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.LastResult).HasColumnName("LastResult");
            this.Property(t => t.TestTypeId).HasColumnName("TestTypeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.TestGroup).HasColumnName("TestGroup");
            this.Property(t => t.HighLow).HasColumnName("HighLow");
            this.Property(t => t.IsDangerous).HasColumnName("IsDangerous");
            this.Property(t => t.Compare).HasColumnName("Compare");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.NormalRange).HasColumnName("NormalRange");
            this.Property(t => t.Age).HasColumnName("Age");
        }
    }
}
