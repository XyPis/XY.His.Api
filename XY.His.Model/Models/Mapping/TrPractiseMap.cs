using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TrPractiseMap : EntityTypeConfiguration<TrPractise>
    {
        public TrPractiseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Hospital)
                .HasMaxLength(50);

            this.Property(t => t.Funtion)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.RoleName)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TrPractise");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hospital).HasColumnName("Hospital");
            this.Property(t => t.OriId).HasColumnName("OriId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PractiseTime).HasColumnName("PractiseTime");
            this.Property(t => t.DebugMode).HasColumnName("DebugMode");
            this.Property(t => t.Funtion).HasColumnName("Funtion");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
