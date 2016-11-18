using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsnotYbMap : EntityTypeConfiguration<BsnotYb>
    {
        public BsnotYbMap()
        {
            // Primary Key
            this.HasKey(t => t.itemid);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.F4)
                .HasMaxLength(255);

            this.Property(t => t.itemid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BsnotYb");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.itemid).HasColumnName("itemid");
        }
    }
}
