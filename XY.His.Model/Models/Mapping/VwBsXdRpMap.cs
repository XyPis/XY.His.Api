using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBsXdRpMap : EntityTypeConfiguration<VwBsXdRp>
    {
        public VwBsXdRpMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Code, t.Name, t.GroupMain, t.GroupSub, t.WbCode, t.PyCode, t.LocationName, t.ItemName, t.UserName, t.ItemId, t.LocationId, t.OperId, t.LsOpenType });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupMain)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupSub)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsOpenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwBsXdRp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GroupMain).HasColumnName("GroupMain");
            this.Property(t => t.GroupSub).HasColumnName("GroupSub");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LsOpenType).HasColumnName("LsOpenType");
        }
    }
}
