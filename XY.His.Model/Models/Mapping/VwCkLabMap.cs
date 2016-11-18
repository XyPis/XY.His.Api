using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkLabMap : EntityTypeConfiguration<VwCkLab>
    {
        public VwCkLabMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LabNum, t.RefLocation, t.IllHistory, t.Diagnose, t.OperTime, t.OperId, t.IsPriority, t.IsCancel, t.LsSource });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LabNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.RefLocation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IllHistory)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.Diagnose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.CollectOperName)
                .HasMaxLength(30);

            this.Property(t => t.CancelOperName)
                .HasMaxLength(30);

            this.Property(t => t.LsSource)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSourceName)
                .HasMaxLength(8);

            this.Property(t => t.TestName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwCkLab");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.RefLocation).HasColumnName("RefLocation");
            this.Property(t => t.IllHistory).HasColumnName("IllHistory");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.CollectTime).HasColumnName("CollectTime");
            this.Property(t => t.CollectOperId).HasColumnName("CollectOperId");
            this.Property(t => t.CollectOperName).HasColumnName("CollectOperName");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperName).HasColumnName("CancelOperName");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.LsSource).HasColumnName("LsSource");
            this.Property(t => t.LsSourceName).HasColumnName("LsSourceName");
            this.Property(t => t.TestName).HasColumnName("TestName");
        }
    }
}
