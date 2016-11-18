using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class bb1Map : EntityTypeConfiguration<bb1>
    {
        public bb1Map()
        {
            // Primary Key
            this.HasKey(t => t.inbatchid);

            // Properties
            this.Property(t => t.inbatchid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("bb1");
            this.Property(t => t.inbatchid).HasColumnName("inbatchid");
            this.Property(t => t.SL).HasColumnName("SL");
            this.Property(t => t.retailamount).HasColumnName("retailamount");
        }
    }
}
