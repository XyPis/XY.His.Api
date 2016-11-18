using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DoctorInSumMap : EntityTypeConfiguration<Vw_DoctorInSum>
    {
        public Vw_DoctorInSumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Price, t.Totality, t.Amount, t.MzRegId, t.InvoTime });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupSubName)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(100);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitIdName)
                .HasMaxLength(50);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.InvItemName)
                .HasMaxLength(50);

            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_DoctorInSum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GroupSubName).HasColumnName("GroupSubName");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitIdName).HasColumnName("UnitIdName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.InvItemName).HasColumnName("InvItemName");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
        }
    }
}
