using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsExecLocationMap : EntityTypeConfiguration<BsExecLocation>
    {
        public BsExecLocationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.IconIndex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimeBegin)
                .HasMaxLength(50);

            this.Property(t => t.TimeEnd)
                .HasMaxLength(50);

            this.Property(t => t.ExecPoint)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BsExecLocation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.TimeBegin).HasColumnName("TimeBegin");
            this.Property(t => t.TimeEnd).HasColumnName("TimeEnd");
            this.Property(t => t.ExecPoint).HasColumnName("ExecPoint");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsExecLocations)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsExecLocations)
                .HasForeignKey(d => d.LocationId);

        }
    }
}
