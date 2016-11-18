using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InLogInHospitalMap : EntityTypeConfiguration<InLogInHospital>
    {
        public InLogInHospitalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InLogInHospital");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InLogInHospitals)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InLogInHospitals)
                .HasForeignKey(d => d.HospId);

        }
    }
}
