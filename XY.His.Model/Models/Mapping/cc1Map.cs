using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class cc1Map : EntityTypeConfiguration<cc1>
    {
        public cc1Map()
        {
            // Primary Key
            this.HasKey(t => t.inbatchid);

            // Properties
            // Table & Column Mappings
            this.ToTable("cc1");
            this.Property(t => t.inbatchid).HasColumnName("inbatchid");
            this.Property(t => t.sl).HasColumnName("sl");
            this.Property(t => t.retailamount).HasColumnName("retailamount");
        }
    }
}
