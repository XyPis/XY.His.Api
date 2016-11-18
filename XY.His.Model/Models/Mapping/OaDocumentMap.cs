using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OaDocumentMap : EntityTypeConfiguration<OaDocument>
    {
        public OaDocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InActiveReason)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("OaDocument");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GroupMainId).HasColumnName("GroupMainId");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.LsOpenType).HasColumnName("LsOpenType");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.Security).HasColumnName("Security");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
