using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class main_aaMap : EntityTypeConfiguration<main_aa>
    {
        public main_aaMap()
        {
            // Primary Key
            this.HasKey(t => t.inbatchid);

            // Properties
            this.Property(t => t.inbatchid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("main_aa");
            this.Property(t => t.inbatchid).HasColumnName("inbatchid");
        }
    }
}
