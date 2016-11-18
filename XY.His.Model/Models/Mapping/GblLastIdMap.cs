using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblLastIdMap : EntityTypeConfiguration<GblLastId>
    {
        public GblLastIdMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TableName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GblLastId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.LastId).HasColumnName("LastId");
            this.Property(t => t.LastTime).HasColumnName("LastTime");
        }
    }
}
