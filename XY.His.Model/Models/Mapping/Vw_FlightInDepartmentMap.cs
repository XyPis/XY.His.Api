using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightInDepartmentMap : EntityTypeConfiguration<Vw_FlightInDepartment>
    {
        public Vw_FlightInDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.科室简称或别名, t.临床科室属性, t.LsInOut, t.内外科标志 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.科室简称或别名)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.临床科室属性)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LsInOut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.内外科标志)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.输入码)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Vw_FlightInDepartment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.科室简称或别名).HasColumnName("科室简称或别名");
            this.Property(t => t.临床科室属性).HasColumnName("临床科室属性");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.内外科标志).HasColumnName("内外科标志");
            this.Property(t => t.输入码).HasColumnName("输入码");
        }
    }
}
