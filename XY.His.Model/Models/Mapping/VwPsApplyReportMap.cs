using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwPsApplyReportMap : EntityTypeConfiguration<VwPsApplyReport>
    {
        public VwPsApplyReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ApplyNo, t.OperTime, t.ApplyOperName, t.XType, t.CheckOperName, t.IsAbNormal });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.ApplyOperName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.MzRegNo)
                .HasMaxLength(12);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.CardNo)
                .HasMaxLength(13);

            this.Property(t => t.XType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Equipment)
                .HasMaxLength(50);

            this.Property(t => t.CheckOperName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CheckBody)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwPsApplyReport");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ApplyOperName).HasColumnName("ApplyOperName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.XType).HasColumnName("XType");
            this.Property(t => t.Equipment).HasColumnName("Equipment");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CheckOperName).HasColumnName("CheckOperName");
            this.Property(t => t.CheckBody).HasColumnName("CheckBody");
            this.Property(t => t.IsAbNormal).HasColumnName("IsAbNormal");
        }
    }
}
