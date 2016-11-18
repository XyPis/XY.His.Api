using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InDaySumMap : EntityTypeConfiguration<Vw_InDaySum>
    {
        public Vw_InDaySumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.Name, t.InTime, t.NTime, t.RegDate, t.NotPay, t.HasPay, t.DaySum, t.LocationName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.NotPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HasPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DaySum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_InDaySum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.NotPay).HasColumnName("NotPay");
            this.Property(t => t.HasPay).HasColumnName("HasPay");
            this.Property(t => t.DaySum).HasColumnName("DaySum");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
        }
    }
}
