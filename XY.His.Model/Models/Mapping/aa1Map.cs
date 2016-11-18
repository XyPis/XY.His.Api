using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class aa1Map : EntityTypeConfiguration<aa1>
    {
        public aa1Map()
        {
            // Primary Key
            this.HasKey(t => t.inbatchid);

            // Properties
            this.Property(t => t.inbatchid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("aa1");
            this.Property(t => t.inbatchid).HasColumnName("inbatchid");
            this.Property(t => t.retailamount).HasColumnName("retailamount");
            this.Property(t => t.SL).HasColumnName("SL");
        }
    }
}
