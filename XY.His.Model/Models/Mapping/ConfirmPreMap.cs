using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ConfirmPreMap : EntityTypeConfiguration<ConfirmPre>
    {
        public ConfirmPreMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Presno)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PatientID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FPNO)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ConfirmPres");
            this.Property(t => t.Presno).HasColumnName("Presno");
            this.Property(t => t.PresDate).HasColumnName("PresDate");
            this.Property(t => t.WindowNO).HasColumnName("WindowNO");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.FPNO).HasColumnName("FPNO");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
