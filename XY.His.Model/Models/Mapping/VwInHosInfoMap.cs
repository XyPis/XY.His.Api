using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInHosInfoMap : EntityTypeConfiguration<VwInHosInfo>
    {
        public VwInHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.Name, t.SexName, t.InTime, t.Company, t.Residence });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WorkType)
                .HasMaxLength(50);

            this.Property(t => t.PatType)
                .HasMaxLength(50);

            this.Property(t => t.Doctor)
                .HasMaxLength(40);

            this.Property(t => t.Bed)
                .HasMaxLength(10);

            this.Property(t => t.Residence)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.LonIn)
                .HasMaxLength(30);

            this.Property(t => t.Location)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwInHosInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.WorkType).HasColumnName("WorkType");
            this.Property(t => t.PatType).HasColumnName("PatType");
            this.Property(t => t.Doctor).HasColumnName("Doctor");
            this.Property(t => t.Bed).HasColumnName("Bed");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.LonIn).HasColumnName("LonIn");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
