using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightInHosInfoMap : EntityTypeConfiguration<Vw_FlightInHosInfo>
    {
        public Vw_FlightInHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HospNo, t.InPatNo, t.PatID, t.LocationName, t.InTime, t.职业, t.LsMarriage, t.LsInType, t.入院目的, t.LsInIllness, t.Sensitive, t.不良反应 });

            // Properties
            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.职业)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LsMarriage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.入院目的)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LsInIllness)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sensitive)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.不良反应)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_FlightInHosInfo");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.职业).HasColumnName("职业");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.LsInType).HasColumnName("LsInType");
            this.Property(t => t.入院目的).HasColumnName("入院目的");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.不良反应).HasColumnName("不良反应");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
        }
    }
}
