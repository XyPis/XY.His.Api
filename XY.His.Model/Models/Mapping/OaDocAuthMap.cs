using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OaDocAuthMap : EntityTypeConfiguration<OaDocAuth>
    {
        public OaDocAuthMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RejectReason)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OaDocAuth");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DocId).HasColumnName("DocId");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.IsReject).HasColumnName("IsReject");
            this.Property(t => t.RejectReason).HasColumnName("RejectReason");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LsReadClass).HasColumnName("LsReadClass");
        }
    }
}
