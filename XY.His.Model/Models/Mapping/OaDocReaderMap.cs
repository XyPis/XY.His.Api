using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OaDocReaderMap : EntityTypeConfiguration<OaDocReader>
    {
        public OaDocReaderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OaDocReader");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DocId).HasColumnName("DocId");
            this.Property(t => t.AllowOperId).HasColumnName("AllowOperId");
            this.Property(t => t.ExpireTime).HasColumnName("ExpireTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
