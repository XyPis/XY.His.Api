using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Report_TableMap : EntityTypeConfiguration<Report_Table>
    {
        public Report_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tabel_Name)
                .HasMaxLength(20);

            this.Property(t => t.Filed_Name)
                .HasMaxLength(20);

            this.Property(t => t.Filed_ZW)
                .HasMaxLength(30);

            this.Property(t => t.Filed_Type)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Report_Table");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Tabel_Name).HasColumnName("Tabel_Name");
            this.Property(t => t.Filed_Name).HasColumnName("Filed_Name");
            this.Property(t => t.Filed_ZW).HasColumnName("Filed_ZW");
            this.Property(t => t.Filed_Type).HasColumnName("Filed_Type");
        }
    }
}
