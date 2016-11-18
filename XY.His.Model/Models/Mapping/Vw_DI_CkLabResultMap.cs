using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_CkLabResultMap : EntityTypeConfiguration<Vw_DI_CkLabResult>
    {
        public Vw_DI_CkLabResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.Result, t.ID, t.Name });

            // Properties
            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_DI_CkLabResult");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
