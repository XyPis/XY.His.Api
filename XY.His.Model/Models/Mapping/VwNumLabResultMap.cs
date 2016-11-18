using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNumLabResultMap : EntityTypeConfiguration<VwNumLabResult>
    {
        public VwNumLabResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemName);

            // Properties
            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwNumLabResult");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Result).HasColumnName("Result");
        }
    }
}
