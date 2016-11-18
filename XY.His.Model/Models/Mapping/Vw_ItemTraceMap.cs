using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_ItemTraceMap : EntityTypeConfiguration<Vw_ItemTrace>
    {
        public Vw_ItemTraceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.Spec, t.ItemTraceType, t.ItemId, t.LsRpType });

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.ItemTraceType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_ItemTrace");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ItemTraceType).HasColumnName("ItemTraceType");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
        }
    }
}
