using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOpsApplyMap : EntityTypeConfiguration<VwOpsApply>
    {
        public VwOpsApplyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InPatNo, t.ID, t.ApplyNo, t.ApplyTime, t.OperTime });

            // Properties
            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.CardNo)
                .HasMaxLength(13);

            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.BsOPSName)
                .HasMaxLength(50);

            this.Property(t => t.BsDoctorName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VwOpsApply");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.BsLocationId).HasColumnName("BsLocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.BsOPSName).HasColumnName("BsOPSName");
            this.Property(t => t.BsOPSID).HasColumnName("BsOPSID");
            this.Property(t => t.BsDoctorName).HasColumnName("BsDoctorName");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.IsFinish).HasColumnName("IsFinish");
            this.Property(t => t.BsDoctorId).HasColumnName("BsDoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
        }
    }
}
